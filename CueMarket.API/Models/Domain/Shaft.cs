﻿namespace CueMarket.API.Models.Domain
{
    public class Shaft
    {
        public Guid Id { get; set; }
        public string? Maker { get; set; }
        public Guid? MaterialId { get; set; }
        public Guid? TipId { get; set; }
        public Guid? FerruleId { get; set; }
        public Guid? CollarMaterialId { get; set; }
        public Guid? RingAId { get; set; }
        public Guid? CueId { get; set; }

        // Navigation Properties
        public Material? Material { get; set; }
        public Tip? Tip { get; set; }
        public Ferrule? Ferrule { get; set; }
        public Material? CollarMaterial { get; set; }
        public Ring? RingA { get; set; }
        public Cue? Cue { get; set; }
    }
}
