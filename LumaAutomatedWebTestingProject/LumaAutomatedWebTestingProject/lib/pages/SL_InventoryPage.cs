using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace LumaAutomatedWebTestingProject.lib.pages;

public class SL_InventoryPage
{
    private IWebDriver SeleniumDriver { get; }

    public SL_InventoryPage(IWebDriver seleniumDriver)
    {
        SeleniumDriver = seleniumDriver;
    }
    private IWebElement _addToCartButton => SeleniumDriver.FindElement(By.CssSelector("#product-addtocart-button > span"));
    private IWebElement _updateTheShoppingCartButton => SeleniumDriver.FindElement(By.CssSelector(".action.update"));
    private IWebElement _shoppingCartErrorMessage => SeleniumDriver.FindElement(By.CssSelector(".modal-inner-wrap"));
    private IWebElement _cartButton => SeleniumDriver.FindElement(By.CssSelector(".showcart"));
    private IWebElement _proceedToCheckoutButton => SeleniumDriver.FindElement(By.CssSelector("#top-cart-btn-checkout"));
    private IWebElement _url => SeleniumDriver.FindElement(By.CssSelector(".page-title"));
    private IWebElement _viewAndEditButton => SeleniumDriver.FindElement(By.CssSelector("a.action.viewcart"));
    /// <summary>
    /// checks the value of the cart quantity, but the quantity id changes every test
    /// ID of the cart: cart- <ID> -qty ^= means start $= means end
    /// </summary>
    private IWebElement _qtyField => SeleniumDriver.FindElement(By.CssSelector("[id^= 'cart-'][id$= '-qty']"));
    public void VisitMenInventoryPage() => SeleniumDriver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/men/tops-men.html");
    public void VisitViewAndEditCart() => SeleniumDriver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/checkout/cart/");
    public void AddToCart() => _addToCartButton.Click();
    public string CheckQuantity() => _qtyField.GetAttribute("value");
    public void ChangeQuantity(string qty)
    {
        _qtyField.Clear(); // Clear the field before setting the quantity
        _qtyField.SendKeys(qty);
    }
    public void UpdateShoppingCart() => _updateTheShoppingCartButton.Click();
    public bool ShoppingCartErrorMessage() => _shoppingCartErrorMessage.Displayed;
    public void ClickCartButton() => _cartButton.Click();
    public bool CheckProceedToCheckoutButton() => _proceedToCheckoutButton.Displayed;
    public void ProceedToCheckout() => _proceedToCheckoutButton.Click();
    public string CheckUrl() => _url.Text;
    public void ClickViewAndEditCartButton() => _viewAndEditButton.Click();
}
