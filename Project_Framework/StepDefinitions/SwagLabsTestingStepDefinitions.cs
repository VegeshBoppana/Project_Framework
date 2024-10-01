using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObject.Login;
using System;
using TechTalk.SpecFlow;
using CsvHelper;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using PajeObject.Product;
using System.Security.Cryptography;
using NUnit.Framework;
using PajeObject.CheckOut;
using AProject_Framework.Utilities;
using OpenQA.Selenium.DevTools.V126.DOM;
using TechTalk.SpecFlow.CommonModels;
using OpenQA.Selenium.DevTools.V126.HeapProfiler;
using BoDi;
using Utilities;

namespace AProject_Framework.StepDefinitions
{
    [Binding]
    public sealed class SwagLabsTestingStepDefinitions
    {
        private readonly IWebDriver driver;
        private readonly LoginPage objname;
        private readonly productpage pobj;
        private IEnumerable<dynamic>? _userData;
        private readonly checkout checkobj;
        // private readonly IObjectContainer _container;
        private readonly ScenarioContext _scenarioContext;
        


        public SwagLabsTestingStepDefinitions(IWebDriver driver, ScenarioContext scenarioContext)
        {

            //driver = _container.Resolve<IWebDriver>();
            this.driver = driver;
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            objname = new LoginPage(driver, jsExecutor);
            checkobj = new checkout(driver, jsExecutor);
            pobj = new productpage(driver, jsExecutor);
            _scenarioContext = scenarioContext;
            

        }


        private IEnumerable<dynamic> LoadCsvData(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                return csv.GetRecords<dynamic>().ToList();
            }
        }

        [Given(@"User is in the login Page")]
        public void GivenUserIsInTheLoginPage()
        {
            driver_helper.GoToPage(driver, "https://www.saucedemo.com/v1/index.html");
        }

        [When(@"User enter a valid username and password from '([^']*)' file")]
        public void WhenIEnterAValidUsernameAndPasswordFromFile(string csvFileName)
        {
            string filePath = "C:\\Users\\vegeshsai_boppana\\source\\repos\\UIFramework\\Project_Framework\\Project_Framework\\TestFolder\\data.csv";
            _userData = LoadCsvData(filePath);

            foreach (var user in _userData)
            {
                // Clear existing fields to avoid contamination
                objname.EnterUsername(""); // Assuming you have a method to clear the username field
                objname.EnterPassword(""); // Assuming you have a method to clear the password field

                objname.EnterUsername(user.Username);
                objname.EnterPassword(user.Password);

                objname.LoginButton();

                // Verify if the login was successful
                // Assuming a method to check if login was successful
                if (objname.HomePageValidation() == true)
                {
                    // Perform additional actions like logging out, if needed
                    objname.ThreeDots();
                    objname.Logout();
                    Thread.Sleep(1000);
                }
                else
                {
                    //take the screenshot method
                    // continue with next test cases

                    driver_helper.GoToPage(driver, "https://www.saucedemo.com/v1/index.html");


                }

                // Optional: Add a short delay between test cases
                Thread.Sleep(1000); // 1 second delay
            }
        }

        [Then(@"User should go to the Product Page")]
        public void ThenUserShouldGoToTheProductPage()
        {
            // This method might not be necessary if you're already handling navigation in the When step
            // Or, you could add validation logic here if needed
        }



        // the object name here is pobj
        [Given(@"User is in the Product Page")]
        public void GivenUserIsInTheProductPage()
        {
            driver_helper.GoToPage(driver, "https://www.saucedemo.com/v1/inventory.html");

        }

        [When(@"User adds the following products:")]
        public void WhenUserAddsTheFollowingProducts(Table table)
        {
            int count = 0;

            // Access the values from the scenario outline example dynamically
            var row = table.Rows[0];  // There is only one row of product data in the example

            foreach (var key in row.Keys)
            {
                if (row[key] == "1")
                {
                    switch (key)
                    {
                        case "Sauce Labs Backpac":
                            pobj.BackPack();
                            count++;
                            break;
                        case "Bike Light":
                            pobj.BikeLight();
                            count++;
                            break;
                        case "T-Shirt":
                            pobj.BoltTShirt();
                            count++;
                            break;
                        case "FleeceJacket":
                            pobj.Fleece();
                            count++;
                            break;
                        case "Onesie":
                            pobj.Onesie();
                            count++;
                            break;
                        case "RedShirt":
                            pobj.RedShirt();
                            count++;
                            break;
                        default:
                            // Optionally handle case where the product is not recognized
                            break;
                    }
                }
            }

            // Store the total count
            _scenarioContext["ProductCount"] = count; ;
        }


