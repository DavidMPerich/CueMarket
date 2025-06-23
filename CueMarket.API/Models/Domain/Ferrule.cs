namespace CueMarket.API.Models.Domain
{
    public class Ferrule
    {
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public Guid MaterialId { get; set; }
        public bool Capped { get; set; }
        public string Size { get; set; }

        //Navigation Properties
        public Material Material { get; set; }
    }
}
