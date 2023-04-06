using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumaAutomatedWebTestingProject.lib.pages
{
    public class SL_CreateAccountPage
    {
        private IWebDriver _seleniumDriver;

        private IWebElement _firstNameTextBox => _seleniumDriver.FindElement(By.Id("firstname"));
        private IWebElement _lastNameTextBox => _seleniumDriver.FindElement(By.Id("lastname"));
        private IWebElement _emailTextBox => _seleniumDriver.FindElement(By.Id("email_address"));
        private IWebElement _passwordTextBox => _seleniumDriver.FindElement(By.Id("password"));
        private IWebElement _passwordConfirmTextBox => _seleniumDriver.FindElement(By.Id("password-confirmation"));
        private IWebElement _errorMessageBox => _seleniumDriver.FindElement(By.CssSelector(".message-error > div"));

        private IWebElement _passwordErrorMessageBox => _seleniumDriver.FindElement(By.Id("password-error"));

        private IWebElement _createAccountButton => _seleniumDriver.FindElement(By.CssSelector(".submit > span"));

        public SL_CreateAccountPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void EnterFirstNameTextBox(string name) => _firstNameTextBox.SendKeys(name);
        public void EnterLastNameTextBox(string name) => _lastNameTextBox.SendKeys(name);
        public void EnterEmailTextBox(string email) => _emailTextBox.SendKeys(email);
        public void EnterPasswordTextBox(string password) => _passwordTextBox.SendKeys(password);
        public void EnterPasswordConfirmationTextBox(string passwordConfirm) => _passwordConfirmTextBox.SendKeys(passwordConfirm);
        public void CreateAccountButtonClick() => _createAccountButton.Click();
        public string ErrorMessageText() => _errorMessageBox.Text;
        public string PasswordErrorMessageText() => _passwordErrorMessageBox.Text;
    }
    
}
