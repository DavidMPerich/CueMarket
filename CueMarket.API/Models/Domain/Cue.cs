namespace CueMarket.API.Models.Domain
{
    public class Cue
    {
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public Guid ShaftId { get; set; }

        //Navigation Properties
        public Shaft Shaft { get; set; }
    }
}
