using System;
using OpenQA.Selenium;
using Utilities;  // Ensure to use the Utilities namespace to access driver_helper methods

namespace PajeObject.Product
{
    public partial class productpage : Exception
    {
        private readonly IWebDriver driver;
        private IJavaScriptExecutor jsExecutor;

        public productpage(IWebDriver driver, IJavaScriptExecutor jsExecutor)
        {
            this.driver = driver;
            this.jsExecutor = jsExecutor;
        }

        // Check the product page indicator
        public bool HomePageValidation()
        {
            try
            {
                string ans = driver_helper.GetText(driver, Productpageindicator);
                
                return ans == "Products";
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        // Add Sauce Labs BackPack
        public void BackPack()
        {
            driver_helper.ClickElement(driver,BackPackItem);
            
        }

        // Add Sauce Bike Light
        public void BikeLight()
        {
            driver_helper.ClickElement(driver, BikeLightItem);
        }

        // Add Sauce Labs T-Shirt
        public void BoltTShirt()
        {
            driver_helper.ClickElement(driver, BoltShirtItem);
        }

        // Add Sauce Fleece Jacket
        public void Fleece()
        {
            driver_helper.ClickElement(driver, FleeceJacket);
        }

        // Add Sauce Labs Onesie
        public void Onesie()
        {
            driver_helper.ClickElement(driver, LabsOnesie);
        }

        // Add T-Shirt(Red)
        public void RedShirt()
        {
            driver_helper.ClickElement(driver, TShirtRed);
        }

        // Check cart number
        public bool CountOfCart(int actualCount)
        {
            string expectedCount = driver_helper.GetText(driver, CartCount);
            return Convert.ToInt32(expectedCount) == actualCount;
        }

        // Cart symbol click
        public void CartClick()
        {
            driver_helper.ClickElement(driver, CartSymbol);
        }
    }
}