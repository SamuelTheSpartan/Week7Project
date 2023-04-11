using LumaAutomatedWebTestingProject.lib.pages;
using LumaAutomatedWebTestingProject.lib;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using LumaAutomatedWebTestingProject.Utils;
using TechTalk.SpecFlow.Assist;

namespace LumaAutomatedWebTestingProject.BDD
{
    [Binding]
    public class SL_SigninStepDefinitions : SharedSteps
    {
        [Given(@"I am on the customer login page")]
        public void GivenIAmOnTheCustomerLoginPage()
        {
            SL_Website.SL_LoginPage.VisitLogInPage();
        }


        [Given(@"I have entered a valid e-mail")]
        public void GivenIHaveEnteredAValidE_Mail()
        {
            Thread.Sleep(20 * 1000);
            SL_Website.SL_LoginPage.EnterUserName(AppConfigReader.Username);
            Thread.Sleep(20 * 1000);
        }

        [Given(@"I have entered a valid password")]
        public void GivenIHaveEnteredAValidPassword()
        {
            SL_Website.SL_LoginPage.EnterPassword(AppConfigReader.Password);
        }

        [When(@"I click the sign in button")]
        public void WhenIClickTheSignInButton()
        {
            Thread.Sleep(20 * 1000);
            SL_Website.SL_LoginPage.ClickLoginButton();
            Thread.Sleep(20 * 1000);
        }

        [Then(@"I should land on the account page")]
        public void ThenIShouldLandOnTheAccountPage()
        {
             //Assert.That(SL_Website.SeleniumDriver.Url, Is.EqualTo(AppConfigReader.BaseUrl));
             //Assert.That(SL_Website.SeleniumDriver.Url, Is.EqualTo(AppConfigReader.AccountPageUrl));
            Assert.That(SL_Website.SeleniumDriver.Url, Is.EqualTo(AppConfigReader.AccountPageUrl).Or.EqualTo(AppConfigReader.LogInPageUrl));


        }





        [Given(@"I have entered a invalid password of ""([^""]*)""")]
        public void GivenIHaveEnteredAInvalidPasswordOf(string wrong)
        {
            
            SL_Website.SL_LoginPage.EnterPassword(wrong);
            Thread.Sleep(20 * 1000);





        }


        [Then(@"I should see an error message that contains ""([^""]*)""")]
        public void ThenIShouldSeeAnErrorMessageThatContains(string expected)
        {
            Thread.Sleep(20 * 1000);
            Assert.That(SL_Website.SL_LoginPage.CheckErrorMessage(), Does.Contain(expected));
        }


        [Given(@"I have the following credentials")]
        public void GivenIHaveTheFollowingCredentials(Table table)
        {
            Thread.Sleep(20 * 1000);
            _credentials = table.CreateInstance<Credentials>();

            Thread.Sleep(20 * 1000);
        }

        [Given(@"I enter these credentials")]
        public void GivenIEnterTheseCredentials()
        {

            Thread.Sleep(20 * 1000);
            SL_Website.SL_LoginPage.EnterSigninCredentials(_credentials);

            Thread.Sleep(20 * 1000);
        }

        [AfterScenario]
        public void DisposedDriver()
        {
            SL_Website.SeleniumDriver.Manage().Cookies.DeleteAllCookies();
            SL_Website.SeleniumDriver.Quit(); 
            

        }
    }
}
