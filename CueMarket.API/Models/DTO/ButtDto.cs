namespace CueMarket.API.Models.DTO
{
    public class ButtDto
    {
        public Guid Id { get; set; }
        public MaterialDto? CollarMaterial { get; set; }
        public RingDto? RingB { get; set; }
        public ForearmDto? Forearm { get; set; }
        public RingDto? RingC { get; set; }
        public WrapDto? Wrap { get; set; }
        public RingDto? RingD { get; set; }
        public ButtSleeveDto? ButtSleeve { get; set; }
        public RingDto? RingE { get; set; }
        public MaterialDto? ButtCapMaterial { get; set; }
        public BumperDto? Bumper { get; set; }
        public WeightBoltDto? WeightBolt { get; set; }
    }
}
