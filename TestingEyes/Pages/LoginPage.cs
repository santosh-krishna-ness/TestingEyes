using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace TestingEyes.Pages
{
    public class LoginPage
    {

        private readonly RemoteWebDriver _driver;

        public LoginPage(RemoteWebDriver driver) => _driver = driver;


        IWebElement txtUserName => _driver.FindElementById("LoginModel_Username");
        IWebElement txtPassword => _driver.FindElementById("LoginModel_Password");
        IWebElement btnLogin => _driver.FindElementById("btnLogin");
        IWebElement btnLogout => _driver.FindElementById("btnlogoff");
        IWebElement Name => _driver.FindElementById("txtname");
        IWebElement Username => _driver.FindElementById("txtuser");
        IWebElement Email => _driver.FindElementById("txtemail");
        IWebElement Password => _driver.FindElementById("txtpassword");

        IWebElement btnSubmit => _driver.FindElementById("btnsubmit");




        public void EnterUserNameAndPassword(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public void EnterUserDetails(string name,string userName, string email, string password)
        {
            Name.SendKeys(name);
            Username.SendKeys(userName);
            Email.SendKeys(email);
            Password.SendKeys(password);
        }

        public void ClickLogin()
        {
            btnLogin.Click();
        }

        public void clickLogout()
        {
            btnLogout.Click();
        }

        public void clicksubmit()
        {
            btnSubmit.Click();
        }


    }
}
