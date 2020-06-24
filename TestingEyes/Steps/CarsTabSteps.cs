using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowParallelTest.Steps
{
    [Binding]
    public class CarTabSteps
    {
        private RemoteWebDriver _driver;

        public CarTabSteps(RemoteWebDriver driver) => _driver = driver;

        [When(@"I click Cars tab")]
        public void WhenIClickCarsTab()
        {
            _driver.FindElement(By.Id("IdCar")).Click();
        }
        
        [When(@"I click Cars tab and Swift car")]
        public void WhenIClickCarsTabAndSwiftCar()
        {
            _driver.FindElement(By.Id("IdCar")).Click();
            Thread.Sleep(1000);
            _driver.FindElement(By.Id("idCarMaruti")).Click();
            Thread.Sleep(1000);
        }
        
        [When(@"I click Cars tab and Tata Tiago image")]
        public void WhenIClickCarsTabAndTataTiagoImage()
        {
            _driver.FindElement(By.Id("IdCar")).Click();
            Thread.Sleep(1000);
            _driver.FindElement(By.Id("idCarTata")).Click();
            Thread.Sleep(1000);
        }
        
        [Then(@"Display the Cars page with images")]
        public void ThenDisplayTheCarsPageWithImages()
        {
            var element = _driver.FindElement(By.XPath("//html/body/div/div[2]/h1/b"));
            Thread.Sleep(1000);
            Assert.IsTrue(element.Text.Contains("Cars :"), "Cars :");
        }

        [When(@"click on Back button")]
        public void WhenClickOnBackButton()
        {
           _driver.FindElement(By.Id("btnback")).Click();
            Thread.Sleep(1000);
        }


        [Then(@"Display the Swift cars with details")]
        public void ThenDisplayTheSwiftCarsWithDetails()
        {
            var element = _driver.FindElement(By.Id("idSwiftMaruti"));
            Thread.Sleep(1000);
            Assert.IsNotNull(element);
        }
        
        [Then(@"Display the Tata Tiago cars with details")]
        public void ThenDisplayTheTataTiagoCarsWithDetails()
        {
            var element = _driver.FindElement(By.Id("idTiagoMaruti"));
            Thread.Sleep(1000);
            Assert.IsNotNull(element);
        }
    }
}
