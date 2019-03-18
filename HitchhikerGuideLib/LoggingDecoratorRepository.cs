using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using HitchhikerGuide.Data;
using Microsoft.Extensions.Logging;

namespace HitchhikerGuide
{
    internal class LoggingDecoratorRepository : IRepository
    {
        private readonly IRepository _baseRepository;
        private readonly ILoggerFactory _loggerFactory;

        public LoggingDecoratorRepository(IRepository baseRepository, ILoggerFactory loggerFactory)
        {
            _baseRepository = baseRepository;
            _loggerFactory = loggerFactory;
        }

        private ILogger<IRepository> CreateLogger()
        {
            return _loggerFactory.CreateLogger<IRepository>();
        }

        public IEnumerable<IPlanet> LoadPlanets()
        {
            var logger = CreateLogger();
            
            logger.LogInformation("Loading Planets");
            var stopwatch = Stopwatch.StartNew();

            IPlanet[] planets;
            try
            {
                planets = _baseRepository.LoadPlanets().ToArray();
                logger.LogInformation("{Count} planets loaded in {ElapsedMilliseconds} ms", planets.Length, stopwatch.ElapsedMilliseconds);
            }        
            catch (Exception ex)
            {
                logger.LogError(ex, "Failed to load planets");
                return Enumerable.Empty<IPlanet>();
            }

            return planets;
        }

        public void Save(IPlanet planet)
        {
            var logger = CreateLogger();
            using (logger.BeginScope("{PlanetID}", planet.ID))
            {
                logger.LogInformation("Saving {Name}", planet.Name);
                var stopwatch = Stopwatch.StartNew();

                try
                {
                    _baseRepository.Save(planet);
                    logger.LogInformation("Saved {Name} in {ElapsedMilliseconds} ms", planet.Name, stopwatch.ElapsedMilliseconds);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "Failed to save planet");
                }
            }            
        }

        public void Delete(IPlanet planet)
        {
            var logger = CreateLogger();
            using (logger.BeginScope("{PlanetID}", planet.ID))
            {
                logger.LogInformation("Deleting {Name}", planet.Name);
                var stopwatch = Stopwatch.StartNew();

                try
                {
                    _baseRepository.Delete(planet);

                    logger.LogInformation("Deleted {Name} in {ElapsedMilliseconds} ms", planet.Name, stopwatch.ElapsedMilliseconds);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "Failed to delete planet");
                }
            }
            
        }
    }
}
