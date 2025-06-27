using CueMarket.API.Models.Domain;

namespace CueMarket.API.Models.DTO
{
    public class CueDto
    {
        public Guid Id { get; set; }
        public string Maker { get; set; }
        public Guid? ButtId { get; set; }
        public string JointType { get; set; }
    }
}
