namespace CueMarket.API.Models.DTO
{
    public class AddShaftRequestDto
    {
        public string? Maker { get; set; }
        public Guid? MaterialId { get; set; }
        public Guid? TipId { get; set; }
        public Guid? FerruleId { get; set; }
        public Guid? CollarMaterialId { get; set; }
        public Guid? RingAId { get; set; }
        public Guid? CueId { get; set; }
    }
}
