using System;
using TechTalk.SpecFlow;

namespace LumaAutomatedWebTestingProject.BDD
{
    [Binding]
    public class CreateAccountStepDefinitions
    {
        [Given(@"I am on the create new customer account page")]
        public void GivenIAmOnTheCreateNewCustomerAccountPage()
        {
            throw new PendingStepException();
        }

        [Given(@"I enter valid credentials")]
        public void GivenIEnterValidCredentials(Table table)
        {
            throw new PendingStepException();
        }

        [When(@"I click the create an account button")]
        public void WhenIClickTheCreateAnAccountButton()
        {
            throw new PendingStepException();
        }

        [Then(@"I should land on the account page")]
        public void ThenIShouldLandOnTheAccountPage()
        {
            throw new PendingStepException();
        }

        [Given(@"I have entered a invalid First Name ""([^""]*)""")]
        public void GivenIHaveEnteredAInvalidFirstName(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"I have entered a invalid Last Name ""([^""]*)""")]
        public void GivenIHaveEnteredAInvalidLastName(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"I have entered a unregistered Email")]
        public void GivenIHaveEnteredAUnregisteredEmail()
        {
            throw new PendingStepException();
        }

        [Given(@"I have entered a valid Password ""([^""]*)""")]
        public void GivenIHaveEnteredAValidPassword(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"I have entered a valid Password Confirmation ""([^""]*)""")]
        public void GivenIHaveEnteredAValidPasswordConfirmation(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"I should see an error message that contains ""([^""]*)""")]
        public void ThenIShouldSeeAnErrorMessageThatContains(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"I enter the credentials with an Invalid Password")]
        public void GivenIEnterTheCredentialsWithAnInvalidPassword(Table table)
        {
            throw new PendingStepException();
        }
    }
}
