using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumIISExpress;
using SeleniumIISExpress.Controllers;

namespace SeleniumIISExpress.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTests : SeleniumTest
    {
        public HomeControllerTests() : base("SeleniumIISExpress") { }

        [TestMethod]
        public void IndexChromeText()
        {
            //Arrange
           HomeController controller = new HomeController();

           //Act
            this.ChromeDriver.Navigate().GoToUrl(this.GetAbsoluteUrl("/home/index"));
            this.ChromeDriver.FindElement(By.ClassName("btn-lg")).Click();

            //Assert
            //Assert.IsTrue(this.ChromeDriver.FindElement(By.Id("msg")).Displayed);
        }

        //[TestMethod]
        //public void About()
        //{
        //    // Arrange
        //    HomeController controller = new HomeController();

        //    // Act
        //    ViewResult result = controller.About() as ViewResult;

        //    // Assert
        //    Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        //}

        //[TestMethod]
        //public void Contact()
        //{
        //    // Arrange
        //    HomeController controller = new HomeController();

        //    // Act
        //    ViewResult result = controller.Contact() as ViewResult;

        //    // Assert
        //    Assert.IsNotNull(result);
        //}
    }
}
