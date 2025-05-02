using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;

namespace Login.TestScenario
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures )]
    public class ParallelTest
    {
        [Test]
        public void FirefoxTest()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("https://www.example.com/");
            Thread.Sleep(2000);
            driver.Quit();
        }

        [Test]
        public void EdgeTest()
        {
            IWebDriver driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("https://www.example.com/");
            Thread.Sleep(20000);
            driver.Quit();
        }

        [Test]
        public void ChromeTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("https://www.example.com/");
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
