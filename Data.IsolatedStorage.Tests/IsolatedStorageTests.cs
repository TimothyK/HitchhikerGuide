using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace HitchhikerGuide.Data.IsolatedStorage.Tests
{
    [TestClass]
    public class IsolatedStorageTests
    {
        [TestMethod]
        public void Save_CreatesFile()
        {
            //Arrange
            var repo = new Repository();
            var planet = new Planet();

            //Act
            repo.Save(planet);

            //Assert
            using (var isoStore = Repository.GetStore())
            {
                var fileName = planet.ID + ".xml";
                isoStore.FileExists(fileName).ShouldBeTrue();
            }

        }
    }
}
