using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Timers;
using Serilog;
using Serilog.Context;

namespace PublisherService.Service
{
    [ServiceBehavior(Namespace = "https://services.github.com/TimothyK/HitchhikerGuide/Publisher")]

    public class PublisherService : IPublisher
    {
        private readonly List<Planet> _planets = new List<Planet>();

        public PublisherService()
        {
            var timer = new Timer(TimeSpan.FromSeconds(3).TotalMilliseconds);
            timer.Elapsed += AuditPlanets;
            timer.Start();
        }

        private void AuditPlanets(object sender, ElapsedEventArgs e)
        {
            Log.Information("Reporting the number of planets");

            var processCount = System.Diagnostics.Process.GetProcesses().Length;
            Log.Debug("There are {ProcessCount} competing processes running on this computer.", processCount-1);

            Log.Information("There are {PlanetCount} planets", _planets.Count);
        }

        public void UpdatePlanet(Guid requestId, string author, Planet planet)
        {
            using (LogContext.PushProperty("RequestId", requestId))
            using (LogContext.PushProperty("PlanetId", planet.ID))
            {
                var oldPlanet = _planets.FirstOrDefault(p => p.ID == planet.ID);

                var rate = oldPlanet == null ? 10 : 5;
                PayTheAuthor(author, rate, planet);

                if (oldPlanet != null)
                    _planets.Remove(oldPlanet);
                _planets.Add(planet);
            }
        }

        private static void PayTheAuthor(string author, int rate, Planet planet)
        {
            Log.Information("Paid {author} ${rate} for update to {PlanetName}", author, rate, planet.Name);
        }

        public IEnumerable<Planet> GetPlanets(Guid requestId)
        {
            using (LogContext.PushProperty("RequestId", requestId))
            {
                Log.Information("Returning {Count} planets", _planets.Count);

                return _planets;
            }
        }

        public void DeletePlanet(Guid requestId, Planet planet)
        {
            using (LogContext.PushProperty("RequestId", requestId))
            using (LogContext.PushProperty("PlanetId", planet.ID))
            {
                Log.Information("Deleting {PlanetName}", planet.Name);

                var oldPlanet = _planets.FirstOrDefault(p => p.ID == planet.ID);

                if (oldPlanet != null)
                    _planets.Remove(oldPlanet);
            }
        }
    }
}
