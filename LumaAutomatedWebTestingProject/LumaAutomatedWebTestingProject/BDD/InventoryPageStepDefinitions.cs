using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace LumaAutomatedWebTestingProject.BDD
{
    [Binding]
    [Scope(Feature = @"InventoryPage")]
    public class InventoryPageStepDefinitions : SharedSteps
    {
        #region first test
        [Given(@"I am on the item's page")]
        public void GivenIAmOnTheItemsPage()
        {
            SL_Website.SeleniumDriver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/proteus-fitness-jackshirt.html#");
        }

        [Given(@"I pick black as my colour")]
        public void GivenIPickBlackAsMyColour()
        {
            SL_Website.SeleniumDriver.FindElement(By.Id("option-label-color-93-item-49")).Click();
        }

        [Given(@"I pick XS as my size")]
        public void GivenIPickXSAsMySize()
        {
            SL_Website.SeleniumDriver.FindElement(By.Id("option-label-size-143-item-166")).Click();
        }
        [When(@"I click the Add to Cart Button")]
        public void WhenIClickTheAddToCartButton()
        {
            SL_Website.SL_InventoryPage.AddToCart();
        }

        [Then(@"I should be able to add an item to my shopping cart")]
        public void ThenIShouldBeAbleToAddAnItemToMyShoppingCart()
        {
            Thread.Sleep(3000);
            SL_Website.SL_InventoryPage.VisitViewAndEditCart();
            Assert.That(SL_Website.SL_InventoryPage.CheckQuantity(), Is.EqualTo("1"));
        }
        #endregion first test
        #region second test
        [Given(@"I am on the basket page")]
        public void GivenIAmOnTheBasketPage()
        {
            // Assume that I already have one item added to the cart
            SL_Website.SeleniumDriver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/proteus-fitness-jackshirt.html#");
            SL_Website.SeleniumDriver.FindElement(By.Id("option-label-color-93-item-49")).Click();
            SL_Website.SeleniumDriver.FindElement(By.Id("option-label-size-143-item-166")).Click();
            SL_Website.SL_InventoryPage.AddToCart();
            Thread.Sleep(3000);
            SL_Website.SL_InventoryPage.VisitViewAndEditCart();
        }

        [When(@"I change the quantity to (.*)")]
        public void WhenIChangeTheQuantityTo(string qty)
        {
            // 9857 is max value
            SL_Website.SL_InventoryPage.ChangeQuantity("9858");
        }

        [When(@"I click update the shopping cart button")]
        public void WhenIClickUpdateTheShoppingCartButton()
        {
            SL_Website.SL_InventoryPage.UpdateShoppingCart();
        }


        [Then(@"I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            // it's false when the window pops up
            Thread.Sleep(2000);
            Assert.False(SL_Website.SL_InventoryPage.ShoppingCartErrorMessage());
        }
        #endregion second test
        #region third test
        [Given(@"I am on the inventory page")]
        public void GivenIAmOnTheInventoryPage()
        {
            // Assume I have at least an item in the basket
            SL_Website.SeleniumDriver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/proteus-fitness-jackshirt.html#");
            SL_Website.SeleniumDriver.FindElement(By.Id("option-label-color-93-item-49")).Click();
            SL_Website.SeleniumDriver.FindElement(By.Id("option-label-size-143-item-166")).Click();
            Thread.Sleep(3000);
            SL_Website.SL_InventoryPage.AddToCart();
        }

        [When(@"I click the Cart Icon")]
        public void WhenIClickTheCartIcon()
        {
            Thread.Sleep(3000);
            SL_Website.SL_InventoryPage.ClickCartButton();
        }

        [Then(@"a menu should show up with a proceed to checkout button")]
        public void ThenAMenuShouldShowUpWithAProceedToCheckoutButton()
        {
            Assert.That(SL_Website.SL_InventoryPage.CheckProceedToCheckoutButton());
        }
        #endregion third test
        #region forth test
        [Given(@"I have added an item to the basket")]
        public void GivenIHaveAddedAnItemToTheBasket()
        {
            // Assume I have at least an item in the basket
            SL_Website.SeleniumDriver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/proteus-fitness-jackshirt.html#");
            SL_Website.SeleniumDriver.FindElement(By.Id("option-label-color-93-item-49")).Click();
            SL_Website.SeleniumDriver.FindElement(By.Id("option-label-size-143-item-166")).Click();
            Thread.Sleep(3000);
            SL_Website.SL_InventoryPage.AddToCart();
        }

        [Given(@"I am on the Cart List")]
        public void GivenIAmOnTheCartList()
        {
            Thread.Sleep(3000);
            SL_Website.SL_InventoryPage.ClickCartButton();
        }

        [When(@"I click the Proceed to Checkout button")]
        public void WhenIClickTheProceedToCheckoutButton()
        {
            SL_Website.SL_InventoryPage.ProceedToCheckout();
        }

        [Then(@"I should be taken to the Checkout Shipping Address Page")]
        public void ThenIShouldBeTakenToTheCheckoutShippingAddressPage()
        {
            Assert.That(SL_Website.SL_InventoryPage.CheckUrl(), Does.Contain("Checkout"));
        }
        #endregion forth test

        [When(@"I click the View and Edit Cart button")]
        public void WhenIClickTheViewAndEditCartButton()
        {
            SL_Website.SL_InventoryPage.ClickViewAndEditCartButton();
        }

        [Then(@"I should be taken to the Shopping Cart Page")]
        public void ThenIShouldBeTakenToTheShoppingCartPage()
        {
            Thread.Sleep(3000);
            Assert.That(SL_Website.SL_InventoryPage.CheckUrl(), Does.Contain("Shopping Cart"));
        }

        [AfterScenario]
        public void ShutDown()
        {
            SL_Website.SeleniumDriver.Manage().Cookies.DeleteAllCookies();
            SL_Website.SeleniumDriver.Quit();
        }
    }
}
