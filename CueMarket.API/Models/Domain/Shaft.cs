namespace CueMarket.API.Models.Domain
{
    public class Shaft
    {
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public Guid TipId { get; set; }
        public Guid MaterialId { get; set; }

        // Navigation Properties
        public Tip Tip { get; set; }
        public Material Material { get; set; }
    }
}
