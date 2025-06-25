namespace CueMarket.API.Models.Domain
{
    public class Butt
    {
        public Guid Id { get; set; }
        public Guid CollarMaterialId { get; set; }
        public Guid RingBId { get; set; }
        public Guid ForearmId { get; set; }
        public Guid RingCId { get; set; }

        //Navigation Properties
        public Material CollarMaterial { get; set; }
        public Ring RingB { get; set; }
        public Forearm Forearm { get; set; }
        public Ring RingC { get; set; }
    }
}
