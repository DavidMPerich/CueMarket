namespace CueMarket.API.Models.DTO
{
    public class AddCueRequestDto
    {
        public string Maker { get; set; }
        public Guid? ButtId { get; set; }
        public string JointType { get; set; }
    }
}
