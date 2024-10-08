﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PajeObject.DemoQa
{
    public partial class demoqa_action
    {
        protected By Elements => By.XPath("//div[@class = 'card mt-4 top-card'][1]");

        protected By Buttons => By.XPath("//span[contains(text(),'Buttons')]");

        protected By DoubleClickMe => By.XPath("//button[@id='doubleClickBtn']");

        protected By DoubleClickMessage => By.XPath("//p[@id ='doubleClickMessage']");


        protected By RightClikcButton => By.XPath("//button[@id='rightClickBtn']");

        protected By RightClickMessage => By.XPath("//p[@id = 'rightClickMessage']");

        protected By Checkboxpage => By.XPath("//span[contains(text(),'Check Box')]");

        protected By HomeCheckBox => By.XPath("//span[@class='rct-checkbox']");

        protected By ToggleArrow => By.XPath("//button[@aria-label='Toggle']");

        protected By RadioButtonPage => By.XPath("//span[contains(text(),'Radio Button')]");

        protected By yesRadio => By.XPath("//input[@id='yesRadio']");
        protected string JSEyesRadio = "document.getElementById('yesRadio').click();";

        protected By NoRadio => By.Id("noRadio");
        public string JSENoRadio = "document.getElementById('noRadio').click();";

        protected By impressiveRadio => By.Id("impressiveRadio");
        protected string JSEimpresseiveRadio = "document.getElementById('impressiveRadio').click();";



        protected string SelectMenuPageUrl = "https://demoqa.com/select-menu";

        protected By Old_Style_Menu => By.Id("oldSelectMenu");


        protected string BrowserWindows = "https://demoqa.com/browser-windows";


        protected By NewTabButton => By.XPath("//button[@id = 'tabButton']");
        protected By NewTabContent => By.XPath("//h1[@id = 'sampleHeading']");
        protected By NewWindowButton => By.XPath("//button[@id = 'windowButton']");
        protected By NewWindowMessage => By.XPath("//h1[@id = 'sampleHeading']");

        protected By NewWindowMessageButton => By.XPath("//button[@id = 'messageWindowButton']");
        protected By NewWindowMessageButtonMessage => By.TagName("//body");

        protected string alertspage = "https://demoqa.com/alerts";

        protected By ClickMeButton => By.XPath("//button[@id = 'alertButton']");

        protected By TimerAlertButton => By.XPath("//button[@id = 'timerAlertButton']");

        protected By ConfirmButton => By.XPath("//button[@id = 'confirmButton']");

        protected By Outputgenerated => By.XPath("//span[@id = 'confirmResult']");

        protected By PromptButton => By.XPath("//button[@id = 'promtButton']");





        protected string progrssbarpage = "https://demoqa.com/progress-bar";    
        protected By progressstartbutton => By.XPath("//button[@id = 'startStopButton']");
        protected By resetprogressbutton => By.XPath("//button[@id = 'resetButton']");



        protected By frameone => By.XPath("//iframe[@id = 'frame1']");

        protected By frametwo => By.XPath("//iframe[@id = 'frame2']");

        protected By MainContent => By.XPath("//div[@id = 'framesWrapper']");
    }
}
