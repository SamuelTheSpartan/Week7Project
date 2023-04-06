using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LumaAutomatedWebTestingProject.lib.driver_config;
using OpenQA.Selenium;
using LumaAutomatedWebTestingProject.Utils;

namespace LumaAutomatedWebTestingProject.lib.pages
{
    public class SL_LoginPage
    {
        private IWebDriver _seleniumDriver;

        private string _loginPageUrl = AppConfigReader.LogInPageUrl;

        private IWebElement _userNameField => _seleniumDriver.FindElement(By.Id("email"));
        private IWebElement _passwordField => _seleniumDriver.FindElement(By.Id("pass"));
        private IWebElement _signInButton => _seleniumDriver.FindElement(By.Id("send2"));
        private IWebElement _errorMessage => _seleniumDriver.FindElement(By.CssSelector("#maincontent > div.page.messages > div:nth-child(2) > div > div"));


        public SL_LoginPage(IWebDriver driver)
        {
            _seleniumDriver = driver;
        }

        public void VisitLogInPage() => _seleniumDriver.Navigate().GoToUrl(_loginPageUrl);

        public void EnterUserName(string username) => _userNameField.SendKeys(username);
        public void EnterPassword(string password) => _passwordField.SendKeys(password);

        public void ClickLoginButton() => _signInButton.Click();

        public string CheckErrorMessage() => _errorMessage.Text;

        public void EnterSigninCredentials(Credentials credentials)
        {
            EnterUserName(credentials.Email);
            EnterPassword(credentials.Password);

        }

    }
}
