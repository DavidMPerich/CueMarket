using CueMarket.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CueMarket.API.Data
{
    public class CueMarketDbContext : DbContext
    {
        public CueMarketDbContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
            
        }

        public DbSet<Cue> Cues { get; set; }
        public DbSet<Shaft> Shafts { get; set; }
        public DbSet<Tip> Tips { get; set; }
        public DbSet<Material> Materials { get; set; }
    }
}
