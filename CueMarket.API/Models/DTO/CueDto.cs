using CueMarket.API.Models.Domain;

namespace CueMarket.API.Models.DTO
{
    public class CueDto
    {
        public Guid Id { get; set; }
        public string Maker { get; set; }
        public string JointType { get; set; }

        public ButtDto Butt { get; set; }
    }
}
