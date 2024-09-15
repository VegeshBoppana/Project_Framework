using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V126.FedCm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace PajeObject.CheckOut
{
    public partial class checkout
    {
        private readonly IWebDriver driver;
        private readonly IJavaScriptExecutor executor;
        public checkout(IWebDriver driver, IJavaScriptExecutor executor)
        {
           
            this.driver = driver;
            this.executor = executor;
        }



        // continue shopping
        // checkout
        //prductpage checking

        public void continueshopping()
        {
           // driver.FindElement(ContinueShopping).Click();
            driver_helper.ClickElement(driver, ContinueShopping);
        }

        public void CheckOut()
        {
            //driver.FindElement(Checkout).Click();
            driver_helper.ClickElement(driver, Checkout);
        }

        public bool HomePageValidation()
        {
            try
            {
                //var ans = driver.FindElement(Productpageindicator).Text;
                var ans = driver_helper.GetText(driver, Productpageindicator);
                if (ans == "Products")
                {

                    return true;
                }
                else
                {

                    return false;

                }
            }

            catch (NoSuchElementException)
            {
                return false;
            }

        }


        public bool CheckOutStepOneHeading()
        {
            try
            {
                //var ans = driver.FindElement(CheckOutStep1Heading).Text;
                var ans = driver_helper.GetText(driver, CheckOutStep1Heading);
                if (ans == "Checkout: Your Information")
                {

                    return true;
                }
                else
                {

                    return false;

                }
            }

            catch (NoSuchElementException)
            {
                return false;
            }

        }

        //stepone

        public void EnterFirstName(string firstName)
        {
           // driver.FindElement(FirstName).SendKeys(firstName);
            driver_helper.SendData(driver, FirstName, firstName);
        }
        public void EnterLastName(string lastName)
        {
           // driver.FindElement(LastName).SendKeys(lastName);
            driver_helper.SendData(driver, LastName, lastName);
        }
        public void EnterZipCode(string zipCode)
        {
            driver_helper.SendData(driver, Postalcode, zipCode);
           
        }

        public void S1Continue()
        {
           // driver.FindElement(S1Continuee).Click();
            driver_helper.ClickElement(driver, S1Continuee);
        }

        public void S1Cancel()
        {
            //driver.FindElement(S1Cancell).Click();
            driver_helper.ClickElement(driver, S1Cancell);
        }

        public string GetTitleName()
        {
           //var titlename = (string)driver.FindElement(PageName).Text;
            var titlename = (string)driver_helper.GetText(driver, PageName);
            return titlename;
            
        }
       

        //step two

        public void Step2Finish()
        {
            //driver.FindElement(S2Finish).Click();
            driver_helper.ClickElement (driver, S2Finish);
        }

        public void Step2Cancel()
        {
           // driver.FindElement(S2Cancel).Click();
            driver_helper.ClickElement(driver,S2Cancel);
        }

        //step three
        public bool checkconfirmation(string expected)
        {
            
           // var actual = (string)driver.FindElement(confirmation).Text;
            var actual = (string)driver_helper.GetText(driver, confirmation);
            if(actual == expected)

            {
                return true ;
            }
            return false;
        }


    }
}
