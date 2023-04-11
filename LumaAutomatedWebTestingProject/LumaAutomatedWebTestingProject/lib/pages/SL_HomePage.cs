using OpenQA.Selenium;

namespace LumaAutomatedWebTestingProject.lib.pages
{
    public class SL_HomePage
    {
        private IWebDriver _seleniumDriver;

        private string _homePageUrl = AppConfigReader.BaseUrl;

        private IWebElement _loginButton => _seleniumDriver.FindElement(By.LinkText("Sign In"));
        private IWebElement _createAccountButton => _seleniumDriver.FindElement(By.LinkText("Create an Account"));

        public SL_HomePage(IWebDriver driver)
        {
            _seleniumDriver = driver;
            
        }

        public void VisitHomePage() => _seleniumDriver.Navigate().GoToUrl(_homePageUrl);

        public void LoginButtonClick() => _loginButton.Click();
        public void CreateAccountButtonClick() => _createAccountButton.Click();

    }
}
