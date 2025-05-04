using DotnetSelenium.Pages;
using OpenQA.Selenium.Chrome;
using System.Text.Json;

namespace DotnetSelenium
{
    public class DataDrivenTesting : IDisposable
    {
        private ChromeDriver _driver; // Changed type to ChromeDriver for CA1859

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            _driver.Manage().Window.Maximize();
        }

        [Test]
        [Category("ddt")]
        [TestCaseSource(nameof(LoginJsonDataSource))]
        public void TestWithPOM(LoginModel loginModel)
        {
            //POM initalization
            // Arrange
            LoginPage loginPage = new LoginPage(_driver);
            //Act
            loginPage.ClickLogin();
            loginPage.Login(loginModel.UserName, loginModel.Password);
            
            //Assert
            var getLoggedIn = loginPage.IsLoggedIn();
            Assert.IsTrue(getLoggedIn.employeeDetails && getLoggedIn.manageUsers);
        }

        [Test]
        [Category("ddt")]
        public void TestWithPOMWithJsonData()
        {
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "login.json");
            var jsonString = File.ReadAllText(jsonFilePath);
            var loginModel = JsonSerializer.Deserialize<LoginModel>(jsonString);

            LoginPage loginPage = new LoginPage(_driver);
            loginPage.ClickLogin();
            loginPage.Login(loginModel.UserName, loginModel.Password);
        }

        public static IEnumerable<LoginModel> Login()
        {
            yield return new LoginModel()
            {
                UserName = "admin",
                Password = "password"
            };
            yield return new LoginModel()
            {
                UserName = "admin2",
                Password = "password"
            };
            yield return new LoginModel()
            {
                UserName = "admin3",
                Password = "password"
            };
        }
        public static IEnumerable<LoginModel> LoginJsonDataSource()
        {
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "login.json");
            var jsonString = File.ReadAllText(jsonFilePath);
            var loginModel = JsonSerializer.Deserialize<List<LoginModel>>(jsonString);

            foreach (var loginData in loginModel)
            {
                yield return loginData;
            }
        }

        private void ReadJsonFile()
        {
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "login.json");
            var jsonString = File.ReadAllText(jsonFilePath);
            var loginModels = JsonSerializer.Deserialize<LoginModel>(jsonString);
            Console.WriteLine($"UserName: {loginModels.UserName} Password:{loginModels.Password}");
        }

        [TearDown]
        public void TearDown()
        {
            Dispose(); // Ensure _driver is disposed properly
        }

        public void Dispose()
        {
            _driver?.Quit();
            _driver?.Dispose();
        }
    }
}
