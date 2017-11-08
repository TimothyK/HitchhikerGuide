using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;

namespace HitchhikerGuide
{
    public class PlanetList : IEnumerable<Planet>
    {
        public PlanetList()
        {
            LoadAllFiles();
        }

        private readonly List<Planet> _planets = new List<Planet>();
        private Planet _selectedItem;

        public IEnumerator<Planet> GetEnumerator()
        {
            return _planets.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }



        private void LoadAllFiles()
        {
            using (var isoStore = GetStore())
                foreach (var fileName in isoStore.GetFileNames())
                    ReadFile(fileName, isoStore);

            SelectedItem = _planets.FirstOrDefault();
        }

        private static IsolatedStorageFile GetStore()
        {
            return IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly | IsolatedStorageScope.Domain, null, null);
        }

        private void ReadFile(string fileName, IsolatedStorageFile isoStore)
        {
            using (var fileStream = new IsolatedStorageFileStream(fileName, FileMode.Open, isoStore))
            using (var reader = new StreamReader(fileStream))
            {
                var serializedData = reader.ReadToEnd();
                try
                {
                    var planet = serializedData.Deserialize<Planet>();
                    _planets.Add(planet);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);                    
                }
            }
        }


        public Planet SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (_selectedItem == value) return;

                _selectedItem = value;
                OnSelectedPlanetChanged();
            }
        }

        public event EventHandler<SelectedPlanetChangedEventArgs> SelectedPlanetChanged;

        private void OnSelectedPlanetChanged() => SelectedPlanetChanged?.Invoke(this, new SelectedPlanetChangedEventArgs(SelectedItem));


        public void Add()
        {
            var planet = new Planet { Name = "<New Planet>" };

            _planets.Add(planet);
            OnCollectionChanged(CollectionChangeReason.ItemAdded);

            SelectedItem = planet;
        }

        public void Delete()
        {
            var planet = SelectedItem;
            if (planet == null)
                throw new InvalidOperationException($"{nameof(SelectedItem)} must be set before deleting");

            var index = _planets.IndexOf(planet);
            
            using (var isoStore = GetStore())
            {
                var fileName = planet.Name + ".xml";
                if (isoStore.FileExists(fileName))
                    isoStore.DeleteFile(fileName);
            }

            _planets.Remove(planet);
            OnCollectionChanged(CollectionChangeReason.ItemRemoved);

            SelectedItem = _planets.Skip(index).FirstOrDefault() ?? _planets.LastOrDefault();

        }

        /// <summary>
        /// Occurs when a planet is added or removed from this collection.
        /// </summary>
        public event EventHandler<CollectionChangedEventArgs> CollectionChanged;

        private void OnCollectionChanged(CollectionChangeReason reason) => CollectionChanged?.Invoke(this, new CollectionChangedEventArgs(reason));
    }
}
