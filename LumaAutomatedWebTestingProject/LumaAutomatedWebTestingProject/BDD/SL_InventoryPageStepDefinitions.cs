using TechTalk.SpecFlow;
using LumaAutomatedWebTestingProject.lib;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using LumaAutomatedWebTestingProject.lib.pages;
using TechTalk.SpecFlow.Assist;
using LumaAutomatedWebTestingProject.Utils;
using LumaAutomatedWebTestingProject.lib.driver_config;
using System.Security.Cryptography.X509Certificates;

namespace LumaAutomatedWebTestingProject.BDD
{
    [Binding]
    public class SL_InventoryPageStepDefinitions : SharedSteps
    {
        [Given(@"I am on an item's page")]
        public void GivenIAmOnAnItemsPage()
        {
            //SL_Website.SL_InventoryPage.VisitMenInventoryPage();
            SL_Website.SeleniumDriver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/proteus-fitness-jackshirt.html#");
        }

        [Given(@"I pick a option-label-color(.*)-item(.*)")]
        public void GivenIPickAOption_Label_Color_Item(Table t1, Table t2)
        {
            List<string> colours = t1.Rows.Select(row => row[0]).ToList();
            
        }

        [Given(@"I pick a option-label-size(.*)-item(.*)")]
        public void GivenIPickAOption_Label_Size_Item(int p0, int p1)
        {
            throw new PendingStepException();
        }

        [Given(@"I pick a quantity")]
        public void GivenIPickAQuantity()
        {
            throw new PendingStepException();
        }

        [When(@"I click the Add to Cart Button")]
        public void WhenIClickTheAddToCartButton()
        {
            throw new PendingStepException();
        }

        [Then(@"the item\(s\) should be added to the cart")]
        public void ThenTheItemSShouldBeAddedToTheCart()
        {
            throw new PendingStepException();
        }

        [Given(@"I have less than or equal to (.*) items in the basket")]
        public void GivenIHaveLessThanOrEqualToItemsInTheBasket(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"I add (.*) or more items to basket")]
        public void WhenIAddOrMoreItemsToBasket(int p0)
        {
            throw new PendingStepException();
        }

        [Given(@"I am on the inventory page")]
        public void GivenIAmOnTheInventoryPage()
        {
            throw new PendingStepException();
        }

        [When(@"I click the Cart Icon")]
        public void WhenIClickTheCartIcon()
        {
            throw new PendingStepException();
        }

        [Then(@"a menu should show up with a proceed to checkout button")]
        public void ThenAMenuShouldShowUpWithAProceedToCheckoutButton()
        {
            throw new PendingStepException();
        }

        [Then(@"it should include the items in the cart")]
        public void ThenItShouldIncludeTheItemsInTheCart()
        {
            throw new PendingStepException();
        }

        [Given(@"The basket is not empty")]
        public void GivenTheBasketIsNotEmpty()
        {
            throw new PendingStepException();
        }

        [Given(@"I am on the Cart List")]
        public void GivenIAmOnTheCartList()
        {
            throw new PendingStepException();
        }

        [When(@"I click the Proceed to Checkout button")]
        public void WhenIClickTheProceedToCheckoutButton()
        {
            throw new PendingStepException();
        }

        [Then(@"I should be taken to the Checkout Shipping Address Page")]
        public void ThenIShouldBeTakenToTheCheckoutShippingAddressPage()
        {
            throw new PendingStepException();
        }

        [When(@"I click the View and Edit Cart button")]
        public void WhenIClickTheViewAndEditCartButton()
        {
            throw new PendingStepException();
        }

        [Then(@"I should be taken to the SHopping Cart Page")]
        public void ThenIShouldBeTakenToTheSHoppingCartPage()
        {
            throw new PendingStepException();
        }
    }
}
