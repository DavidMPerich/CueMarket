using CueMarket.API.Models.Domain;

namespace CueMarket.API.Models.DTO
{
    public class ForearmDto
    {
        public Guid Id { get; set; }
        public string? Design { get; set; }

        public MaterialDto? Material { get; set; }
    }
}
