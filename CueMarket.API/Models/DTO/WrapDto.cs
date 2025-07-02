using CueMarket.API.Models.Domain;

namespace CueMarket.API.Models.DTO
{
    public class WrapDto
    {
        public Guid Id { get; set; }
        public string? Color { get; set; }

        public MaterialDto? Material { get; set; }

    }
}
