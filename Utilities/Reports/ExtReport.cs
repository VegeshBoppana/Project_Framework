using AventStack.ExtentReports.Reporter.Configuration;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Reports
{
    public  class ExtReoprt
    {
        public static ExtentReports _extentReports;
        public static ExtentTest _feature;
        public static ExtentTest _scenario;
        public static String dir = AppDomain.CurrentDomain.BaseDirectory;
        public static String test = "C:\\Users\\vegeshsai_boppana\\source\\repos\\UIFramework\\Project_Framework\\Project_Framework\\TestReports\\";

        public static void ExtentReportInit()
        {
            var htmlReporter = new ExtentHtmlReporter(test);
            htmlReporter.Config.ReportName = "Automation Status Report";
            htmlReporter.Config.DocumentTitle = "Automation Status Report";
            htmlReporter.Config.Theme = Theme.Standard;
            htmlReporter.Start();
            _extentReports = new ExtentReports();
            _extentReports.AttachReporter(htmlReporter);
        }
        public static void ExtentReportTearDown()
        {
            _extentReports.Flush();
        }
    }
}
