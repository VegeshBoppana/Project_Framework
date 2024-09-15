using Microsoft.Extensions.Options;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class ChromeOptionHelpers
    {
        public static ChromeOptions GetIncognitoOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            return options;
        }
    }
}
