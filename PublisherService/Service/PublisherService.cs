using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace PublisherService.Service
{
    [ServiceBehavior(Namespace = "https://services.github.com/TimothyK/HitchhikerGuide/Publisher")]

    public class PublisherService : IPublisher
    {
        private readonly List<Planet> _planets = new List<Planet>();

        public void UpdatePlanet(Guid requestId, string author, Planet planet)
        {
            var oldPlanet = _planets.FirstOrDefault(p => p.ID == planet.ID);

            var rate = oldPlanet == null ? 10 : 5;
            PayTheAuthor(author, rate, planet);

            if (oldPlanet != null)
                _planets.Remove(oldPlanet);
            _planets.Add(planet);
        }

        private static void PayTheAuthor(string author, int rate, Planet planet)
        {
            Console.WriteLine($"Paid {author} ${rate} for update to {planet.Name}");
        }

        public IEnumerable<Planet> GetPlanets(Guid requestId) => _planets;

        public void DeletePlanet(Guid requestId, Planet planet)
        {
            var oldPlanet = _planets.FirstOrDefault(p => p.ID == planet.ID);

            if (oldPlanet != null)
                _planets.Remove(oldPlanet);
        }
    }
}
