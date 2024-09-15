using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            if(ans == text)
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
            IWebElement yesradiores = driver_helper.FindElementSafe(driver,yesRadio);

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

    }
}
