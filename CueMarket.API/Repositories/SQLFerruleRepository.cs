using CueMarket.API.Data;
using CueMarket.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CueMarket.API.Repositories
{
    public class SQLFerruleRepository : IFerruleRepository
    {
        private readonly CueMarketDbContext dbContext;

        public SQLFerruleRepository(CueMarketDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Ferrule> CreateAsync(Ferrule ferrule)
        {
            await dbContext.Ferrules.AddAsync(ferrule);
            await dbContext.SaveChangesAsync();
            await dbContext.Entry(ferrule).Reference(x => x.Material).LoadAsync();
            return ferrule;
        }

        public async Task<Ferrule?> DeleteAsync(Guid id)
        {
            var existingFerrule = await dbContext.Ferrules.FirstOrDefaultAsync(x => x.Id == id);

            if (existingFerrule == null)
            {
                return null;
            }

            dbContext.Ferrules.Remove(existingFerrule);
            await dbContext.SaveChangesAsync();
            await dbContext.Entry(existingFerrule).Reference(x => x.Material).LoadAsync();
            return existingFerrule;
        }

        public async Task<List<Ferrule>> GetAllAsync()
        {
            return await dbContext.Ferrules.Include("Material").ToListAsync();
        }

        public async Task<Ferrule?> GetByIdAsync(Guid id)
        {
            return await dbContext.Ferrules.Include("Material").FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Ferrule?> UpdateAsync(Guid id, Ferrule ferrule)
        {
            var existingFerrule = await dbContext.Ferrules.FirstOrDefaultAsync(x => x.Id == id);

            if (existingFerrule == null)
            {
                return null;
            }

            existingFerrule.Brand = ferrule.Brand;
            existingFerrule.MaterialId = ferrule.MaterialId;
            existingFerrule.Capped = ferrule.Capped;
            existingFerrule.Size = ferrule.Size;

            await dbContext.SaveChangesAsync();
            await dbContext.Entry(existingFerrule).Reference(x => x.Material).LoadAsync();
            return existingFerrule;
        }
    }
}
