using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowParallelTest.Steps
{
    [Binding]
    public class ElectronicTabSteps
    {
        private RemoteWebDriver _driver;
        public ElectronicTabSteps(RemoteWebDriver driver) => _driver = driver;


        [When(@"I Click Electronic tab")]
        public void WhenIClickElectronicTab()
        {
            _driver.FindElement(By.Id("IdElectronic")).Click();
        }
        
        [When(@"I Click Electronic tab and Samsung image")]
        public void WhenIClickElectronicTabAndSamsungImage()
        {
            _driver.FindElement(By.Id("IdElectronic")).Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("idSamsung")).Click();
            Thread.Sleep(1000);
        }
        
        [When(@"I Click Electronic tab and Nokia image")]
        public void WhenIClickElectronicTabAndNokiaImage()
        {
            _driver.FindElement(By.Id("IdElectronic")).Click();
            Thread.Sleep(1000);
            _driver.FindElement(By.Id("idNokia")).Click();
            Thread.Sleep(1000);
        }
        
        [When(@"click on back button on Nokia page")]
        public void WhenClickOnBackButtonOnNokiaPage()
        {
            _driver.FindElement(By.Id("btnback")).Click();
            Thread.Sleep(1000);
        }
        
        [Then(@"Display Electronic page with images")]
        public void ThenDisplayElectronicPageWithImages()
        {
            var element = _driver.FindElement(By.XPath("//html/body/div/div[2]/h1/b"));
            Thread.Sleep(1000);
            Assert.IsTrue(element.Text.Contains("Mobile :"), "Mobile :");
        }
        
        [Then(@"Display Samsung mobile with details")]
        public void ThenDisplaySamsungMobileWithDetails()
        {
            var element = _driver.FindElement(By.Id("idsamMobile1"));
            Thread.Sleep(1000);
            Assert.IsNotNull(element);
        }
        
        [Then(@"display the Nokia mobile with details")]
        public void ThenDisplayTheNokiaMobileWithDetails()
        {
            var element = _driver.FindElement(By.Id("idnokiaMobile1"));
            Thread.Sleep(1000);
            Assert.IsNotNull(element);
        }
        
    }
}
