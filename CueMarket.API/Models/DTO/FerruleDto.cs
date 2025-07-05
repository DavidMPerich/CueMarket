using CueMarket.API.Models.Domain;

namespace CueMarket.API.Models.DTO
{
    public class FerruleDto
    {
        public Guid Id { get; set; }
        public string? Brand { get; set; }
        public bool? Capped { get; set; }
        public string? Size { get; set; }

        //Navigation Properties
        public MaterialDto? Material { get; set; }
    }
}
