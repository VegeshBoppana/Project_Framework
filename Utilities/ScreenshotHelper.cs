using OpenQA.Selenium;
using System;
using System.IO;

namespace Utilities
{
    public class ScreenshotHelper // Renamed class to avoid conflict
    {
        public static void TakeScreenshot(IWebDriver driver)
        {
            if (driver != null)
            {
                // Using fully qualified name for Selenium's Screenshot class
                OpenQA.Selenium.Screenshot photo = ((ITakesScreenshot)driver).GetScreenshot();
                string directoryPath = @"C:\Users\vegeshsai_boppana\source\repos\UIFramework\Project_Framework\Project_Framework\Screenshots\";
                string screenshotFileName = $"Wrong_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                string filePath = Path.Combine(directoryPath, screenshotFileName);
                Directory.CreateDirectory(directoryPath);  // Create directory if it does not exist
                photo.SaveAsFile(filePath);  // Save the screenshot to the specified path
            }
        }



        public static void DeleteFilesInFolder(string folderPath)
        {
            if(Directory.Exists(folderPath))
            {
                string[] files = Directory.GetFiles(folderPath);

                foreach(string file in files)
                {
                    try
                    {
                        File.Delete(file);

                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            else
            {
                Console.WriteLine("Directory donot exist");
            }
        }
    }


    
}


