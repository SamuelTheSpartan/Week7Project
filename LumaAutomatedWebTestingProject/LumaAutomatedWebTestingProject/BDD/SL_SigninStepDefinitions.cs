using LumaAutomatedWebTestingProject.lib.pages;
using LumaAutomatedWebTestingProject.lib;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;

namespace LumaAutomatedWebTestingProject.BDD
{
    [Binding]
    public class SL_SigninStepDefinitions : SharedSteps
    {

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
