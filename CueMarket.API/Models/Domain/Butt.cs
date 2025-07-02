namespace CueMarket.API.Models.Domain
{
    public class Butt
    {
        public Guid Id { get; set; }
        public Guid? CollarMaterialId { get; set; }
        public Guid? RingBId { get; set; }
        public Guid? ForearmId { get; set; }
        public Guid? RingCId { get; set; }
        public Guid? WrapId { get; set; }
        public Guid? RingDId { get; set; }
        public Guid? ButtSleeveId { get; set; }
        public Guid? RingEId { get; set; }
        public Guid? ButtCapMaterialId { get; set; }
        public Guid? BumperId { get; set; }
        public Guid? WeightBoltId { get; set; }

        //Navigation Properties
        public Material? CollarMaterial { get; set; }
        public Ring? RingB { get; set; }
        public Forearm? Forearm { get; set; }
        public Ring? RingC { get; set; }
        public Wrap? Wrap { get; set; }
        public Ring? RingD { get; set; }
        public ButtSleeve? ButtSleeve { get; set; }
        public Ring? RingE { get; set; }
        public Material? ButtCapMaterial { get; set; }
        public Bumper? Bumper { get; set; }
        public WeightBolt? WeightBolt { get; set; }
    }
}
