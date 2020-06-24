using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using OpenQA.Selenium.Remote;
using TestingEyes.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;

namespace TestingEyes.Steps
{
    [Binding]
    public class LoginSteps
    {

        private RemoteWebDriver _driver;

        public LoginSteps(RemoteWebDriver driver) => _driver = driver;


        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            _driver.Navigate().GoToUrl("https://testingeyesservice.azurewebsites.net/");
        }

        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            LoginPage page = new LoginPage(_driver);
            page.EnterUserNameAndPassword("admin", "Admin");
        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            Thread.Sleep(1000);
            _driver.FindElement(By.Id("btnLogin")).Submit();
            Thread.Sleep(2000);
        }

        [Then(@"I should see user logged in to the application")]
        public void ThenIShouldSeeUserLoggedInToTheApplication()
        {
            var element = _driver.FindElement(By.XPath("//html/body/div/div[2]/h1/b"));
            Assert.IsTrue(element.Text.Contains("Testing Eyes"), "Testing Eyes");
        }

        [When(@"I click on Sign up button")]
        public void WhenIClickOnSignUpButton(Table table)
        {
            LoginPage page = new LoginPage(_driver);
            _driver.FindElement(By.Id("idSignup")).Click();
            dynamic data = table.CreateDynamicInstance();
            page.EnterUserDetails(table.Rows[0][0], table.Rows[0][1], table.Rows[0][2], table.Rows[0][3]);
            Thread.Sleep(2000);
        }

        [When(@"I click Log out button")]
        public void WhenIClickLogOutButton()
        {
            _driver.FindElement(By.Id("btnlogoff")).Click();
        }

        [When(@"clicks on Submit button")]
        public void WhenClicksOnSubmitButton()
        {
            _driver.FindElement(By.Id("btnsubmit")).Submit();
            Thread.Sleep(1000);
        }

        [Then(@"navigate to login page")]
        public void ThenNavigateToLoginPage()
        {
            var element = _driver.FindElement(By.XPath("//html/body/nav/div/div/h2"));
            Assert.IsTrue(element.Text.Contains("Testing Eyes"), "Testing Eyes");
        }


    }
}
