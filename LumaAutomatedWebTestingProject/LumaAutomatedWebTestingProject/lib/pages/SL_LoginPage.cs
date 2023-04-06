using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LumaAutomatedWebTestingProject.lib.driver_config;
using OpenQA.Selenium;
using LumaAutomatedWebTestingProject.Utils;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LumaAutomatedWebTestingProject.lib.pages
{
    public class SL_LoginPage
    {
        private IWebDriver SeleniumDriver { get; }

        private string _loginPageUrl = AppConfigReader.LogInPageUrl;

        public SL_LoginPage(IWebDriver seleniumDriver)
        {
            SeleniumDriver = seleniumDriver;
        }

        private IWebElement _userNameField => SeleniumDriver.FindElement(By.Id("email"));
        private IWebElement _passwordField => SeleniumDriver.FindElement(By.Id("pass"));
        private IWebElement _signInButton => SeleniumDriver.FindElement(By.Id("send2"));
        private IWebElement _errorMessage => SeleniumDriver.FindElement(By.CssSelector(".message-error > div"));

        public void VisitLogInPage() => SeleniumDriver.Navigate().GoToUrl(_loginPageUrl);
        public void EnterUserName(string username) => _userNameField.SendKeys(username);
        public void EnterPassword(string password) => _passwordField.SendKeys(password);

        public void ClickLoginButton() => _signInButton.Click();

        public string CheckErrorMessage() => _errorMessage.Text;

    }
}
