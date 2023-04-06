using LumaAutomatedWebTestingProject.lib.pages;
using LumaAutomatedWebTestingProject.Utils;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace LumaAutomatedWebTestingProject.BDD
{
    [Binding]
    [Scope(Feature = @"CreateAccount")]
    public class CreateAccountStepDefinitions
    {
        SL_Website<ChromeDriver> Sl_Website = new();

        Credentials _credentials;

        [Given(@"I am on the create new customer account page")]
        public void GivenIAmOnTheCreateNewCustomerAccountPage()
        {
            Sl_Website.SeleniumDriver.Manage().Window.Maximize();

            Sl_Website.SL_HomePage.VisitHomePage();

            Sl_Website.SL_HomePage.CreateAccountButtonClick();
        }

        [Given(@"I have the following valid credentials")]
        public void GivenIHaveTheFollowingValidCredentials(Table table)
        {
            _credentials = table.CreateInstance<Credentials>();
        }

        [Given(@"I enter the credentials")]
        public void GivenIEnterTheCredentials()
        {
            Sl_Website.SL_CreateAccountPage.EnterFirstNameTextBox(_credentials.Firstname);
            Thread.Sleep(500);
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


        [Given(@"I have the credentials with an Invalid Password")]
        public void GivenIHaveTheCredentialsWithAnInvalidPassword(Table table)
        {
            throw new PendingStepException();
        }
    }
}
