using CueMarket.API.Data;
using CueMarket.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CueMarket.API.Repositories
{
    public class SQLForearmRepository : IForearmRepository
    {
        private readonly CueMarketDbContext dbContext;

        public SQLForearmRepository(CueMarketDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Forearm> CreateAsync(Forearm forearm)
        {
            await dbContext.Forearms.AddAsync(forearm);
            await dbContext.SaveChangesAsync();
            await dbContext.Entry(forearm).Reference(x => x.Material).LoadAsync();
            return forearm;
        }

        public async Task<Forearm?> DeleteAsync(Guid id)
        {
            var existingForearm = await dbContext.Forearms.FirstOrDefaultAsync(x => x.Id == id);

            if (existingForearm == null)
            {
                return null;
            }

            dbContext.Forearms.Remove(existingForearm);
            await dbContext.SaveChangesAsync();
            await dbContext.Entry(existingForearm).Reference(x => x.Material).LoadAsync();

            return existingForearm;
        }

        public async Task<List<Forearm>> GetAllAsync()
        {
            return await dbContext.Forearms.Include("Material").ToListAsync();
        }

        public async Task<Forearm?> GetByIdAsync(Guid id)
        {
            return await dbContext.Forearms.Include("Material").FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Forearm?> UpdateAsync(Guid id, Forearm forearm)
        {
            var existingForearm = await dbContext.Forearms.FirstOrDefaultAsync(x => x.Id == id);

            if (existingForearm == null)
            {
                return null;
            }

            existingForearm.Material = forearm.Material;
            existingForearm.Design = forearm.Design;

            await dbContext.SaveChangesAsync();
            await dbContext.Entry(existingForearm).Reference(x => x.Material).LoadAsync();
            return existingForearm;
        }
    }
}
