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
using PajeObject.DemoQa;
using System.Xml.Linq;

namespace AProject_Framework.StepDefinitions
{
    [Binding]
    

    public sealed class TheDemoQAWebsiteStepDefinitions
    {
        private readonly IWebDriver driver;
        private readonly  demoqa_action demoobj;

        public TheDemoQAWebsiteStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            demoobj = new demoqa_action(driver, jsExecutor);
        }



        [Given(@"the user has navigated to the DemoQA  Page")]
        public void GivenTheUserHasNavigatedToTheDemoQAPage()
        {
            driver_helper.GoToPage(driver, "https://demoqa.com/");
            Thread.Sleep(1000);
        }

        [Given(@"the user has navigated to the DemoQA Buttons Page")]
        public void GivenTheUserHasNavigatedToTheDemoQAButtonsPage()
        {
            demoobj.GoToElements();
            demoobj.GoToButtons();

        }

        [When(@"the user double-clicks on the Double-Click-Me button")]
        public void WhenTheUserDouble_ClicksOnTheButton()
        {

            Thread.Sleep(5000);
            
            demoobj.DoubleClickMeButton();
            Thread.Sleep(5000);

        }

        [Then(@"an output should display with the message ""([^""]*)""")]
        public void ThenAnOutputShouldDisplayWithTheMessage(string text)
        {
            //var result = demoobj.DoubleClickButtonText(text);
            //Console.WriteLine("here we go:");
            //Console.WriteLine(result);

            if (text.Contains("Double"))
            {
                bool result = demoobj.DoubleClickButtonText(text);
                if (result is true)
                {
                    Assert.Pass();
                }
                else
                {
                    Assert.Fail();
                }
            }
            if (text.Contains("Right"))
            {
                bool result = demoobj.RightClickButtonText(text);
                if (result is true)
                {

                    Assert.Pass();
                }
                else
                {
                    Assert.Fail();
                }
            }
        }

        [When(@"the user right-clicks on the Right-Click-Mee button")]
        public void WhenTheUserRight_ClicksOnTheRight_Click_MeeButton()
        {
            demoobj.RightClickMeButton();
            Thread.Sleep(5000);
        }


        [Given(@"user is on the Checkbox page")]
        public void GivenUserIsOnTheCheckboxPage()
        {
            demoobj.GoToElements();
            demoobj.CheckBoxPageSelection();
        }

        [When(@"user clicks on the Home square box")]
        public void WhenUserClicksOnTheHomeSquareBox()
        {
           demoobj.HomeCheckBoxSelection();
        }

        [Then(@"All the Checjbox should get selected")]
        public void ThenAllTheChecjboxShouldGetSelected()
        {
            demoobj.ToggleArrowSelection();
            Thread.Sleep(5000);
        }





        [Given(@"User is on the Radio Button Page")]
        public void GivenUserIsOnTheRadioButtonPage()
        {
            demoobj.GoToElements();
            demoobj.GoToRadioPage();

        }

        [When(@"User Selects the enabled Radio Buttons")]
        public void WhenUserSelectsTheEnabledRadioButtons()
        {

            demoobj.SelectImpressiveButton();
            Thread.Sleep(2000);
            demoobj.SelectYesButton();

           
            
            demoobj.SelectNoButton();
           
        }

        [Then(@"User see the corresponding output")]
        public void ThenUserSeeTheCorrespondingOutput()
        {
            Thread.Sleep(5000);
        }





        
        [Given(@"User is on the Select_Menu Page")]
        public void GivenUserIsOnTheSelect_MenuPage()
        {
            demoobj.GoToMenuPage();
        }


        [When(@"User retrieves and prints all dropdown options")]
        public void WhenUserRetrievesAndPrintsAllDropdownOptions()
        {
            demoobj.PrintOptions();
        }

        [Then(@"User should seee all the options listed")]
        public void ThenUserShouldSeeeAllTheOptionsListed()
        {
            Console.WriteLine("we saw all the options");
        }





        [When(@"User selects the option with value ""([^""]*)""")]
        public void WhenUserSelectsTheOptionWithValue(string value)
        {
            demoobj.ValueSelection(value);
            Thread.Sleep(5000);
        }

        [Then(@"User should seee ""([^""]*)"" as the selected value")]
        public void ThenUserShouldSeeeAsTheSelectedValue(string p0)
        {
            Thread.Sleep(3000);
        }


        [When(@"User selects the option with the value ""([^""]*)""")]
        public void WhenUserSelectsTheOptionWithTheValue(string green)
        {
            demoobj.TextSelection(green);
            Thread.Sleep(5000);
        }

        [Then(@"User should seee ""([^""]*)"" as the Selected value")]
        public void ThenUserShouldSeeeeAsTheSelectedValue(string green)
        {
            Thread.Sleep(2000);
        }


    }
}
