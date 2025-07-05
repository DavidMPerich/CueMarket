namespace CueMarket.API.Models.DTO
{
    public class UpdateFerruleRequestDto
    {
        public string? Brand { get; set; }
        public Guid? MaterialId { get; set; }
        public bool? Capped { get; set; }
        public string? Size { get; set; }
    }
}
