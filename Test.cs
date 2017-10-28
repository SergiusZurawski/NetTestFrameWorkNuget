using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
using System.IO;

namespace ToolsQA
{
    [TestFixture]
    class NUnitTest
    {
        [Test]
        public void TestApp()
        {
            Console.WriteLine(Directory.GetCurrentDirectory());
            Console.WriteLine("----------------------------------");
            FirefoxOptions fOption = new FirefoxOptions();
            // fOption.BrowserExecutableLocation = "/home/serg/Programming/C#/NetTestFrameWorkNuget/geckodriver";
            // IWebDriver driver = new FirefoxDriver(fOption);
            Environment.SetEnvironmentVariable("webdriver.chrome.logfile", "cromederiverlog");
            Environment.SetEnvironmentVariable("webdriver.chrome.verboseLogging", "true");
            ChromeOptions options = new ChromeOptions();
            IWebDriver driver = new ChromeDriver("/home/serg/Programming/C#/NetTestFrameWorkNuget/");
            driver.Url = "http://www.demoqa.com";
            driver.Close();
        }
    }
}