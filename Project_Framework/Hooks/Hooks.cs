using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using BoDi;  
using System;
using System.IO;
using Utilities;
using Utilities.Reports;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;

[Binding]
public class Hooks : ExtReoprt
{
    private readonly IObjectContainer _container;

    public Hooks(IObjectContainer container)
    {
        _container = container;
    }


   
    [BeforeTestRun]
    public static void BeforeTestRun()
    {
        ExtReoprt.ExtentReportInit();
    }

    [AfterTestRun]
    public static void AfterTestRun()
    {
        ExtReoprt.ExtentReportTearDown();
    }


   


    [BeforeFeature]
    public static void BeforeFeature(FeatureContext featureContext)
    {
        _feature = _extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title);
    }



    [BeforeScenario]
    public static void FirstBeforeScenario(ScenarioContext scenarioContext)
    {
        _scenario = _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
    }





    [BeforeScenario]
    public void InitializeWebDriver()
    {
        ChromeOptions options = ChromeOptionHelpers.GetIncognitoOptions();
        IWebDriver driver = new ChromeDriver(options);
        driver.Manage().Window.Maximize();
        _container.RegisterInstanceAs<IWebDriver>(driver);
        driver.Navigate().GoToUrl("https://www.google.com");

    }

    [BeforeFeature]
    //deleting the files in the screenshot folder

    public static void cleanScreenShotFolder()
    {
        string path = "C:\\Users\\vegeshsai_boppana\\source\\repos\\Project_Framework\\Project_Framework\\Screenshots\\";

        ScreenshotHelper.DeleteFilesInFolder(path);
    }




    [AfterScenario]
    public void QuitDriver()
    {
        var driver = _container.Resolve<IWebDriver>();  // Resolve WebDriver instance from container
        if (driver != null)
        {

            driver.Quit();  // Quit the WebDriver and close the browser
        }
    }
}