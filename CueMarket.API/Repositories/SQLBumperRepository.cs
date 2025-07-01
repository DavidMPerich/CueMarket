using CueMarket.API.Data;
using CueMarket.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CueMarket.API.Repositories
{
    public class SQLBumperRepository : IBumperRepository
    {
        private readonly CueMarketDbContext dbContext;

        public SQLBumperRepository(CueMarketDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Bumper> CreateAsync(Bumper bumper)
        {
            await dbContext.Bumpers.AddAsync(bumper);
            await dbContext.SaveChangesAsync();
            return bumper;
        }

        public async Task<Bumper?> DeleteAsync(Guid id)
        {
            var existingBumper = await dbContext.Bumpers.FirstOrDefaultAsync(x => x.Id == id);

            if (existingBumper == null)
            {
                return null;
            }

            dbContext.Bumpers.Remove(existingBumper);
            await dbContext.SaveChangesAsync();

            return existingBumper;
        }

        public async Task<List<Bumper>> GetAllAsync()
        {
            return await dbContext.Bumpers.ToListAsync();
        }

        public async Task<Bumper?> GetByIdAsync(Guid id)
        {
            return await dbContext.Bumpers.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Bumper?> UpdateAsync(Guid id, Bumper bumper)
        {
            var existingBumper = await dbContext.Bumpers.FirstOrDefaultAsync(x => x.Id == id);

            if (existingBumper == null)
            {
                return null;
            }

            existingBumper.Maker = bumper.Maker;
            existingBumper.Type = bumper.Type;

            await dbContext.SaveChangesAsync();
            return existingBumper;
        }
    }
}
