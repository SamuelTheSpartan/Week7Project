using LumaAutomatedWebTestingProject.lib.driver_config;
using OpenQA.Selenium;

namespace LumaAutomatedWebTestingProject.lib.pages
{
    public class SL_Website<T> where T : IWebDriver, new()

    {
        #region Accessible Page Objects and Driver
        public IWebDriver SeleniumDriver { get; set; }
        public SL_HomePage SL_HomePage { get; set; }

        public SL_CreateAccountPage SL_CreateAccountPage { get; set; }
        public SL_LoginPage SL_LoginPage { get; set; }


        public SL_InventoryPage SL_InventoryPage { get; set; } 

        #endregion

        public SL_Website(int pageLoadInSecs = 10, int implicitlyWaitInSecs = 10, bool isHeadless = true)
        {
            SeleniumDriver = new SeleniumDriverConfig<T>(pageLoadInSecs, implicitlyWaitInSecs, isHeadless).Driver;
            SL_HomePage = new SL_HomePage(SeleniumDriver);
            SL_CreateAccountPage = new SL_CreateAccountPage(SeleniumDriver);
            SL_LoginPage = new SL_LoginPage(SeleniumDriver);
            SL_InventoryPage = new SL_InventoryPage(SeleniumDriver); //manhim added hihi
        }
    }
}
