using CueMarket.API.Data;
using CueMarket.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CueMarket.API.Repositories
{
    public class SQLTipRepository : ITipRepository
    {
        private readonly CueMarketDbContext dbContext;

        public SQLTipRepository(CueMarketDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Tip> CreateAsync(Tip tip)
        {
            await dbContext.Tips.AddAsync(tip);
            await dbContext.SaveChangesAsync();
            await dbContext.Entry(tip).Reference(x => x.Material).LoadAsync();
            return tip;
        }

        public async Task<Tip?> DeleteAsync(Guid id)
        {
            var existingTip = await dbContext.Tips.FirstOrDefaultAsync(x => x.Id == id);

            if (existingTip == null)
            {
                return null;
            }

            dbContext.Tips.Remove(existingTip);
            await dbContext.SaveChangesAsync();
            await dbContext.Entry(existingTip).Reference(x => x.Material).LoadAsync();
            return existingTip;
        }

        public async Task<List<Tip>> GetAllAsync()
        {
            return await dbContext.Tips.Include("Material").ToListAsync();
        }

        public async Task<Tip?> GetByIdAsync(Guid id)
        {
            return await dbContext.Tips.Include("Material").FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Tip?> UpdateAsync(Guid id, Tip tip)
        {
            var existingTip = await dbContext.Tips.FirstOrDefaultAsync(x => x.Id == id);

            if (existingTip == null)
            {
                return null;
            }

            existingTip.Brand = tip.Brand;
            existingTip.MaterialId = tip.MaterialId;
            existingTip.Hardness = tip.Hardness;
            existingTip.Size = tip.Size;

            await dbContext.SaveChangesAsync();
            await dbContext.Entry(existingTip).Reference(x => x.Material).LoadAsync();
            return existingTip;
        }
    }
}
