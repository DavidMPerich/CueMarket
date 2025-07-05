namespace CueMarket.API.Models.DTO
{
    public class UpdateTipRequestDto
    {
        public string? Brand { get; set; }
        public Guid? MaterialId { get; set; }
        public string? Hardness { get; set; }
        public string? Size { get; set; }
    }
}
