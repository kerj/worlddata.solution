using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldData.Models;
using System.Collections.Generic;
using System;

namespace WorldData.Tests
{
    [TestClass]
    public class CountryTest : IDisposable
    {

        public void Dispose()
        {
            Country.ClearAll();
        }

        [TestMethod]
        public void CountryConstructor_CreatesInstanceOfCountry_Country()
        {
            Country newCountry = new Country("test country");
            Assert.AreEqual(typeof(Country), newCountry.GetType());
        }

        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            //Arrange
            string name = "Test Country";
            Country newCountry = new Country(name);

            //Act
            string result = newCountry.GetName();

            //Assert
            Assert.AreEqual(name, result);
        }

        [TestMethod]
        public void GetId_ReturnsCountryId_Int()
        {
            //Arrange
            string name = "Test Country";
            Country newCountry = new Country(name);

            //Act
            int result = newCountry.GetId();

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetAll_ReturnsAllCountryObjects_CountryList()
        {
            //Arrange
            string name01 = "Work";
            string name02 = "School";
            Country newCountry1 = new Country(name01);
            Country newCountry2 = new Country(name02);
            List<Country> newList = new List<Country> { newCountry1, newCountry2 };

            //Act
            List<Country> result = Country.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void Find_ReturnsCorrectCountry_Country()
        {
            //Arrange
            string name01 = "Work";
            string name02 = "School";
            Country newCountry1 = new Country(name01);
            Country newCountry2 = new Country(name02);

            //Act
            Country result = Country.Find(2);

            //Assert
            Assert.AreEqual(newCountry2, result);
        }

        [TestMethod]
        public void AddCity_AssociatesCityWithCountry_CityList()
        {
            //Arrange
            string description = "Walk the dog.";
            City newCity = new City(description);
            List<City> newList = new List<City> { newCity };
            string name = "Work";
            Country newCountry = new Country(name);
            newCountry.AddCity(newCity);

            //Act
            List<City> result = newCountry.GetCities();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }

    }
}
