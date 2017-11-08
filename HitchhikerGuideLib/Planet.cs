using System;
using HitchhikerGuide.Data;

namespace HitchhikerGuide
{
    [Serializable]
    public class Planet : IPlanet
    {
        private readonly IRepository _repository;
        private string _name;
        private string _skyColour;

        public Planet(IPlanet planet, IRepository repository)
        {
            _repository = repository;

            ID = planet.ID;
            Name = planet.Name;
            HasAtmosphere = planet.HasAtmosphere;
            SkyColour = planet.SkyColour;
            Notes = planet.Notes;
        }

        public Planet(IRepository repository)
        {
            _repository = repository;

            ID = Guid.NewGuid();
            Name = "<New Planet>";
        }

        public override string ToString() => Name;

        public Guid ID { get; set; }

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
            _repository.Save(this);
        }

        public event EventHandler NameChanged;

        private void OnNameChanged() => NameChanged?.Invoke(this, EventArgs.Empty);

    }
}
