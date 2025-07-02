using CueMarket.API.Data;
using CueMarket.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CueMarket.API.Repositories
{
    public class SQLButtRepository : IButtRepository
    {
        private readonly CueMarketDbContext dbContext;

        public SQLButtRepository(CueMarketDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Butt> CreateAsync(Butt butt)
        {
            await dbContext.Butts.AddAsync(butt);
            await dbContext.SaveChangesAsync();
            await dbContext.Entry(butt).Reference(x => x.CollarMaterial).LoadAsync();
            await dbContext.Entry(butt).Reference(x => x.RingB).LoadAsync();
            await dbContext.Entry(butt).Reference(x => x.Forearm).LoadAsync();
            await dbContext.Entry(butt).Reference(x => x.RingC).LoadAsync();
            await dbContext.Entry(butt).Reference(x => x.Wrap).LoadAsync();
            await dbContext.Entry(butt).Reference(x => x.RingD).LoadAsync();
            await dbContext.Entry(butt).Reference(x => x.ButtSleeve).LoadAsync();
            await dbContext.Entry(butt).Reference(x => x.RingE).LoadAsync();
            await dbContext.Entry(butt).Reference(x => x.ButtCapMaterial).LoadAsync();
            await dbContext.Entry(butt).Reference(x => x.Bumper).LoadAsync();
            await dbContext.Entry(butt).Reference(x => x.WeightBolt).LoadAsync();
            return butt;
        }

        public async Task<Butt?> DeleteAsync(Guid id)
        {
            var existingButt = await dbContext.Butts.FirstOrDefaultAsync(x => x.Id == id);

            if (existingButt == null)
            {
                return null;
            }

            dbContext.Butts.Remove(existingButt);
            await dbContext.SaveChangesAsync();
            await dbContext.Entry(existingButt).Reference(x => x.CollarMaterial).LoadAsync();
            await dbContext.Entry(existingButt).Reference(x => x.RingB).LoadAsync();
            await dbContext.Entry(existingButt).Reference(x => x.Forearm).LoadAsync();
            await dbContext.Entry(existingButt).Reference(x => x.RingC).LoadAsync();
            await dbContext.Entry(existingButt).Reference(x => x.Wrap).LoadAsync();
            await dbContext.Entry(existingButt).Reference(x => x.RingD).LoadAsync();
            await dbContext.Entry(existingButt).Reference(x => x.ButtSleeve).LoadAsync();
            await dbContext.Entry(existingButt).Reference(x => x.RingE).LoadAsync();
            await dbContext.Entry(existingButt).Reference(x => x.ButtCapMaterial).LoadAsync();
            await dbContext.Entry(existingButt).Reference(x => x.Bumper).LoadAsync();
            await dbContext.Entry(existingButt).Reference(x => x.WeightBolt).LoadAsync();

            return existingButt;
        }

        public async Task<List<Butt>> GetAllAsync()
        {
            return await dbContext.Butts
                .Include("CollarMaterial")
                .Include("RingB")
                .Include("Forearm")
                .Include("RingC")
                .Include("Wrap")
                .Include("RingD")
                .Include("ButtSleeve")
                .Include("RingE")
                .Include("ButtCapMaterial")
                .Include("Bumper")
                .Include("WeightBolt")
                .ToListAsync();
        }

        public async Task<Butt?> GetByIdAsync(Guid id)
        {
            return await dbContext.Butts
                .Include("CollarMaterial")
                .Include("RingB")
                .Include("Forearm")
                .Include("RingC")
                .Include("Wrap")
                .Include("RingD")
                .Include("ButtSleeve")
                .Include("RingE")
                .Include("ButtCapMaterial")
                .Include("Bumper")
                .Include("WeightBolt")
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Butt?> UpdateAsync(Guid id, Butt butt)
        {
            var existingButt = await dbContext.Butts.FirstOrDefaultAsync(x => x.Id == id);

            if (existingButt == null)
            {
                return null;
            }

            existingButt.CollarMaterialId = butt.CollarMaterialId;
            existingButt.RingBId = butt.RingBId;
            existingButt.ForearmId = butt.ForearmId;
            existingButt.RingCId = butt.RingCId;
            existingButt.WrapId = butt.WrapId;
            existingButt.RingDId = butt.RingDId;
            existingButt.ButtSleeveId = butt.ButtSleeveId;
            existingButt.RingEId = butt.RingEId;
            existingButt.ButtCapMaterialId = butt.ButtCapMaterialId;
            existingButt.BumperId = butt.BumperId;
            existingButt.WeightBoltId = butt.WeightBoltId;

            await dbContext.SaveChangesAsync();
            await dbContext.Entry(existingButt).Reference(x => x.CollarMaterial).LoadAsync();
            await dbContext.Entry(existingButt).Reference(x => x.RingB).LoadAsync();
            await dbContext.Entry(existingButt).Reference(x => x.Forearm).LoadAsync();
            await dbContext.Entry(existingButt).Reference(x => x.RingC).LoadAsync();
            await dbContext.Entry(existingButt).Reference(x => x.Wrap).LoadAsync();
            await dbContext.Entry(existingButt).Reference(x => x.RingD).LoadAsync();
            await dbContext.Entry(existingButt).Reference(x => x.ButtSleeve).LoadAsync();
            await dbContext.Entry(existingButt).Reference(x => x.RingE).LoadAsync();
            await dbContext.Entry(existingButt).Reference(x => x.ButtCapMaterial).LoadAsync();
            await dbContext.Entry(existingButt).Reference(x => x.Bumper).LoadAsync();
            await dbContext.Entry(existingButt).Reference(x => x.WeightBolt).LoadAsync();
            return existingButt;
        }
    }
}
