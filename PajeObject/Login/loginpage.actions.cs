using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V126.DOM;
using OpenQA.Selenium.DevTools.V126.Network;
using Utilities;

namespace PageObject.Login
{
   public partial class LoginPage : Exception
    {
       private readonly IWebDriver driver;
        private readonly IJavaScriptExecutor jsExecutor;
        
        public LoginPage(IWebDriver driver, IJavaScriptExecutor jsExecutor)
        {
            this.driver = driver;
            this.jsExecutor = (IJavaScriptExecutor)driver;

        }

        public void EnterUsername(string Username)
        {
           // driver.FindElement(UsernameFiled).SendKeys(Username);
            driver_helper.SendData(driver, UsernameFiled, Username);
            
        }

        public void EnterPassword(string Password)
        {
            //driver.FindElement(PasswordField).SendKeys(Password);
            driver_helper.SendData(driver, PasswordField, Password);
        }

        public void LoginButton()
        {
           // driver.FindElement(LoginFiled).Click();
            driver_helper.ClickElement(driver, LoginFiled);
        }


        public bool HomePageValidation()
        {
            try
            {
                //var ans = driver.FindElement(Homepageindicator).Text;
                var ans = driver_helper.GetText(driver, Homepageindicator);
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

        public void ThreeDots()
        {
            //driver.FindElement(threedots).Click();
            driver_helper.ClickElement(driver, threedots);
            Thread.Sleep(2000);
        }


        public void Logout()
        {
            Thread.Sleep(2000);
            jsExecutor.ExecuteScript(logoutScript);
            Thread.Sleep(2000);
        }

    }
}
