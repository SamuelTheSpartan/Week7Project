using LumaAutomatedWebTestingProject.lib.pages;
using LumaAutomatedWebTestingProject.lib;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;

namespace LumaAutomatedWebTestingProject.BDD
{
    [Binding]
    public class SL_SigninStepDefinitions
    {
        SL_Website<ChromeDriver> SL_Website { get; } = new();

        [Given(@"I am on the customer login page")]
       public void GivenIAmOnTheCustomerLoginPage()
        {
            SL_Website.SL_LoginPage.VisitLogInPage();
        }

        [Given(@"I have entered a valid e-mail")]
        public void GivenIHaveEnteredAValidE_Mail()
        {
            SL_Website.SL_LoginPage.EnterUserName(AppConfigReader.Username);
        }

        [Given(@"I have entered a valid password")]
        public void GivenIHaveEnteredAValidPassword()
        {
            SL_Website.SL_LoginPage.EnterPassword(AppConfigReader.Password);
        }

        [When(@"I click the sign in button")]
        public void WhenIClickTheSignInButton()
        {
            SL_Website.SL_LoginPage.ClickLoginButton();
        }

        [Then(@"I should land on the account page")]
        public void ThenIShouldLandOnTheAccountPage()
        {
            Assert.That(SL_Website.SeleniumDriver.Url, Is.EqualTo(AppConfigReader.AccountPageUrl));
        }

        [Given(@"I have entered a invalid password of ""([^""]*)""")]
        public void GivenIHaveEnteredAInvalidPasswordOf(string wrong)
        {
            SL_Website.SL_LoginPage.EnterPassword(wrong);
        }

        [Then(@"I should see an error message that contains ""([^""]*)""")]
        public void ThenIShouldSeeAnErrorMessageThatContains(string expected)
        {
            Assert.That(SL_Website.SL_LoginPage.CheckErrorMessage(), Does.Contain(expected));
        }

        //[Given(@"I have the following credentials")]
        //public void GivenIHaveTheFollowingCredentials(Table table)
        //{
        //    throw new PendingStepException();
        //}

        //[Given(@"I enter these credentials")]
        //public void GivenIEnterTheseCredentials()
        //{
        //    throw new PendingStepException();
        //}

        [AfterScenario]
        public void DisposedDriver()
        {
            SL_Website.SeleniumDriver.Quit(); 
        }
    }
}
