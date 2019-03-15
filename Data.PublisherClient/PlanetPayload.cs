using System;
using HitchhikerGuide.Data.PublisherClient.Services;

namespace HitchhikerGuide.Data.PublisherClient
{
    internal class PlanetPayload : IPlanet
    {
        public PlanetPayload(Planet planet)
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

    internal static class PlanetExtensions
    {

        public static Planet ToPublisherPlanet(this IPlanet planet) =>
            new Planet
            {
                ID = planet.ID,
                Name = planet.Name,
                HasAtmosphere = planet.HasAtmosphere,
                SkyColour = planet.SkyColour,
                Notes = planet.Notes
            };
    }

    

}
