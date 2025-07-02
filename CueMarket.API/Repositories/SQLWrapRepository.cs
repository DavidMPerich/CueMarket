using CueMarket.API.Data;
using CueMarket.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CueMarket.API.Repositories
{
    public class SQLWrapRepository : IWrapRepository
    {
        private readonly CueMarketDbContext dbContext;

        public SQLWrapRepository(CueMarketDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Wrap> CreateAsync(Wrap wrap)
        {
            await dbContext.Wraps.AddAsync(wrap);
            await dbContext.SaveChangesAsync();
            await dbContext.Entry(wrap).Reference(x => x.Material).LoadAsync();
            return wrap;
        }

        public async Task<Wrap?> DeleteAsync(Guid id)
        {
            var existingWrap = await dbContext.Wraps.FirstOrDefaultAsync(x => x.Id == id);

            if (existingWrap == null)
            {
                return null;
            }

            dbContext.Wraps.Remove(existingWrap);
            await dbContext.SaveChangesAsync();
            await dbContext.Entry(existingWrap).Reference(x => x.Material).LoadAsync();

            return existingWrap;
        }

        public async Task<List<Wrap>> GetAllAsync()
        {
            return await dbContext.Wraps.Include("Material").ToListAsync();
        }

        public async Task<Wrap?> GetByIdAsync(Guid id)
        {
            return await dbContext.Wraps.Include("Material").FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Wrap?> UpdateAsync(Guid id, Wrap wrap)
        {
            var existingWrap = await dbContext.Wraps.FirstOrDefaultAsync(x => x.Id == id);

            if (existingWrap == null)
            {
                return null;
            }

            existingWrap.Material = wrap.Material;
            existingWrap.Color = wrap.Color;

            await dbContext.SaveChangesAsync();
            await dbContext.Entry(existingWrap).Reference(x => x.Material).LoadAsync();
            return existingWrap;
        }
    }
}
