namespace CueMarket.API.Models.Domain
{
    public class Cue
    {
        public Guid Id { get; set; }
        public string Maker { get; set; }
        public Guid ButtId { get; set; }
        public Guid ShaftId { get; set; }
        public string JointType { get; set; }

        //Navigation Properties
        public Butt Butt { get; set; }
        public Shaft Shaft { get; set; }
    }
}
