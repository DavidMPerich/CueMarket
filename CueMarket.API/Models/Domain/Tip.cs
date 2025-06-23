namespace CueMarket.API.Models.Domain
{
    public class Tip
    {
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public Guid MaterialId { get; set; }

        // Navigation Properties
        public Material Material { get; set; }
    }
}
