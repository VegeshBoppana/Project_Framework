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
using System.Diagnostics;

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


        [When(@"User selects the option with the value (.*)")]
        public void WhenUserSelectsTheOptionWithTheValue(int index)
        {
            demoobj.IndexSelection(index);
        }



        [When(@"User selects the option with valuee ""([^""]*)""")]
        public void WhenUserSelectsTheOptionWithValuee(string value)
        {
            demoobj.ValueSelection(value);
            Thread.Sleep(5000);
        }

        [Then(@"User should seee ""([^""]*)"" as the selected value")]
        public void ThenUserShouldSeeeAsTheSelectedValue(string p0)
        {
            Thread.Sleep(3000);
        }


        [When(@"User selects the option with the valuee ""([^""]*)""")]
        public void WhenUserSelectsTheOptionWithTheValuee(string green)
        {
            demoobj.TextSelection(green);
            Thread.Sleep(5000);
        }

       


        [Then(@"User should seeee ""([^""]*)"" as the Selected value")]
        public void ThenUserShouldSeeeeAsTheSelectedValue(string green)
        {
            Thread.Sleep(3000);
        }



        [Given(@"User is on the WindowHandles Page")]
        public void GivenUserIsOnTheWindowHandlesPage()
        {
            demoobj.GoToBrowserWindows();
        }

        [When(@"User clicks on the NewTab")]
        public void WhenUserClicksOnTheNewTab()
        {
            demoobj.ClickNewTabButton();
        }

        [Then(@"User should print the content in the new tab")]
        public void ThenUserShouldPrintTheContentInTheNewTab()
        {
            demoobj.ShiftToNewTab();
        }

        [When(@"the user clicks on the NewWindow")]
        public void WhenTheUserClicksOnTheNewWindow()
        {
            demoobj.ClickNewWindowButton();
        }

        [Then(@"User should print the content in the new Window")]
        public void ThenUserShouldPrintTheContentInTheNewWindow()
        {
            demoobj.ShiftToNewWindow();
        }



        [When(@"the user clicks on the New Window Message")]
        public void WhenTheUserClicksOnTheNewWindowMessage()
        {
            demoobj.ClickNewWindowMessageButton();
        }

        [Then(@"User should print the content in the new Window message")]
        public void ThenUserShouldPrintTheContentInTheNewWindowMessage()
        {
            demoobj.ShiftToNewWindowMessage();
        }




        [Given(@"the user is on the Alerts Page")]
        public void GivenTheUserIsOnTheAlertsPage()
        {
           demoobj.GotToAlertsPage();
        }

        [When(@"the user clicks on the first Click Me button")]
        public void WhenTheUserClicksOnTheFirstClickMeButton()
        {
            demoobj.ClickMeeButton();
        }

        [Then(@"an alert should be displayed")]
        public void ThenAnAlertShouldBeDisplayed()
        {
            Thread.Sleep(1500);
        }

        [Then(@"the user clicks OK on the alert")]
        public void ThenTheUserClicksOKOnTheAlert()
        {
            demoobj.AlertForClickMEButton();
        }


        [When(@"the user clicks on the second Click Me")]
        public void WhenTheUserClicksOnTheSecondClickMe()
        {
            demoobj.ClickTimerAlertButton();
        }

        [Then(@"the user should see an alert after (.*) seconds")]
        public void ThenTheUserShouldSeeAnAlertAfterSeconds(int p0)
        {
            demoobj.AlertForTimerAlertButton();
        }




        [When(@"the user clicks on the confirm box")]
        public void WhenTheUserClicksOnTheConfirmBox()
        {
            demoobj.ClickConfirmButton();
        }

        [Then(@"an alert with OK and Cancel options should be displayed")]
        public void ThenAnAlertWithOKAndCancelOptionsShouldBeDisplayed()
        {
            Thread.Sleep(1000);
        }

        [When(@"the user clicks on OK")]
        public void WhenTheUserClicksOnOK()
        {
            demoobj.AlertForConfirmButtonAccept();
        }

        [Then(@"the output ""([^""]*)"" should be displayed")]
        public void ThenTheOutputShouldBeDisplayed(string p0)
        {
            bool ans = demoobj.OutputConfirmation(p0);  
            if(ans is true)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }




        [When(@"the user clicks on Cancel")]
        public void WhenTheUserClicksOnCancel()
        {
            demoobj.AlertForConfirmButtonCacel();
        }




        [When(@"the user clicks on the prompt button")]
        public void WhenTheUserClicksOnThePromptButton()
        {
            demoobj.ClickPromptButton();
        }

        [Then(@"an alert with a field to enter the name should be displayed")]
        public void ThenAnAlertWithAFieldToEnterTheNameShouldBeDisplayed()
        {
            Thread.Sleep(1000);
        }

        [When(@"the user enters the name ""([^""]*)""")]
        public void WhenTheUserEntersTheName(string vegesh)
        {
            demoobj.AlertForPromptButton(vegesh);
            Thread.Sleep(2000);
        }

        [When(@"the user clicks OK")]
        public void WhenTheUserClicksOK()
        {
            demoobj.ClickConfirmButton();
        }





        [Given(@"the user is in the Progress Bar")]
        public void GivenTheUserIsInTheProgressBar()
        {
            demoobj.GoToProgressPage();
        }

        [When(@"the user clicks on the srtat the progress bar starts moving")]
        public void WhenTheUserClicksOnTheSrtatTheProgressBarStartsMoving()
        {
            demoobj.ClickProgressBar();
        }

        [Then(@"the user should see reset after sometime and clicks on it")]
        public void ThenTheUserShouldSeeResetAfterSometimeAndClicksOnIt()
        {
            demoobj.ClickResetProgressBar();
        }




        [Given(@"the user in the frames page")]
        public void GivenTheUserInTheFramesPage()
        {
            demoobj.GoToFrameWebsite();
        }


        [When(@"User shifts from default content to frameone")]
        public void WhenUserShiftsFromDefaultContentToFrameone()
        {
            demoobj.GoToFrameOne();
        }

        [Then(@"user should print the data in it")]
        public void ThenUserShouldPrintTheDataInIt()
        {
            demoobj.PrintContentinFrameOne();
        }




        [Given(@"the user is in the frames page and in frameone")]
        public void GivenTheUserIsInTheFramesPageAndInFrameone()
        {
            demoobj.GoToFrameWebsite();
            demoobj.GoToFrameOne();

        }
        

        [When(@"user shifts from frameone to frametwo")]
        public void WhenUserShiftsFromFrameoneToFrametwo()
        {
           demoobj.GoToMainPage();
            demoobj.GoToFrameTwo();
        }

        [Then(@"user should print the data in the frametwo")]
        public void ThenUserShouldPrintTheDataInTheFrametwo()
        {
            demoobj.PrintContentinFrameTwo();
        }



        [Given(@"User is in the framertwo")]
        public void GivenUserIsInTheFramertwo()
        {
            demoobj.GoToFrameWebsite();
            demoobj.GoToFrameOne();
        }

        [When(@"user user moves frame to main page")]
        public void WhenUserUserMovesFrameToMainPage()
        {
            demoobj.GoToMainPage();
        }

        [Then(@"User should print the data in the main page")]
        public void ThenUserShouldPrintTheDataInTheMainPage()
        {
            demoobj.PrintMainPageContent();
        }

    }
}