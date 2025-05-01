using System;
using OpenQA.Selenium;
namespace Login.TestPages
{

    public class LoginPage
    {
        private IWebDriver driver;

        private string urlLogin = "https://www.facebook.com/login"; // Replace with your actual login URL
        private string urlHomePage = "https://facebook.com"; // Replace with your actual home page URL

        private By usernameInput = By.ClassName("email");
        private By passwordInput = By.ClassName("pass");
        private By loginButton = By.Id("loginbutton");
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void NavigateToLoginPage()
        {
            driver.Navigate().GoToUrl(urlLogin);
        }
        public void EnterUserName(string username)
        {
            driver.FindElement(usernameInput).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(passwordInput).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            driver.FindElement(loginButton).Click();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
        }

        public bool IsLoggedIn()
        {
            return driver.Url.Contains(urlHomePage);
        }

        public void Login(string username, string password)
        {
            EnterUserName(username);
            EnterPassword(password);
            ClickLoginButton();
        }
    }
}
