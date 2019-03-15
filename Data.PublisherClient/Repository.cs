using System;
using System.Collections.Generic;
using System.Linq;

namespace HitchhikerGuide.Data.PublisherClient
{
    public class Repository : IRepository
    {
        private readonly HttpPublisherServer _publisher = new HttpPublisherServer();

        public IEnumerable<IPlanet> LoadPlanets()
        {
            return _publisher.GetPlanets(Guid.NewGuid())
                .Select(p => new PlanetPayload(p));
        }

        public void Save(IPlanet planet)
        {
            _publisher.UpdatePlanet(Guid.NewGuid(), "Tim", planet.ToPublisherPlanet());
        }

        public void Delete(IPlanet planet)
        {
            _publisher.DeletePlanet(Guid.NewGuid(), planet.ToPublisherPlanet());
        }
    }
}
