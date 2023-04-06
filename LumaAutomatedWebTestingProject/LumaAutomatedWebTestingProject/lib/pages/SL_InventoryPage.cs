using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace LumaAutomatedWebTestingProject.lib.pages;

public class SL_InventoryPage
{
    private IWebDriver SeleniumDriver { get; }

    public SL_InventoryPage(IWebDriver seleniumDriver)
    {
        SeleniumDriver = seleniumDriver;
    }
    private IWebElement _addToCartButton => SeleniumDriver.FindElement(By.CssSelector("#product-addtocart-button > span"));
    
    public void VisitMenInventoryPage() => SeleniumDriver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/men/tops-men.html");

}
