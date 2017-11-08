using System;

namespace HitchhikerGuide
{
    public class SelectedPlanetChangedEventArgs : EventArgs
    {
        public SelectedPlanetChangedEventArgs(Planet planet)
        {
            Planet = planet;
        }

        public Planet Planet { get; }
    }
}