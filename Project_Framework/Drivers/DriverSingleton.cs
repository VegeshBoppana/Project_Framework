using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace AProject_Framework.Utilities
{


    public sealed class DriverSingleton
    {
        private static readonly Lazy<IWebDriver> _lazyDriver = new Lazy<IWebDriver>(() => GetDriver(), true);

        private DriverSingleton() { }
        public static IWebDriver Instance => _lazyDriver.Value;
        private static IWebDriver GetDriver()
        {
            var driver = new ChromeDriver();
            return driver;
        }

      
    }
}
