﻿namespace CueMarketAPI.Models.Domain
{
    public class Cue
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string? Maker { get; set; }
        public Guid ButtId { get; set; }
        public Guid ShaftAId { get; set; }
        public Guid ShaftBId { get; set; }
        public Guid ShaftCId { get; set; }
        public Guid ShaftDId { get; set; }
        public Guid ShaftEId { get; set; }
        public Guid JointId { get; set; }

        //Navigation Properties
        public User User { get; set; }
        public Butt Butt { get; set; }
        public Shaft ShaftA { get; set; }
        public Shaft ShaftB { get; set; }
        public Shaft ShaftC { get; set; }
        public Shaft ShaftD { get; set; }
        public Shaft ShaftE { get; set; }
        public Joint Joint { get; set; }
    }
}
