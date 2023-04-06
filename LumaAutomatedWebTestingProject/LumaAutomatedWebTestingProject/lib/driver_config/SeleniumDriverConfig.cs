using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumaAutomatedWebTestingProject.lib.driver_config
{
    public class SeleniumDriverConfig<T> where T : IWebDriver, new()
    {
        public IWebDriver Driver { get; set; }
        public SeleniumDriverConfig(int pageLoadInsecs, int implicitWaitInSecs, bool isHeadless)
        {
            Driver = new T();
            DriverSetUp(pageLoadInsecs, implicitWaitInSecs, isHeadless);
        }

        private void DriverSetUp(int pageLoadInsecs, int implicitWaitInSecs, bool isHeadless)
        {
            // This the the time the driver will wait for the page to load
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadInsecs);
            // This is the time the driver waits for the elemnts to load
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitInSecs);
            if (isHeadless) SetHeadless();
        }

        private void SetHeadless()
        {
            if (Driver is ChromeDriver)
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("headless");
                Driver = new ChromeDriver(options);
            }
            else if (Driver is FirefoxDriver)
            {
                FirefoxOptions options = new FirefoxOptions();
                options.AddArgument("--headless");
                Driver = new FirefoxDriver(options);
            }
            else
            {
                throw new ArgumentException("Driver not supported by framework");
            }
        }
    }
}
