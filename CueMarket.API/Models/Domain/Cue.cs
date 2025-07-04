namespace CueMarket.API.Models.Domain
{
    public class Cue
    {
        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public string? Maker { get; set; }
        public Guid? ButtId { get; set; }
        public ICollection<Shaft>? Shafts { get; set; } = new List<Shaft>();
        public string? JointType { get; set; }

        //Navigation Properties
        public User? User { get; set; }
        public Butt? Butt { get; set; }
    }
}
