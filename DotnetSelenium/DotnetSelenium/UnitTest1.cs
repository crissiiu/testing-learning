using DotnetSelenium.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DotnetSelenium
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestWithPOM()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            LoginPage loginPage = new LoginPage(driver);
            loginPage.ClickLogin();
            loginPage.Login("admin", "password");
        }

        
        ///* http://eaapp.somee.com/ */
        //[Test]
        //public void Test1()
        //{
        //    //Sudo code for setting up the Selenium
        //    //1. Create a new instance of Selenium WebDriver
        //    IWebDriver driver = new ChromeDriver();

        //    //2. Navigate to the URL
        //    driver.Navigate().GoToUrl("https://www.google.com/");

        //    //2a. Maximize the browser window
        //    driver.Manage().Window.Maximize();

        //    //3. Find the element
        //    IWebElement webElemnt = driver.FindElement(By.Name("q"));

        //    //4. Type in the element
        //    webElemnt.SendKeys("Selenium");
        //    //5. Click on the element
        //    webElemnt.SendKeys(Keys.Return);
        //}

        //[Test]
        //public void EAWebSiteTest()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("http://eaapp.somee.com/");
        //    driver.Manage().Window.Maximize();

        //    SeleniumCustomMethod.Click(driver, By.LinkText("Login"));

        //    SeleniumCustomMethod.EnterText(driver, By.Name("UserName"), "admin");
        //    SeleniumCustomMethod.EnterText(driver, By.Name("Password"), "password");

        //    // Identify the login button using ClassName
        //    //IWebElement btnLogin = driver.FindElement(By.ClassName("btn"));

        //    // Identify the login button using CssSelector  
        //    SeleniumCustomMethod.Click(driver, By.CssSelector("input[type='submit']"));
        //}

        //[Test]
        //public void WorkingWithAdvancedControls()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("E:\\workspace\\testing-learning\\testpage.html");


        //    SeleniumCustomMethod.SelectDropDownByText(driver, By.Id("country"), "Japan");
        //    SeleniumCustomMethod.MultiSelectElements(driver, By.Id("skills"), ["HTML", "CSS"]);

        //    List<string> getSelectedOptions = SeleniumCustomMethod.GetAllSelectedLists(driver, By.Id("skills"));

        //    getSelectedOptions.ForEach(Console.WriteLine);
        //    //SelectElement selectElement = new SelectElement(
        //    //    driver.FindElement(By.Id("country")));
        //    //selectElement.SelectByText("Japan");

        //    //SelectElement multiSelect = new SelectElement(
        //    //    driver.FindElement(By.Id("skills")));
        //    //multiSelect.SelectByValue("html");
        //    //multiSelect.SelectByValue("css");
        //    //multiSelect.SelectByValue("html");

        //    //IList<IWebElement> selectedOptions = multiSelect.AllSelectedOptions;
        //    //foreach (IWebElement option in selectedOptions)
        //    //{
        //    //    Console.WriteLine(option.Text);
        //    //}

        //    //Select all
        //    //var skillSelect = new SelectElement(driver.FindElement(By.Id("skills")));
        //    //skillSelect.Options.ToList().ForEach(o => skillSelect.SelectByText(o.Text));

        //}


    }
}