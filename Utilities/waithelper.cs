using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class waithelper
    {
        //Implicit Wait

        public static void ImplicitWait(IWebDriver driver,double time)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);
        }

        // Explicit Wait for the element to be visible
        public static IWebElement ElementExists_ExplicitWait(IWebDriver driver, double time, By locator)
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            return wait.Until(ExpectedConditions.ElementExists(locator));

        }

        // Explicit Wait for the element to be Clickable
        public static IWebElement ElementClickable_ExplicitWait(IWebDriver driver, double time, By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            return wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        // Explicit Wait for the element to be Visible

        public static IWebElement ElementVisible_ExplicitWait(IWebDriver driver, double time, By locator)
        {
            WebDriverWait wait = new WebDriverWait (driver, TimeSpan.FromSeconds(time));
            return wait.Until(ExpectedConditions.ElementIsVisible(locator));   
        }



        //Fluent Wait

        public static IWebElement FluentWait(IWebDriver driver, TimeSpan time,TimeSpan pollingtime, By locator)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver)
            {
                Timeout = time, 
                PollingInterval = pollingtime,
                Message = "Element not found within the time period"
            };
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            return fluentWait.Until(ExpectedConditions.ElementExists(locator));
        }

       

    }
}
