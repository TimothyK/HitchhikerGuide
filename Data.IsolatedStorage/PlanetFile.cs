using System;

namespace HitchhikerGuide.Data.IsolatedStorage
{
    [Serializable]
    public class PlanetFile : IPlanet
    {
        private PlanetFile()
        {
        }

        public PlanetFile(IPlanet planet)
        {
            ID = planet.ID;
            Name = planet.Name;
            HasAtmosphere = planet.HasAtmosphere;
            SkyColour = planet.SkyColour;
            Notes = planet.Notes;
        }

        public Guid ID { get; set; }
        public string Name { get; set; }
        public bool HasAtmosphere { get; set; }
        public string SkyColour { get; set; }
        public string Notes { get; set; }
    }
}