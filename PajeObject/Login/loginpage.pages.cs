using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PageObject.Login
{
    public partial class LoginPage
    {
        protected By UsernameFiled => By.Id("user-name");
        protected By PasswordField => By.Id("password");
        protected By LoginFiled => By.Id("login-button");
        protected By Homepageindicator => By.XPath("//div[text()='Products']");
        protected By threedots => By.XPath("//button[text()='Open Menu']");
        string logoutScript = "document.querySelector('a[href=\"./index.html\"]').click();";

       
        
    }
}
