using CueMarket.API.Data;
using CueMarket.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CueMarket.API.Repositories
{
    public class SQLButtSleeveRepository : IButtSleeveRepository
    {
        private readonly CueMarketDbContext dbContext;

        public SQLButtSleeveRepository(CueMarketDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<ButtSleeve> CreateAsync(ButtSleeve buttSleeve)
        {
            await dbContext.ButtSleeves.AddAsync(buttSleeve);
            await dbContext.SaveChangesAsync();
            return buttSleeve;
        }

        public async Task<ButtSleeve?> DeleteAsync(Guid id)
        {
            var existingButtSleeve = await dbContext.ButtSleeves.FirstOrDefaultAsync(x => x.Id == id);

            if (existingButtSleeve == null)
            {
                return null;
            }

            dbContext.ButtSleeves.Remove(existingButtSleeve);
            await dbContext.SaveChangesAsync();

            return existingButtSleeve;
        }

        public async Task<List<ButtSleeve>> GetAllAsync()
        {
            return await dbContext.ButtSleeves.ToListAsync();
        }

        public async Task<ButtSleeve?> GetByIdAsync(Guid id)
        {
            return await dbContext.ButtSleeves.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ButtSleeve?> UpdateAsync(Guid id, ButtSleeve buttSleeve)
        {
            var existingButtSleeve = await dbContext.ButtSleeves.FirstOrDefaultAsync(x => x.Id == id);

            if (existingButtSleeve == null)
            {
                return null;
            }

            existingButtSleeve.Design = buttSleeve.Design;

            await dbContext.SaveChangesAsync();
            return existingButtSleeve;
        }
    }
}
