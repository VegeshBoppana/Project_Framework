//using Microsoft.Extensions.Configuration;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Utilities
//{
//    public static class ConfigReader
//    {
//        private static IConfigurationRoot configuration;

//        static ConfigReader()
//        {
//            var builder = new ConfigurationBuilder()
//                .SetBasePath(Directory.GetCurrentDirectory()) // Set base path
//                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true); // Load appsettings.json
//            configuration = builder.Build();
//        }

//        public static string GetBrowser()
//        {
//            return configuration["Browser"];
//        }

//        public static string GetBaseUrl()
//        {
//            return configuration["BaseUrl"];
//        }

//        public static int GetImplicitWait()
//        {
//            return int.Parse(configuration["Timeouts:ImplicitWait"]);
//        }

//        public static int GetExplicitWait()
//        {
//            return int.Parse(configuration["Timeouts:ExplicitWait"]);
//        }

//        public static string GetUsername()
//        {
//            return configuration["Credentials:Username"];
//        }

//        public static string GetPassword()
//        {
//            return configuration["Credentials:Password"];
//        }
//    }
//}
