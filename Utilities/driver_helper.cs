using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V126.HeapProfiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class driver_helper
    {
        public static IWebElement FindElementSafe(this IWebDriver driver, By by)
        {
            return driver.FindElement(by);
        }

        public static void ClickElement(this IWebDriver driver, By by)
        {
            IWebElement element = driver.FindElementSafe(by);
            element.Click();
        }

        public static void SendData(this IWebDriver driver, By by, string data)
        {
            IWebElement element = driver.FindElementSafe(by);
            element.Clear();
            element.SendKeys(data);
        }


        public static string GetText(this IWebDriver driver, By by)
        {
            IWebElement element = driver.FindElementSafe(by);
            return element.Text;
        }

        public static void GoToPage(this IWebDriver driver, string url)
        {
             driver.Navigate().GoToUrl(url);
        }
    }
}