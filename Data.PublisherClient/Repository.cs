using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace HitchhikerGuide.Data.PublisherClient
{
    public class Repository : IRepository
    {
        private readonly ILoggerFactory _loggerFactory;
        private readonly HttpPublisherServer _publisher = new HttpPublisherServer();

        public Repository(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }        

        public IEnumerable<IPlanet> LoadPlanets()
        {
            var logger = _loggerFactory.CreateLogger<Repository>();
            var requestId = Guid.NewGuid();
            using (logger.BeginScope("{RequestId}", requestId))
            {
                logger.LogInformation("Requesting planet list from server");

                return _publisher.GetPlanets(requestId)
                    .Select(p => new PlanetPayload(p));
            }
        }

        public void Save(IPlanet planet)
        {
            var logger = _loggerFactory.CreateLogger<Repository>();
            var requestId = Guid.NewGuid();
            using (logger.BeginScope("{RequestId}", requestId))
            using (logger.BeginScope("{PlanetId}", planet.ID))
            {
                logger.LogInformation("Posting update to {PlanetName}", planet.Name);
                _publisher.UpdatePlanet(requestId, "Tim", planet.ToPublisherPlanet());
            }
        }

        public void Delete(IPlanet planet)
        {
            var logger = _loggerFactory.CreateLogger<Repository>();
            var requestId = Guid.NewGuid();
            using (logger.BeginScope("{RequestId}", requestId))
            using (logger.BeginScope("{PlanetId}", planet.ID))
            {
                logger.LogInformation("Sending request to delete {PlanetName}", planet.Name);
                _publisher.DeletePlanet(requestId, planet.ToPublisherPlanet());
            }
        }

    }
}
