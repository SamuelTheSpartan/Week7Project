using LumaAutomatedWebTestingProject.lib.pages;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace LumaAutomatedWebTestingProject.BDD
{
    /// <summary>
    /// This might not be needed but include anything shared by ALL tests
    /// </summary>
    public class SharedSteps
    {
        protected SL_Website<ChromeDriver> SL_Website { get; } = new();


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
    }
}
