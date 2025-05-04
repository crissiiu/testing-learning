//using DotnetSelenium.Pages;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;

//namespace DotnetSelenium
//{
//    [TestFixture("admin", "password")]
//    public class NUnitTestsDemo
//    {
//        private IWebDriver _driver;
//        private readonly string username;
//        private readonly string password;

//        public NUnitTestsDemo(string username, string password)
//        {
//            this.username = username;
//            this.password = password;
//        }

//        [SetUp]
//        public void SetUp()
//        {
//            _driver = new ChromeDriver();
//            _driver.Navigate().GoToUrl("http://eaapp.somee.com/");
//            _driver.Manage().Window.Maximize();
//        }

//        [Test]
//        [Category("smoke")]
//        public void TestWithPOM()
//        {
//            LoginPage loginPage = new LoginPage(_driver);
//            loginPage.ClickLogin();
//            loginPage.Login(username, password);
//        }

//        [Test]
//        [TestCase("chrome","30")]
//        public void TestBrowserVersion(string browser, string version)
//        {
//            Console.WriteLine($"The browser is {browser} with version {version}");
//        }

//        [TearDown]
//        public void TearDown()
//        {
//            // Close the browser after the test
//            _driver.Quit();
//        }
//    }
//}
