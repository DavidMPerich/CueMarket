using CueMarket.API.Models.Domain;

namespace CueMarket.API.Models.DTO
{
    public class TipDto
    {
        public Guid Id { get; set; }
        public string? Brand { get; set; }
        public string? Hardness { get; set; }
        public string? Size { get; set; }

        public MaterialDto? Material { get; set; }
    }
}
