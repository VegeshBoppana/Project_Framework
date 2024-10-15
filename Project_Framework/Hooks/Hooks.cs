using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using BoDi;
using System;
using System.IO;
using Utilities;
using Utilities.Reports;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using TechTalk.SpecFlow;

[Binding]
public class Hooks : ExtReoprt
{
    private readonly IObjectContainer _container;
    private static FeatureContext _featureContext;
    private ScenarioContext _scenarioContext;

    public Hooks(IObjectContainer container, ScenarioContext scenarioContext, FeatureContext featureContext)
    {
        _container = container;
        _scenarioContext = scenarioContext;
        _featureContext = featureContext;
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

    [BeforeScenario(Order = 0)]
    public void FirstBeforeScenario(ScenarioContext scenarioContext)
    {
        _scenario = _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
    }

    [BeforeScenario(Order = 1)]
    public void InitializeWebDriver()
    {
        ChromeOptions options = ChromeOptionHelpers.GetIncognitoOptions();
        IWebDriver driver = new ChromeDriver(options);
        driver.Manage().Window.Maximize();
        _container.RegisterInstanceAs<IWebDriver>(driver);
        driver.Navigate().GoToUrl("https://www.google.com");
    }

    [BeforeFeature(Order = 0)]
    public static void CleanScreenShotFolder()
    {
        string path = "C:\\Users\\vegeshsai_boppana\\source\\repos\\Project_Framework\\Project_Framework\\Screenshots\\";
        ScreenshotHelper.DeleteFilesInFolder(path);
    }

    [AfterScenario]
    public void AfterScenario()
    {
        var driver = _container.Resolve<IWebDriver>();  // Resolve WebDriver instance from container
        if (driver != null)
        {
            driver.Quit();  // Quit the WebDriver and close the browser
        }
    }

    [AfterStep]
    public void InsertReportingSteps()
    {
        var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

        if (_scenarioContext.TestError == null)
        {
            // If no error, log the step as passed in the report
            if (stepType == "Given")
                _scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
            else if (stepType == "When")
                _scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
            else if (stepType == "Then")
                _scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
            else if (stepType == "And")
                _scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
        }
        else if (_scenarioContext.TestError != null)
        {
            // If there's an error, log the step as failed in the report
            if (stepType == "Given")
                _scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(_scenarioContext.TestError.InnerException);
            else if (stepType == "When")
                _scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(_scenarioContext.TestError.InnerException);
            else if (stepType == "Then")
                _scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(_scenarioContext.TestError.InnerException);
            else if (stepType == "And")
                _scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(_scenarioContext.TestError.Message);
        }
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