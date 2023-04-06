using System;
using TechTalk.SpecFlow;

namespace LumaAutomatedWebTestingProject
{
    [Binding]
    [Scope(Feature = "@Signin")]
    public class SL_SigninStepDefinitions
    {
        [Given(@"I am on the customer login page")]
        public void GivenIAmOnTheCustomerLoginPage()
        {
            //SL_LoginPage.VisitLogInPage();
        }

        [Given(@"I have entered a valid e-mail")]
        public void GivenIHaveEnteredAValidE_Mail()
        {
            throw new PendingStepException();
        }

        [Given(@"I have entered a valid password")]
        public void GivenIHaveEnteredAValidPassword()
        {
            throw new PendingStepException();
        }

        [When(@"I click the sign in button")]
        public void WhenIClickTheSignInButton()
        {
            throw new PendingStepException();
        }

        [Then(@"I should land on the account page")]
        public void ThenIShouldLandOnTheAccountPage()
        {
            throw new PendingStepException();
        }

        [Given(@"I have entered a invalid password of ""([^""]*)""")]
        public void GivenIHaveEnteredAInvalidPasswordOf(string wrong)
        {
            throw new PendingStepException();
        }

        [Then(@"I should see an error message that contains ""([^""]*)""")]
        public void ThenIShouldSeeAnErrorMessageThatContains(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"I have the following credentials")]
        public void GivenIHaveTheFollowingCredentials(Table table)
        {
            throw new PendingStepException();
        }

        [Given(@"I enter these credentials")]
        public void GivenIEnterTheseCredentials()
        {
            throw new PendingStepException();
        }
    }
}
