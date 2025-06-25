namespace CueMarket.API.Models.Domain
{
    public class Wrap
    {
        public Guid Id { get; set; }
        public Guid MaterialId { get; set; }
        public string Color { get; set; }

        //Navigation Properties
        public Material Material { get; set; }
    }
}
