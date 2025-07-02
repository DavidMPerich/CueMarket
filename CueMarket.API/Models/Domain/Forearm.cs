namespace CueMarket.API.Models.Domain
{
    public class Forearm
    {
        public Guid Id { get; set; }
        public Guid? MaterialId { get; set; }
        public string? Design { get; set; }

        //Navigation Properties
        public Material? Material { get; set; }
    }
}