        [Then(@"Count on the cart should display (.*)")]
        public void ThenCountOnTheCartShouldDisplay(int ExpectedCount)
        {
            int ActualCount = (int)_scenarioContext["ProductCount"];
            Assert.AreEqual(ExpectedCount, ActualCount, $"Expect Count is {ExpectedCount}and Count we got is {ActualCount}");
        }




        // here the objanme is checkobj


        [Given(@"User Clicks on the Cart Symbol after adding few items")]
        public void GivenUserClicksOnTheCartSymbolAfterAddingFewItems()
        {
            driver_helper.GoToPage(driver, "https://www.saucedemo.com/v1/inventory.html");
            pobj.BackPack();
            pobj.BikeLight();
            pobj.BoltTShirt();
            pobj.Fleece();
            pobj.Onesie();
            pobj.RedShirt();
            Thread.Sleep(2000);
            pobj.CartClick();
            Thread.Sleep(2000);
        }


        [When(@"User Clicks on Continue Shopping")]
        public void WhenUserClicksOnContinueShopping()
        {
            checkobj.continueshopping();
        }

        [Then(@"User Should go to Products Page")]
        public void ThenUserShouldGoToProductsPage()
        {
            Thread.Sleep(3000);
            bool expectedans = true;
            bool actaulans = checkobj.HomePageValidation();
            Assert.AreEqual(actaulans, expectedans, $"the expected ans is {expectedans} and our ans is {actaulans}");
        }


        [Given(@"User is in the cart page")]
        public void GivenUserIsInTheCartPage()
        {
            driver_helper.GoToPage(driver, "https://www.saucedemo.com/v1/inventory.html");
            pobj.BackPack();
            pobj.BikeLight();
            pobj.BoltTShirt();
            pobj.Fleece();
            pobj.Onesie();
            pobj.RedShirt();
            Thread.Sleep(2000);
            pobj.CartClick();
            Thread.Sleep(2000);
        }

        [When(@"user Clicks on the Checkout")]
        public void WhenUserClicksOnTheCheckout()
        {
            checkobj.CheckOut();
        }

        [Then(@"user should got to the stepOne functionality page")]
        public void ThenUserShouldGotToTheStepOneFunctionalityPage()
        {
            Thread.Sleep(3000);
            bool expectedans = true;
            bool actaulans = checkobj.CheckOutStepOneHeading();
            Assert.AreEqual(actaulans, expectedans, $"the expected ans is {expectedans} and our ans is {actaulans}");
        }



        // Given step remains the same
        [Given(@"user is on the Your Information Page")]
        public void GivenuserisontheYourInformationPage()
        {
            driver_helper.GoToPage(driver, "https://www.saucedemo.com/v1/checkout-step-one.html");
        }

        [When(@"user enters the following details and clicks on continue ""([^""]*)""  ""([^""]*)"" ""([^""]*)""")]
        public void WhenUserEntersTheFollowingDetailsAndClicksOnContinue(string p0, string p1, string p2)
        {
            checkobj.EnterFirstName(p0);
            checkobj.EnterLastName(p1);  // Corrected here
            checkobj.EnterZipCode(p2);
            checkobj.S1Continue();
            string titlename = checkobj.GetTitleName();  // Ensure this gets the correct title
            Console.WriteLine(titlename);  // Print the title for debugging

            _scenarioContext["TitleName"] = titlename; // Set value
                                                       // Store in ScenarioContext
        }



        // Then step with correct usage of ScenarioContext
        [Then(@"User should see (.*)")]
        public void ThenUserShouldSeeExpectedResult(string ExpectedResult)
        {
            string titlename = _scenarioContext.Get<string>("TitleName");
            // Retrieve stored value
            Console.WriteLine(titlename);  // Print title for debugging
            Console.WriteLine(ExpectedResult);
            if (titlename == ExpectedResult)
            {

                Assert.Pass();
            }
            else
            {
                // we can also pass the filepath if we want just change littlebit in the helper class
                ScreenshotHelper.TakeScreenshot(driver);
                Assert.Fail($"Expected: {ExpectedResult}, but got: {titlename}");
                // call the scrennshot method
                
            }
        }

    }
}

