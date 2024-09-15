using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class Action_Helper
    {

        public static void RightClick(IWebDriver driver, By by)
        {
            Actions action = new Actions(driver);
            IWebElement webElement = driver_helper.FindElementSafe(driver, by);
            action.ContextClick(webElement).Perform();
        }

        public static void DoubleClick(IWebDriver driver, By by)
        {
            Actions action = new Actions(driver);
            IWebElement webElement = driver_helper.FindElementSafe(driver, by);
            action.DoubleClick(webElement).Perform();
        }

        public static void ClickAndHold(IWebDriver driver, By by)
        {
            Actions action = new Actions(driver);
            IWebElement webElement = driver_helper.FindElementSafe(driver, by);
            action.ClickAndHold(webElement).Perform();
        }

        public static void DragDrop(IWebDriver driver, By sourceBy, By targetBy)
        {
            Actions action = new Actions(driver);
            IWebElement sourceElement = driver_helper.FindElementSafe(driver, sourceBy);
            IWebElement targetElement = driver_helper.FindElementSafe(driver, targetBy);
            action.DragAndDrop(sourceElement, targetElement).Perform();
        }

        public static void Release(IWebDriver driver, By by)
        {
            Actions action = new Actions(driver);
            IWebElement webElement = driver_helper.FindElementSafe(driver, by);
            action.Release(webElement).Perform();
        }
    }
}
