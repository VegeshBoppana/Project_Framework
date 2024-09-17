using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Utilities;

namespace PajeObject.DemoQa
{
    public partial class demoqa_action
    {

        private readonly IWebDriver driver;
        private IJavaScriptExecutor jsExecutor;

        public demoqa_action(IWebDriver driver, IJavaScriptExecutor jsExecutor)
        {
            this.driver = driver;
            this.jsExecutor = jsExecutor;
        }


        public void GoToElements()
        {
            driver_helper.ClickElement(driver, Elements);
        }

        public void GoToButtons()
        {
            driver_helper.ClickElement(driver, Buttons);
        }
        public void DoubleClickMeButton()
        {
            Action_Helper.DoubleClick(driver, DoubleClickMe);
        }

        public bool DoubleClickButtonText(string text)
        {

            string ans = driver_helper.GetText(driver, DoubleClickMessage);
            if (ans == text)
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        public void RightClickMeButton()
        {
            Action_Helper.DoubleClick(driver, RightClikcButton);
        }


        public bool RightClickButtonText(string text)
        {

            string ans = driver_helper.GetText(driver, RightClickMessage);
            if (ans == text)
            {
                return true;
            }
            return false;
        }

        public void CheckBoxPageSelection()
        {
            driver_helper.ClickElement(driver, Checkboxpage);
        }

        public void HomeCheckBoxSelection()
        {
            driver_helper.ClickElement(driver, HomeCheckBox);
        }

        public void ToggleArrowSelection()
        {
            driver_helper.ClickElement(driver, ToggleArrow);
        }




        public void GoToRadioPage()
        {
            driver_helper.ClickElement(driver, RadioButtonPage);
        }
        public void SelectYesButton()
        {
            IWebElement yesradiores = driver_helper.FindElementSafe(driver, yesRadio);

            if (yesradiores.Enabled)
            {
                jsExecutor.ExecuteScript(JSEyesRadio);
                Console.WriteLine("Yes Radio button is enabled and clicked.");
            }
            else
            {
                Console.WriteLine("It is not enabled");
            }
        }

        public void SelectImpressiveButton()
        {

            IWebElement impressiveRadiores = driver_helper.FindElementSafe(driver, impressiveRadio);

            if (impressiveRadiores.Enabled)
            {
                jsExecutor.ExecuteScript(JSEimpresseiveRadio);
                Console.WriteLine("Impressive Radio button is enabled and clicked.");
            }
            else
            {
                Console.WriteLine("It is not enabled");
            }

        }

        public void SelectNoButton()
        {

            IWebElement NoRadiores = driver_helper.FindElementSafe(driver, NoRadio);

            if (NoRadiores.Enabled)
            {
                jsExecutor.ExecuteScript(JSENoRadio);
                Console.WriteLine("No Radio button is enabled and clicked.");
            }
            else
            {
                Console.WriteLine("It is not enabled");
            }

        }


        public void GoToMenuPage()
        {
            driver_helper.GoToPage(driver, SelectMenuPageUrl);

        }

        public void PrintOptions()
        {
            Console.WriteLine("Print options action invoked");
            SelectUtilities.PrintOptions(driver.FindElement(Old_Style_Menu));  // Now directly uses the dropdown element
        }

        public void IndexSelection(int index)
        {
            Console.WriteLine("Index selection action invoked");
            SelectUtilities.SelectByIndex(driver.FindElement(Old_Style_Menu), index);  // Uses the dropdown element
        }

        public void TextSelection(string text)
        {
            Console.WriteLine("Text selection action invoked");
            SelectUtilities.SelectByText(driver.FindElement(Old_Style_Menu), text);  // Uses the dropdown element
        }

        public void ValueSelection(string value)
        {
            Console.WriteLine("Value selection action invoked");
            SelectUtilities.SelectByValue(driver.FindElement(Old_Style_Menu), value);  // Uses the dropdown element
        }



        public void GoToBrowserWindows()
        {
            driver_helper.GoToPage(driver, BrowserWindows);
        }

        public void ClickNewTabButton()
        {
            driver_helper.ClickElement(driver, NewTabButton);
        }

        public void ShiftToNewTab()
        {
            WindowFrameAlertUtilities.SwitchToNewTab(driver);
            string text = driver_helper.GetText(driver, NewTabContent);
            Console.WriteLine(text);
            Thread.Sleep(2000);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }

        public void ClickNewWindowButton()
        {
            driver_helper.ClickElement(driver, NewWindowButton);

        }

        public void ShiftToNewWindow()
        {
            WindowFrameAlertUtilities.SwitchToNewWindow(driver);
            string text = driver_helper.GetText(driver, NewWindowMessage);
            Console.WriteLine(text);
            Thread.Sleep(2000);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }

        public void ClickNewWindowMessageButton()
        {
            driver_helper.ClickElement(driver, NewWindowMessageButton);
        }

        public void ShiftToNewWindowMessage()
        {
            WindowFrameAlertUtilities.SwitchToNewWindow(driver);
            string text = driver_helper.GetText(driver, NewWindowMessageButtonMessage);
            Console.WriteLine(text);
            Thread.Sleep(2000);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }


        public void GotToAlertsPage()
        {
            driver_helper.GoToPage(driver, alertspage);
        }

        public void ClickMeeButton()
        {
            driver_helper.ClickElement(driver, ClickMeButton);
        }

        public void AlertForClickMEButton()
        {
            WindowFrameAlertUtilities.HandleAlert(driver);
        }

        public void ClickTimerAlertButton()
        {
            driver_helper.ClickElement(driver, TimerAlertButton);
        }

        public void AlertForTimerAlertButton()
        {
            Thread.Sleep(6000);
            WindowFrameAlertUtilities.HandleAlert(driver);
        }

        public void ClickConfirmButton()
        {
            driver_helper.ClickElement(driver, ConfirmButton);
        }




        public void AlertForConfirmButtonAccept()
        {
            WindowFrameAlertUtilities.HandleAlert(driver);
        }


        public bool OutputConfirmation(string message)
        {
            string ans = driver_helper.GetText(driver, Outputgenerated);
            Console.WriteLine(ans);
            Console.WriteLine("here");
            if (ans == message)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AlertForConfirmButtonCacel()
        {
            WindowFrameAlertUtilities.CancelAlert(driver);
        }

        public void ClickPromptButton()
        {
            driver_helper.ClickElement(driver, PromptButton);
        }

        public void AlertForPromptButton(string input)
        {
            WindowFrameAlertUtilities.promptBoxAlert(driver, input);

        }



        public void GoToProgressPage()
        {
            driver_helper.GoToPage(driver, "https://demoqa.com/progress-bar");
        }

        public void ClickProgressBar()
        {
            driver_helper.ClickElement(driver, progressstartbutton);

        }


        public void ClickResetProgressBar()
        {

            waithelper.FluentWait(driver, TimeSpan.FromSeconds(30), TimeSpan.FromSeconds(3), resetprogressbutton).Click();

        }


        public void GoToFrameWebsite()
        {
            driver_helper.GoToPage(driver, "https://demoqa.com/frames");

        }
        public void GoToFrameOne()
        {
            WindowFrameAlertUtilities.SwitchToFrameByName(driver, "frame1");
        }

        public void PrintContentinFrameOne()
        {
           var ans =  driver_helper.GetText(driver, NewTabContent);
            Console.WriteLine(ans);
        }

        public void GoToFrameTwo()
        {
            WindowFrameAlertUtilities.SwitchToFrameByName(driver, "frame2");
        }

        public void PrintContentinFrameTwo()
        {
            var ans = driver_helper.GetText(driver, NewTabContent);
            Console.WriteLine(ans);
        }


        public void GoToMainPage()
        {
            WindowFrameAlertUtilities.SwitchToDefaultContent(driver);
        }

        public void PrintMainPageContent()
        {
           var ans = driver_helper.GetText(driver, MainContent);  
            Console.WriteLine(ans);
        }
    }
}
