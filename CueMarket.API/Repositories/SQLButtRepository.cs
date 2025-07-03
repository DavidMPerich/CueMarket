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
            if (butt.RingB != null)
            {
                await dbContext.Entry(butt.RingB).Reference(x => x.Material).LoadAsync();
            }
            await dbContext.Entry(butt).Reference(x => x.Forearm).LoadAsync();
            if (butt.Forearm != null)
            {
                await dbContext.Entry(butt.Forearm).Reference(x => x.Material).LoadAsync();
            }
            await dbContext.Entry(butt).Reference(x => x.RingC).LoadAsync();
            if (butt.RingC != null)
            {
                await dbContext.Entry(butt.RingC).Reference(x => x.Material).LoadAsync();
            }
            await dbContext.Entry(butt).Reference(x => x.Wrap).LoadAsync();
            if (butt.Wrap != null)
            {
                await dbContext.Entry(butt.Wrap).Reference(x => x.Material).LoadAsync();
            }
            await dbContext.Entry(butt).Reference(x => x.RingD).LoadAsync();
            if (butt.RingD != null)
            {
                await dbContext.Entry(butt.RingD).Reference(x => x.Material).LoadAsync();
            }
            await dbContext.Entry(butt).Reference(x => x.ButtSleeve).LoadAsync();
            await dbContext.Entry(butt).Reference(x => x.RingE).LoadAsync();
            if (butt.RingE != null)
            {
                await dbContext.Entry(butt.RingE).Reference(x => x.Material).LoadAsync();
            }
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
            if (existingButt.RingB != null)
            {
                await dbContext.Entry(existingButt.RingB).Reference(x => x.Material).LoadAsync();
            }
            await dbContext.Entry(existingButt).Reference(x => x.Forearm).LoadAsync();
            if (existingButt.Forearm != null)
            {
                await dbContext.Entry(existingButt.Forearm).Reference(x => x.Material).LoadAsync();
            }
            await dbContext.Entry(existingButt).Reference(x => x.RingC).LoadAsync();
            if (existingButt.RingC != null)
            {
                await dbContext.Entry(existingButt.RingC).Reference(x => x.Material).LoadAsync();
            }
            await dbContext.Entry(existingButt).Reference(x => x.Wrap).LoadAsync();
            if (existingButt.Wrap != null)
            {
                await dbContext.Entry(existingButt.Wrap).Reference(x => x.Material).LoadAsync();
            }
            await dbContext.Entry(existingButt).Reference(x => x.RingD).LoadAsync();
            if (existingButt.RingD != null)
            {
                await dbContext.Entry(existingButt.RingD).Reference(x => x.Material).LoadAsync();
            }
            await dbContext.Entry(existingButt).Reference(x => x.ButtSleeve).LoadAsync();
            await dbContext.Entry(existingButt).Reference(x => x.RingE).LoadAsync();
            if (existingButt.RingE != null)
            {
                await dbContext.Entry(existingButt.RingE).Reference(x => x.Material).LoadAsync();
            }
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
                .Include("RingB.Material")
                .Include("Forearm")
                .Include("Forearm.Material")
                .Include("RingC")
                .Include("RingC.Material")
                .Include("Wrap")
                .Include("Wrap.Material")
                .Include("RingD")
                .Include("RingD.Material")
                .Include("ButtSleeve")
                .Include("RingE")
                .Include("RingE.Material")
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
                .Include("RingB.Material")
                .Include("Forearm")
                .Include("Forearm.Material")
                .Include("RingC")
                .Include("RingC.Material")
                .Include("Wrap")
                .Include("Wrap.Material")
                .Include("RingD")
                .Include("RingD.Material")
                .Include("ButtSleeve")
                .Include("RingE")
                .Include("RingE.Material")
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
            if (existingButt.RingB != null)
            {
                await dbContext.Entry(existingButt.RingB).Reference(x => x.Material).LoadAsync();
            }
            await dbContext.Entry(existingButt).Reference(x => x.Forearm).LoadAsync();
            if (existingButt.Forearm != null)
            {
                await dbContext.Entry(existingButt.Forearm).Reference(x => x.Material).LoadAsync();
            }
            await dbContext.Entry(existingButt).Reference(x => x.RingC).LoadAsync();
            if (existingButt.RingC != null)
            {
                await dbContext.Entry(existingButt.RingC).Reference(x => x.Material).LoadAsync();
            }
            await dbContext.Entry(existingButt).Reference(x => x.Wrap).LoadAsync();
            if (existingButt.Wrap != null)
            {
                await dbContext.Entry(existingButt.Wrap).Reference(x => x.Material).LoadAsync();
            }
            await dbContext.Entry(existingButt).Reference(x => x.RingD).LoadAsync();
            if (existingButt.RingD != null)
            {
                await dbContext.Entry(existingButt.RingD).Reference(x => x.Material).LoadAsync();
            }
            await dbContext.Entry(existingButt).Reference(x => x.ButtSleeve).LoadAsync();
            await dbContext.Entry(existingButt).Reference(x => x.RingE).LoadAsync();
            if (existingButt.RingE != null)
            {
                await dbContext.Entry(existingButt.RingE).Reference(x => x.Material).LoadAsync();
            }
            await dbContext.Entry(existingButt).Reference(x => x.ButtCapMaterial).LoadAsync();
            await dbContext.Entry(existingButt).Reference(x => x.Bumper).LoadAsync();
            await dbContext.Entry(existingButt).Reference(x => x.WeightBolt).LoadAsync();
            return existingButt;
        }
    }
}
