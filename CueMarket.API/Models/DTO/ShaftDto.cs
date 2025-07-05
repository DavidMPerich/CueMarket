using CueMarket.API.Models.Domain;

namespace CueMarket.API.Models.DTO
{
    public class ShaftDto
    {
        public Guid Id { get; set; }
        public string? Maker { get; set; }

        public MaterialDto? Material { get; set; }
        public TipDto? Tip { get; set; }
        public FerruleDto? Ferrule { get; set; }
        public MaterialDto? CollarMaterial { get; set; }
        public RingDto? RingA { get; set; }
        public CueDto? Cue { get; set; }
    }
}
