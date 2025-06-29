using CueMarket.API.Data;
using CueMarket.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CueMarket.API.Repositories
{
    public class SQLWeightBoltRepository : IWeightBoltRepository
    {
        private readonly CueMarketDbContext dbContext;

        public SQLWeightBoltRepository(CueMarketDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<WeightBolt> CreateAsync(WeightBolt weightBolt)
        {
            await dbContext.WeightBolts.AddAsync(weightBolt);
            await dbContext.SaveChangesAsync();
            return weightBolt;
        }

        public async Task<WeightBolt?> DeleteAsync(Guid id)
        {
            var existingWeightBolt = dbContext.WeightBolts.FirstOrDefault(x => x.Id == id);

            if (existingWeightBolt == null)
            {
                return null;
            }

            dbContext.WeightBolts.Remove(existingWeightBolt);
            await dbContext.SaveChangesAsync();

            return existingWeightBolt;
        }

        public async Task<List<WeightBolt>> GetAllAsync()
        {
            return await dbContext.WeightBolts.ToListAsync();
        }

        public async Task<WeightBolt?> GetByIdAsync(Guid id)
        {
            return await dbContext.WeightBolts.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<WeightBolt?> UpdateAsync(Guid id, WeightBolt weightBolt)
        {
            var existingWeightBolt = await dbContext.WeightBolts.FirstOrDefaultAsync(x => x.Id == id);

            if (existingWeightBolt == null)
            {
                return null;
            }

            existingWeightBolt.Maker = weightBolt.Maker;
            existingWeightBolt.Weight = weightBolt.Weight;
            existingWeightBolt.Thread = weightBolt.Thread;

            await dbContext.SaveChangesAsync();
            return existingWeightBolt;
        }
    }
}
