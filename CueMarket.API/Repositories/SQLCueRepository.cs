using CueMarket.API.Data;
using CueMarket.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

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

        public async Task<List<Cue>> GetAllAsync()
        {
            return await dbContext.Cues.Include("Butt").ToListAsync();
        }

        public async Task<Cue?> GetByIdAsync(Guid id)
        {
            return await dbContext.Cues.FirstOrDefaultAsync(x => x.Id == id);

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
