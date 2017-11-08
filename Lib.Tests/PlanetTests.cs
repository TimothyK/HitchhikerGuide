using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace HitchhikerGuide.Lib.Tests
{
    [TestClass]
    public class PlanetTests
    {
        private TestRepository _repository;
        private Planet _planet;

        [TestInitialize]
        public void Setup()
        {
            _repository = new TestRepository();
            _planet = new Planet(_repository);
        }

        [TestMethod]
        public void Pluto_ThrowsApp()
        {
            Should.Throw<ApplicationException>(() => _planet.Name = "Pluto");
        }

        [TestMethod]
        public void Save_SavesToRepo()
        {
            //Act
            _planet.Save();

            //Assert
            _repository.SavedPlanets.ShouldContain(_planet);
        }

    }
}
