namespace CueMarket.API.Models.Domain
{
    public class Collar
    {
        public Guid Id { get; set; }
        public Guid MaterialId { get; set; }

        //Navigation Properties
        public Material Material { get; set; }
    }
}
