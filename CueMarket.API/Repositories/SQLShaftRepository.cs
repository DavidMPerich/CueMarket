using CueMarket.API.Data;
using CueMarket.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CueMarket.API.Repositories
{
    public class SQLShaftRepository : IShaftRepository
    {
        private readonly CueMarketDbContext dbContext;

        public SQLShaftRepository(CueMarketDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Shaft> CreateAsync(Shaft shaft)
        {
            await dbContext.Shafts.AddAsync(shaft);
            await dbContext.SaveChangesAsync();
            return shaft;
        }

        public async Task<Shaft?> DeleteAsync(Guid id)
        {
            var existingShaft = await dbContext.Shafts.FirstOrDefaultAsync(x => x.Id == id);

            if (existingShaft == null)
            {
                return null;
            }

            dbContext.Shafts.Remove(existingShaft);
            await dbContext.SaveChangesAsync();

            return existingShaft;
        }

        public async Task<List<Shaft>> GetAllAsync()
        {
            return await dbContext.Shafts.ToListAsync();
        }

        public async Task<Shaft?> GetByIdAsync(Guid id)
        {
            return await dbContext.Shafts.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Shaft?> UpdateAsync(Guid id, Shaft shaft)
        {
            var existingShaft = await dbContext.Shafts.FirstOrDefaultAsync(x => x.Id == id);

            if (existingShaft == null)
            {
                return null;
            }

            existingShaft.Maker = shaft.Maker;
            existingShaft.MaterialId = shaft.MaterialId;
            existingShaft.TipId = shaft.TipId;
            existingShaft.FerruleId = shaft.FerruleId;
            existingShaft.RingAId = shaft.RingAId;
            existingShaft.CollarMaterialId = shaft.CollarMaterialId;
            existingShaft.CueId = shaft.CueId;

            await dbContext.SaveChangesAsync();
            return existingShaft;
        }
    }
}
