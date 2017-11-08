using System;

namespace HitchhikerGuide.Data
{
    public interface IPlanet
    {
        Guid ID { get; set; }
        string Name { get; set; }
        bool HasAtmosphere { get; set; }
        string SkyColour { get; set; }
        string Notes { get; set; }

    }
}