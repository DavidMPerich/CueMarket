using CueMarket.API.Controllers;
using CueMarket.API.Data;
using CueMarket.API.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace CueMarket.API.Repositories
{
    public class SQLCueRepository : ICueRepository
    {
        private readonly CueMarketDbContext dbContext;

        public SQLCueRepository(CueMarketDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Cue> CreateAsync(Cue cue)
        {
            await dbContext.Cues.AddAsync(cue);
            await dbContext.SaveChangesAsync();
            return cue;
        }

        public async Task<Cue?> DeleteAsync(Guid id)
        {
            var existingCue = await dbContext.Cues.FirstOrDefaultAsync(x => x.Id == id);

            if (existingCue == null)
            {
                return null;
            }

            dbContext.Cues.Remove(existingCue);
            await dbContext.SaveChangesAsync();

            return existingCue;
        }

        public async Task<List<Cue>> GetAllAsync(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool isAscending = true)
        {
            var cues = dbContext.Cues
                .Include("User")
                .Include("Butt")
                .Include("Butt.CollarMaterial")
                .Include("Butt.RingB")
                .Include("Butt.RingB.Material")
                .Include("Butt.Forearm")
                .Include("Butt.Forearm.Material")
                .Include("Butt.RingC")
                .Include("Butt.RingC.Material")
                .Include("Butt.Wrap")
                .Include("Butt.Wrap.Material")
                .Include("Butt.RingD")
                .Include("Butt.RingD.Material")
                .Include("Butt.ButtSleeve")
                .Include("Butt.RingE")
                .Include("Butt.RingE.Material")
                .Include("Butt.ButtCapMaterial")
                .Include("Butt.Bumper")
                .Include("Butt.WeightBolt")
                .AsQueryable();

            //Filtering
            if (!string.IsNullOrWhiteSpace(filterOn) && !string.IsNullOrWhiteSpace(filterQuery))
            {
                if (filterOn.Equals("Maker", StringComparison.OrdinalIgnoreCase))
                {
                    cues = cues.Where(x => x.Maker.Contains(filterQuery));
                }
            }

            //Sorting
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                if (sortBy.Equals("Maker", StringComparison.OrdinalIgnoreCase))
                {
                    cues = isAscending ? cues.OrderBy(x => x.Maker) : cues.OrderByDescending(x => x.Maker);
                }
            }

            return await cues.ToListAsync();
        }

        public async Task<Cue?> GetByIdAsync(Guid id)
        {
            return await dbContext.Cues
                .Include("User")
                .Include("Butt")
                .Include("Butt.CollarMaterial")
                .Include("Butt.RingB")
                .Include("Butt.RingB.Material")
                .Include("Butt.Forearm")
                .Include("Butt.Forearm.Material")
                .Include("Butt.RingC")
                .Include("Butt.RingC.Material")
                .Include("Butt.Wrap")
                .Include("Butt.Wrap.Material")
                .Include("Butt.RingD")
                .Include("Butt.RingD.Material")
                .Include("Butt.ButtSleeve")
                .Include("Butt.RingE")
                .Include("Butt.RingE.Material")
                .Include("Butt.ButtCapMaterial")
                .Include("Butt.Bumper")
                .Include("Butt.WeightBolt")
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Cue?> UpdateAsync(Guid id, Cue cue)
        {
            var existingCue = await dbContext.Cues.FirstOrDefaultAsync(x => x.Id == id);

            if (existingCue == null)
            {
                return null;
            }

            existingCue.Maker = cue.Maker;
            existingCue.ButtId = cue.ButtId;
            existingCue.JointType = cue.JointType;

            await dbContext.SaveChangesAsync();
            return existingCue;
        }
    }
}
