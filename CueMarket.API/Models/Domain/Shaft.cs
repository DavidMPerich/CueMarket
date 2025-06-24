namespace CueMarket.API.Models.Domain
{
    public class Shaft
    {
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public Guid MaterialId { get; set; }
        public Guid TipId { get; set; }
        public Guid FerruleId { get; set; }
        public Guid CollarId { get; set; }

        // Navigation Properties
        public Material Material { get; set; }
        public Tip Tip { get; set; }
        public Ferrule Ferrule { get; set; }
        public Collar Collar { get; set; }
    }
}
