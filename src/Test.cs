using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
using System.IO;
using System.Reflection;
using System.Threading;

namespace ToolsQA
{
    [TestFixture]
    class NUnitTest
    {
        private readonly string location = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        [Test]
        public void TestApp()
        {
            Console.WriteLine(Directory.GetCurrentDirectory());
            Console.WriteLine("----------------------------------");
            Console.WriteLine(location);
            Console.WriteLine("----------------------------------");
             string [] fileEntries = Directory.GetFiles(location);
                foreach(string fileName in fileEntries){
                     Console.WriteLine(fileName);
                }
            // FirefoxOptions fOption = new FirefoxOptions();
            // fOption. = location;
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(location, "geckodriver");
            IWebDriver driver = new FirefoxDriver(service);
            // Environment.SetEnvironmentVariable("webdriver.chrome.logfile", "cromederiverlog");
            // Environment.SetEnvironmentVariable("webdriver.chrome.verboseLogging", "true");
            // ChromeOptions options = new ChromeOptions();
            // IWebDriver driver = new ChromeDriver("/home/serg/Programming/C#/NetTestFrameWorkNuget/bin/Debug/netcoreapp2.0/");
            driver.Url = "http://www.demoqa.com";
            Thread.Sleep(10000);
            driver.Close();
        }
    }
}