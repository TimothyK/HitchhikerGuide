using System.Collections.Generic;

namespace HitchhikerGuide.Data
{
    public interface IRepository
    {
        IEnumerable<IPlanet> LoadPlanets();

        void Save(IPlanet planet);

        void Delete(IPlanet planet);
    }
}
