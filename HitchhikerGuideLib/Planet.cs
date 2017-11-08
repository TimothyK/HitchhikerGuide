using System;
using System.IO;
using System.IO.IsolatedStorage;

namespace HitchhikerGuide
{
    [Serializable]
    public class Planet
    {
        private string _name;
        private string _skyColour;

        public override string ToString() => Name;

        public string Name
        {
            get => _name;
            set
            {
                if (value == "Pluto")
                    throw new ApplicationException("Pluto is not a planet");

                if (_name == value) return;

                _name = value;
                OnNameChanged();
            }
        }

        public bool HasAtmosphere { get; set; }


        public string SkyColour
        {
            get => _skyColour;
            set
            {
                if (!HasAtmosphere && value != "Black")
                    throw new ApplicationException("With no atmosphere the sky must be 'Black'");

                _skyColour = value;                 
            }
        }

        public string Notes { get; set; }


        public void Save()
        {
            using (var isoStore = GetStore())
            using (var fileStream = isoStore.CreateFile(Name + ".xml"))
            using (var writer = new StreamWriter(fileStream))
                writer.WriteLine(this.ToSerializedXml());

        }
        private static IsolatedStorageFile GetStore()
        {
            return IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly | IsolatedStorageScope.Domain, null, null);
        }

        public event EventHandler NameChanged;

        private void OnNameChanged() => NameChanged?.Invoke(this, EventArgs.Empty);

    }
}
