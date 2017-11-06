using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HitchhikerGuide
{
    [Serializable]
    public class Planet
    {
        public string Name { get; set; }
        public bool HasAtmosphere { get; set; }
        public string SkyColour { get; set; }
        public string Notes { get; set; }

        public override string ToString() => Name;
    }
}
