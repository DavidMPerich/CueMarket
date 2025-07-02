namespace CueMarket.API.Models.Domain
{
    public class Ring
    {
        public Guid Id { get; set; }
        public string? Color { get; set; }
        public string? Style { get; set; }
        public Guid? MaterialId { get; set; }

        // Navigation Properties
        public Material? Material { get; set; }
    }
}
