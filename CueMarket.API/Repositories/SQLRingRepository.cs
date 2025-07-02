using CueMarket.API.Data;
using CueMarket.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CueMarket.API.Repositories
{
    public class SQLRingRepository : IRingRepository
    {
        private readonly CueMarketDbContext dbContext;

        public SQLRingRepository(CueMarketDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Ring> CreateAsync(Ring ring)
        {
            await dbContext.Rings.AddAsync(ring);
            await dbContext.SaveChangesAsync();
            await dbContext.Entry(ring).Reference(x => x.Material).LoadAsync();
            return ring;
        }

        public async Task<Ring?> DeleteAsync(Guid id)
        {
            var existingRing = await dbContext.Rings.FirstOrDefaultAsync(x => x.Id == id);

            if (existingRing == null)
            {
                return null;
            }

            dbContext.Rings.Remove(existingRing);
            await dbContext.SaveChangesAsync();
            await dbContext.Entry(existingRing).Reference(x => x.Material).LoadAsync();

            return existingRing;
        }

        public async Task<List<Ring>> GetAllAsync()
        {
            return await dbContext.Rings.Include("Material").ToListAsync();
        }

        public async Task<Ring?> GetByIdAsync(Guid id)
        {
            return await dbContext.Rings.Include("Material").FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Ring?> UpdateAsync(Guid id, Ring ring)
        {
            var existingRing = await dbContext.Rings.FirstOrDefaultAsync(x => x.Id == id);

            if (existingRing == null)
            {
                return null;
            }

            existingRing.Color = ring.Color;
            existingRing.Style = ring.Style;
            existingRing.Material = ring.Material;

            await dbContext.SaveChangesAsync();
            await dbContext.Entry(existingRing).Reference(x => x.Material).LoadAsync();

            return existingRing;
        }
    }
}
