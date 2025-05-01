using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Login.TestScenario
{
    internal class FacebookFrame
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https//www.facebook.com/");
            //How to change frame with name  or id
            driver.SwitchTo().Frame("frameName");
            driver.SwitchTo().Frame("framerId");

            //Change frame with index
            driver.SwitchTo().Frame(0);
            //Change frame with 1st frame element in current frame
            driver.SwitchTo().Frame("parentFrame");
            driver.SwitchTo().Frame("childFrame");

            //External frame processing
            IWebElement iframeElement = driver.FindElement(By.TagName("iframe"));
            driver.SwitchTo().Frame(iframeElement);

            //Exit current frame and switch to parent frame
            driver.SwitchTo().ParentFrame();

            //Switch to login frame
            driver.SwitchTo().Frame("iframe_canvas");

            //Operate with the elements in the frame
            IWebElement emailInput = driver.FindElement(By.Id("email"));
            emailInput.SendKeys("your_email@example.com");

            IWebElement passwordInput = driver.FindElement(By.Id("pass"));
            passwordInput.SendKeys("your_password");

            //Exit the login frame and switch to the default content
            driver.SwitchTo().DefaultContent();

            //Continue operating with the main page
            IWebElement signUpButton = driver.FindElement(By.LinkText("Sign Up"));
            signUpButton.Click();

            //Close the browser
            driver.Quit();

        }
    }
}
