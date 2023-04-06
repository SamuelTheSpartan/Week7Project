using LumaAutomatedWebTestingProject.lib.driver_config;
using OpenQA.Selenium;

namespace LumaAutomatedWebTestingProject.lib.pages
{
    public class SL_Website<T> where T : IWebDriver, new()
    {
        #region Accessible Page Objects and Driver
        public IWebDriver SeleniumDriver { get; set; }
        public SL_HomePage SL_HomePage { get; set; }
        public SL_InventoryPage SL_InventoryPage { get; set; } //manhim added hihi
        #endregion

        public SL_Website(int pageLoadInSecs = 10, int implicitlyWaitInSecs = 10, bool isHeadless = false)
        {
            SeleniumDriver = new SeleniumDriverConfig<T>(pageLoadInSecs, implicitlyWaitInSecs, isHeadless).Driver;
            SL_HomePage = new SL_HomePage(SeleniumDriver);
            SL_InventoryPage = new SL_InventoryPage(SeleniumDriver); //manhim added hihi
        }
    }
}
