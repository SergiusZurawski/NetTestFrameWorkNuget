using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Support.UI;

namespace ToolsQA
{
    enum Browsers { FF, IE, Chrome };
    [TestFixture]
    class NUnitTest
    {
        private readonly string location = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        [Test]
        public void TestApp()
        {
//            Console.WriteLine("----------------------------------");
//            Console.WriteLine(Browsers.Chrome.ToString().Equals("Chrome"));
//            Console.WriteLine(Browsers.Chrome.ToString().Equals("Chrome"));
//            Console.WriteLine("----------------------------------");

            
             
            //FirefoxOptions fOption = new FirefoxOptions();
            // fOption.BrowserExecutableLocation = "/home/serg/Programming/C#/NetTestFrameWorkNuget/geckodriver";
            // IWebDriver driver = new FirefoxDriver(fOption);
            Environment.SetEnvironmentVariable("webdriver.chrome.logfile", "cromederiverlog");
            Environment.SetEnvironmentVariable("webdriver.chrome.verboseLogging", "true");
            ChromeOptions options = new ChromeOptions();
            IWebDriver driver = new ChromeDriver(location);
            driver.Url = "http://www.demoqa.com";
            var wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.PartialLinkText("TFS Test API")));
            clickableElement.Click();
            driver.Close();

            
        }
    }
}