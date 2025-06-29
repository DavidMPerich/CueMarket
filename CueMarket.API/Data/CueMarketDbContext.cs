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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Data
            var materials = new List<Material>
            {
                new Material { Id = Guid.Parse("557f813b-8356-4b2f-94e0-c2e2a9e836fb"), Type = "Wood", Name = "Maple" },
                new Material { Id = Guid.Parse("3ba8cfa2-f0cd-4e7a-97e7-9223b0477802"), Type = "Wood", Name = "Ash" },
                new Material { Id = Guid.Parse("50606191-d2ca-44a7-83f4-4565bd2aa499"), Type = "Wood", Name = "Bamboo" },
                new Material { Id = Guid.Parse("8a8aa096-bbf2-4fc9-a1e1-f412fbe1debc"), Type = "Synthetic", Name = "Phenolic" },
                new Material { Id = Guid.Parse("9f055de2-bb46-434e-801f-b8bc1e59005b"), Type = "Metal", Name = "Stainless Steel" }
            };

            modelBuilder.Entity<Material>().HasData(materials);


        }
    }
}
