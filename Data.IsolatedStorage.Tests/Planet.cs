using System;

namespace HitchhikerGuide.Data.IsolatedStorage.Tests
{
    public class Planet : IPlanet
    {
        public Guid ID { get; set; } = Guid.NewGuid();

        public string Name { get; set; }
        public bool HasAtmosphere { get; set; }
        public string SkyColour { get; set; }
        public string Notes { get; set; }
    }
}