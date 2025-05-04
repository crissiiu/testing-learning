using OpenQA.Selenium;

namespace DotnetSelenium.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement LoginLink => driver.FindElement(By.Id("loginLink"));

        IWebElement TxtUser =>driver.FindElement(By.Name("UserName"));

        IWebElement TxtPassword => driver.FindElement(By.Name("Password"));

        IWebElement BtnLogin => driver.FindElement(By.CssSelector(".btn"));
    
        public void ClickLogin()
        {
            LoginLink.SubmitElement();
        }

        public void Login(string username, string password)
        {
            TxtUser.EnterText(username);
            TxtPassword.EnterText(password);
            BtnLogin.SubmitElement();
        }
    }
}

