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
        public DbSet<Ferrule> Ferrules { get; set; }
        public DbSet<Butt> Butts { get; set; }
        public DbSet<Ring> Rings { get; set; }
        public DbSet<Forearm> Forearms { get; set; }
        public DbSet<Wrap> Wraps { get; set; }
        public DbSet<ButtSleeve> ButtSleeves { get; set; }
        public DbSet<Bumper> Bumpers { get; set; }
        public DbSet<WeightBolt> WeightBolts { get; set; }
    }
}
