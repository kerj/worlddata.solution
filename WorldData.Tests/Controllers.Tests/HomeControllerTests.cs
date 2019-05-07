using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WorldData.Controllers;
using WorldData.Models;

namespace WorldData.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ActionResult indexView = controller.Index();

            //Assert
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        [TestMethod]
        public void Index_HasCorrectModelType_CityList()
        {
            //Arrange
             ViewResult indexView = new HomeController().Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(List<City>));
        }

        [TestMethod]
        public void Create_ReturnsCorrectActionType_RedirectToActionResult()
        {
            //Arrange
            CitiesController controller = new CitiesController();

            //Act
            IActionResult view = controller.Create("Walk the dog");

            //Assert
            Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
        }

        [TestMethod]
        public void Create_RedirectsToCorrectAction_Index()
        {
            //Arrange
            CitiesController controller = new CitiesController();
            RedirectToActionResult actionResult = controller.Create("Walk the dog") as RedirectToActionResult;

            //Act
            string result = actionResult.ActionName;

            //Assert
            Assert.AreEqual(result, "Index");
        }

    }
}
