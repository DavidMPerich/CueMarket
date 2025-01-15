using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;

namespace CueMarketAPI.Models.Domain
{
    public class Shaft
    {
        public Guid Id { get; set; }
        public Guid Material {  get; set; }
        public Guid TipId { get; set; }
        public Guid FerruleId { get; set; }
        public Guid RingPosAId { get; set; }
        public Guid CollarId { get; set; }

        //Navigation Properties
        public Material Material { get; set; }
        public Tip Tip { get; set; }
        public Ferrule Ferrule { get; set; }
        public Ring RingPosA { get; set; }
        public Collar Collar { get; set; }
    }
}
