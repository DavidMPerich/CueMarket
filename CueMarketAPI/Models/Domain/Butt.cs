using Microsoft.AspNetCore.Mvc.Formatters.Xml;

namespace CueMarketAPI.Models.Domain
{
    public class Butt
    {
        public Guid Id { get; set; }
        public Guid CollarId { get; set; }
        public Guid RingPosBId { get; set; }
        public Guid ForearmId { get; set; }
        public Guid RingPosCId { get; set; }
        public Guid WrapId { get; set; }
        public Guid RingPosDId { get; set; }
        public Guid ButtSleeveId { get; set; }
        public Guid RingPosEId { get; set; }
        public Guid ButtCapId { get; set; }
        public Guid BumperId { get; set; }
        public Guid WeightBoltId { get; set; }

        //Navigation Properties
        public Collar Collar { get; set; }
        public Ring RingPosB { get; set; }
        public Forearm Forearm { get; set; }
        public Ring RingPosC { get; set; }
        public Wrap Wrap { get; set; }
        public Ring RingPosD { get; set; }
        public ButtSleeve ButtSleeve { get; set; }
        public Ring RingPosE { get; set; }
        public ButtCap ButtCap { get; set; }
        public Bumper Bumper { get; set; }
        public WeightBolt WeightBolt { get; set; }
        

    }
}
