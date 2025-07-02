using CueMarket.API.Models.Domain;

namespace CueMarket.API.Models.DTO
{
    public class RingDto
    {
        public Guid Id { get; set; }
        public string? Color { get; set; }
        public string? Style { get; set; }

        public MaterialDto? Material { get; set; }
    }
}
