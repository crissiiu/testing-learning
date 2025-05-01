using System;
using Login.TestPages;
using OpenQA.Selenium;
using NUnit.Framework;
using Login.Data;
namespace Login.TestScenario
{
    [TestFixture]
    public class LoginTest
    {
        private IWebDriver driver;

        [SetUp]
        //public void Setup()
        //{
        //    driver = BrowserDriver.Setup("chrome"); // Initialize the WebDriver (e.g., Chrome, Firefox, etc.)
        //    driver.Manage().Window.Maximize();
        //}

        [Test]
        public void Testcase1()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.NavigateToLoginPage();
            loginPage.Login(Users.userName, Users.password);

            bool isLoggedIn = loginPage.IsLoggedIn();

            if (isLoggedIn)
            {
                Console.WriteLine("Đăng nhập thành công");
            }
            else
            {
                Console.WriteLine("Đăng nhập thất bại");
            }

            Assert.Equals(isLoggedIn, "Đăng nhập thất bại");
        }
        [TearDown]
        public void Cleanup()
        {
            driver.Quit(); // Close the browser after the test
        }
    }
}
