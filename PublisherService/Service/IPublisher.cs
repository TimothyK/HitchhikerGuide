using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace PublisherService.Service
{
    [ServiceContract(Namespace = "https://services.github.com/TimothyK/HitchhikerGuide/Publisher")]
    public interface IPublisher
    {
        [OperationContract]
        void UpdatePlanet(Guid requestId, string author, Planet planet);

        [OperationContract]
        IEnumerable<Planet> GetPlanets(Guid requestId);

        [OperationContract]
        void DeletePlanet(Guid requestId, Planet planet);

    }
}
