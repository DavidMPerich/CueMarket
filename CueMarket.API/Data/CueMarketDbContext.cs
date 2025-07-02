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
                // Shaft Materials
                new Material { Id = Guid.Parse("25199d2e-f4d8-4a4a-9903-119062f13802"), Type = "Shaft", Name = "Maple" },
                new Material { Id = Guid.Parse("3403b28a-0872-4d9b-811a-bb2aabaaa134"), Type = "Shaft", Name = "Ash" },
                new Material { Id = Guid.Parse("8e7f04d4-ae1e-4525-8772-f002021f3076"), Type = "Shaft", Name = "Carbon Fiber" },
                new Material { Id = Guid.Parse("a295444f-98b0-46a3-9909-3c4bb9decc54"), Type = "Shaft", Name = "Fiberglass" },

                // Ring Materials
                new Material { Id = Guid.Parse("b01e022a-19b5-45bd-91b9-0aa16b0fe5cd"), Type = "Ring", Name = "Ivory" },
                new Material { Id = Guid.Parse("25fbe48b-c7ac-40d1-a321-c104d28dd801"), Type = "Ring", Name = "Phenolic Resin" },
                new Material { Id = Guid.Parse("a57c62b2-d8de-487e-9fb3-4d9ab475f3ba"), Type = "Ring", Name = "Silver" },
                new Material { Id = Guid.Parse("f1b2ac72-454e-41d1-98ce-c1ce68ccf3b4"), Type = "Ring", Name = "Nickel" },
                new Material { Id = Guid.Parse("8ef1b81a-f23c-48be-b3f9-2dc109ccaa9d"), Type = "Ring", Name = "Micarta" },
                new Material { Id = Guid.Parse("7b74a27e-2ecd-4de7-8f80-067a1e554668"), Type = "Ring", Name = "Wood Veneer" },
                new Material { Id = Guid.Parse("d3522b74-6896-43a1-9775-0124c5f5c115"), Type = "Ring", Name = "Brass" },

                // Ferrule Materials
                new Material { Id = Guid.Parse("d662a7bf-adaf-41c8-9ded-3347dac55bc4"), Type = "Ferrule", Name = "Ivory" },
                new Material { Id = Guid.Parse("4ce5bead-a405-4e85-912e-220d2b3b86b1"), Type = "Ferrule", Name = "Juma" },
                new Material { Id = Guid.Parse("95b70cc1-18de-4b93-94b2-d1a9f878a2a3"), Type = "Ferrule", Name = "Aegis" },
                new Material { Id = Guid.Parse("c92a68b7-0578-497b-8675-281983e9de79"), Type = "Ferrule", Name = "Linen Melamine" },
                new Material { Id = Guid.Parse("64b64d9e-74df-4e28-8cb3-8b7dc1bb5759"), Type = "Ferrule", Name = "Ivorine" },
                new Material { Id = Guid.Parse("813b53bb-f442-4282-9d4d-030733c91929"), Type = "Ferrule", Name = "Phenolic Resin" },
                new Material { Id = Guid.Parse("318c3630-59ea-4ab0-bc11-7682158e8187"), Type = "Ferrule", Name = "Fiber" },

                // Tip Materials
                new Material { Id = Guid.Parse("f86e0b8c-eafa-465c-a2fc-8c4fd73a8cfd"), Type = "Tip", Name = "Leather (Soft)" },
                new Material { Id = Guid.Parse("9f4d1f5b-aec7-4268-b9fd-a6e38dec3893"), Type = "Tip", Name = "Leather (Medium)" },
                new Material { Id = Guid.Parse("04215709-e8e9-4f52-adaf-8d71c4ed80bd"), Type = "Tip", Name = "Leather (Hard)" },
                new Material { Id = Guid.Parse("1aacb15a-b175-4bc9-8906-6c9bd924d501"), Type = "Tip", Name = "Phenolic" },
                new Material { Id = Guid.Parse("90f33c74-1d57-4fac-b510-cab28655893f"), Type = "Tip", Name = "Layered Leather" },
                new Material { Id = Guid.Parse("470b32e0-dd66-4e81-b00f-da49141186cc"), Type = "Tip", Name = "Boar Hide" },

                // Forearm Materials
                new Material { Id = Guid.Parse("da3eaf67-5282-41aa-9f16-b33637648f46"), Type = "Forearm", Name = "Cocobolo" },
                new Material { Id = Guid.Parse("fc409b0a-7b22-47a2-8068-4ae3c2c06ae0"), Type = "Forearm", Name = "Ebony" },
                new Material { Id = Guid.Parse("e1e8987d-9ae5-45d4-8051-e11213494f59"), Type = "Forearm", Name = "Maple" },
                new Material { Id = Guid.Parse("c77082af-4d1c-4aa7-887b-ee013676963a"), Type = "Forearm", Name = "Rosewood" },
                new Material { Id = Guid.Parse("145f9e1b-7f2f-40b9-9a2f-b5a922b8b0b7"), Type = "Forearm", Name = "Zebrawood" },
                new Material { Id = Guid.Parse("0856a0fe-8c7c-4647-8604-02648c476ffe"), Type = "Forearm", Name = "Bocote" },
                new Material { Id = Guid.Parse("e18e0c18-0e88-4f46-b375-f1afcd6f7052"), Type = "Forearm", Name = "Birdseye Maple" },
                new Material { Id = Guid.Parse("51e48532-da6c-4800-aaec-54c9f47157ee"), Type = "Forearm", Name = "Curly Maple" },
                new Material { Id = Guid.Parse("a6d87bc6-8ef2-4bd2-99e3-9b0b80d48224"), Type = "Forearm", Name = "Purpleheart" },
                new Material { Id = Guid.Parse("51969122-92e7-4330-8f44-0758259f4e57"), Type = "Forearm", Name = "Snakewood" },

                // Wrap Materials
                new Material { Id = Guid.Parse("ac7b4058-3cc6-461e-aec6-93d10d7a32f0"), Type = "Wrap", Name = "Irish Linen" },
                new Material { Id = Guid.Parse("0b0ece71-056b-4b73-9a36-aaf71229679c"), Type = "Wrap", Name = "Leather" },
                new Material { Id = Guid.Parse("77313c18-88ff-4a29-ba07-26d93d38179b"), Type = "Wrap", Name = "Lizard Skin" },
                new Material { Id = Guid.Parse("eb056bbc-ff3f-479c-8595-eae1233a59e4"), Type = "Wrap", Name = "Rubber" },
                new Material { Id = Guid.Parse("11cfbe35-cf6d-4d10-b14c-759c58b325db"), Type = "Wrap", Name = "No Wrap (Sanded Wood)" },
                new Material { Id = Guid.Parse("dff167ba-ae2b-450f-adc9-860581185607"), Type = "Wrap", Name = "Silicone Grip" },

                // Collar Materials
                new Material { Id = Guid.Parse("894c52fb-f5a0-41f8-8443-984a71ca1c0a"), Type = "Collar", Name = "Phenolic Resin" },
                new Material { Id = Guid.Parse("74af0241-a897-4b36-977d-47c7a98fd64f"), Type = "Collar", Name = "Ivory" },
                new Material { Id = Guid.Parse("d1e339a1-246f-4099-93b1-4b9d7abb1c6c"), Type = "Collar", Name = "Micarta" },
                new Material { Id = Guid.Parse("61896bf6-3504-4901-9586-e22ad63efcd6"), Type = "Collar", Name = "Aegis" },
                new Material { Id = Guid.Parse("0df02a5b-25fc-4853-85e9-bc5ee1dffff6"), Type = "Collar", Name = "Juma" },
                new Material { Id = Guid.Parse("60369fa0-2a8f-4f1d-aeea-96ced38a9053"), Type = "Collar", Name = "G10" },
                new Material { Id = Guid.Parse("9e7cfed7-3e01-470a-9869-e0a7f2ec5e62"), Type = "Collar", Name = "ABS Plastic" },
                new Material { Id = Guid.Parse("d367b855-4137-4e82-ae40-57efe4b4e21e"), Type = "Collar", Name = "Ebony" },
                new Material { Id = Guid.Parse("12be0d93-1034-489c-9a68-79e7911c9d99"), Type = "Collar", Name = "Cocobolo" },
                new Material { Id = Guid.Parse("810ee629-2325-4778-9781-b9c25f73a41d"), Type = "Collar", Name = "Stainless Steel" },
                new Material { Id = Guid.Parse("b958c135-27eb-4b86-8115-cb06eebf0f55"), Type = "Collar", Name = "Brass" }
            };

            modelBuilder.Entity<Material>().HasData(materials);


        }
    }
}
