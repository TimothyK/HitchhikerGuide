
using System.Collections.Generic;
using HitchhikerGuide.Data;

namespace HitchhikerGuide.Lib.Tests
{
    public class TestRepository : IRepository
    {
        public readonly List<IPlanet> Planets = new List<IPlanet>();

        public IEnumerable<IPlanet> LoadPlanets()
        {
            return Planets;
        }

        public readonly List<IPlanet> SavedPlanets = new List<IPlanet>();

        public void Save(IPlanet planet)
        {
            SavedPlanets.Add(planet);
        }

        public readonly List<IPlanet> DeletedPlanets = new List<IPlanet>();

        public void Delete(IPlanet planet)
        {
            DeletedPlanets.Add(planet);
        }
    }
}