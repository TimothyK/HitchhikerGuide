using System;
using System.ServiceModel;
using HitchhikerGuide.Data.PublisherClient.Services;

namespace HitchhikerGuide.Data.PublisherClient
{
    internal class HttpPublisherServer : IPublisher
    {

        private static Services.PublisherClient OpenServer()
        {
            var binding = new BasicHttpBinding();

            var ep = new EndpointAddress("http://localhost:1234/IPublisher");

            var srv = new Services.PublisherClient(binding, ep);

            srv.Open();

            return srv;
        }


        public void UpdatePlanet(Guid requestId, string author, Planet planet)
        {
            var publisher = OpenServer();

            publisher.UpdatePlanet(requestId, author, planet);

            publisher.Close();
        }

        public Planet[] GetPlanets(Guid requestId)
        {
            var publisher = OpenServer();

            var planets = publisher.GetPlanets(requestId);

            publisher.Close();

            return planets;
        }

        public void DeletePlanet(Guid requestId, Planet planet)
        {
            var publisher = OpenServer();

            publisher.DeletePlanet(requestId, planet);

            publisher.Close();
        }
    }
}
