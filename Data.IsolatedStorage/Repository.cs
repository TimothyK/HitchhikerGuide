
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;

namespace HitchhikerGuide.Data.IsolatedStorage
{
    public class Repository : IRepository
    {
        public IEnumerable<IPlanet> LoadPlanets()
        {
            var planets = new List<IPlanet>();

            using (var isoStore = GetStore())
                foreach (var fileName in isoStore.GetFileNames())
                    planets.Add(ReadFile(fileName, isoStore));

            return planets.Where(x => x != null).ToList();
        }


        private static IsolatedStorageFile GetStore()
        {
            return IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly | IsolatedStorageScope.Domain, null, null);
        }

        private PlanetFile ReadFile(string fileName, IsolatedStorageFile isoStore)
        {
            try
            {
                using (var fileStream = new IsolatedStorageFileStream(fileName, FileMode.Open, isoStore))
                using (var reader = new StreamReader(fileStream))
                {
                    var serializedData = reader.ReadToEnd();
                    return serializedData.Deserialize<PlanetFile>();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public void Save(IPlanet planet)
        {
            var planetFile = planet as PlanetFile ?? new PlanetFile(planet);            

            using (var isoStore = GetStore())
            using (var fileStream = isoStore.CreateFile(planet.ID + ".xml"))
            using (var writer = new StreamWriter(fileStream))
                writer.WriteLine(planetFile.ToSerializedXml());
        }

        public void Delete(IPlanet planet)
        {
            using (var isoStore = GetStore())
            {
                var fileName = planet.ID + ".xml";
                if (isoStore.FileExists(fileName))
                    isoStore.DeleteFile(fileName);
            }

        }
    }
}