namespace CueMarket.API.Models.DTO
{
    public class AddCueRequestDto
    {
        public Guid? UserId { get; set; }
        public string? Maker { get; set; }
        public Guid? ButtId { get; set; }
        public string? JointType { get; set; }
    }
}
