using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using System.Net;

namespace Login.TestScenario
{
    internal class Facebook
    {
        static void Main()
        {
            IWebDriver driver =new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/r.php?locale=en_GB&display=page");

            //Xu ly textbox
            IWebElement firstNameTextbox = driver.FindElement(By.Name("firstname"));
            firstNameTextbox.SendKeys("John");

            IWebElement lastNameTextbox = driver.FindElement(By.Name("lastname"));
            lastNameTextbox.SendKeys("Doe");

            //Dropdown
            IWebElement monthDropdown = driver.FindElement(By.Name("birthday_month"));
            SelectElement monthSelect = new SelectElement(monthDropdown);
            monthSelect.SelectByText("Jan");

            IWebElement dayDropdown = driver.FindElement(By.Name("birthday_day"));
            SelectElement daySelect = new SelectElement(dayDropdown);
            daySelect.SelectByText("15");

            IWebElement yearDropdown = driver.FindElement(By.Name("birthday_year"));
            SelectElement yearSelect = new SelectElement(yearDropdown);
            yearSelect.SelectByText("1990");

            //Button
            IWebElement signUpButton = driver.FindElement(By.Name("websubmit"));
            signUpButton.Click();

            //Accept alert warning
            IAlert alertAccept = driver.SwitchTo().Alert();
            alertAccept.Accept();

            //Dismiss alert warning
            IAlert alertDismiss = driver.SwitchTo().Alert();
            alertDismiss.Dismiss();

            //Text in warning
            IAlert alertGetText = driver.SwitchTo().Alert();
            string alertText = alertGetText.Text;

            //Change window pop-up
            string mainWindowHandle = driver.CurrentWindowHandle;
            //Identify the new window
            string popupWindowHandle = driver.WindowHandles.Last();
            driver.SwitchTo().Window(popupWindowHandle);

            //Change to the main window
            driver.SwitchTo().Window(mainWindowHandle);
            //Close window popup
            driver.Close();


            //-----//mouse actions//-----//
            //create action object
            Actions actions = new Actions(driver);
            //simulate mouse hover
            actions.SendKeys(Keys.Enter).Build().Perform();
            IWebElement element = driver.FindElement(By.Id("elementId"));
            element.SendKeys("Helloworld");

            //chuyen chuot toi element cu the
            IWebElement element2 = driver.FindElement(By.Id("elementId2"));
            actions.MoveToElement(element2).Build().Perform();


            //click chuot trai
            actions.Click().Build().Perform();

            //click double
            actions.DoubleClick().Build().Perform();    

            //Vi du
            driver.Navigate().GoToUrl("https:/www.facebook.com/");
            IWebElement emailTextbox = driver.FindElement(By.Name("email"));
            IWebElement passwordTexbox = driver.FindElement(By.Name("passord"));

            Actions actions2 = new Actions(driver);
            actions.MoveToElement(emailTextbox).Click().SendKeys("your_email@example.com").Build().Perform();
            System.Threading.Thread.Sleep(1000);

            actions.MoveToElement(passwordTexbox).Click().SendKeys("your_password").Build().Perform();
            System.Threading.Thread.Sleep(1000);

            IWebElement loginButton = driver.FindElement(By.Name("login"));
            actions.MoveToElement(loginButton).Click().Build().Perform();

            System.Threading.Thread.Sleep(5000);


            //---------//Chup anh man hinh va bao cao//---------//
            try {
                IWebElement element123 = driver.FindElement(By.Id(("some_element_id")));
            }
            catch(Exception ex)
            {
                Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile("D:\\Screenshot.png");
                driver.Quit();
            }

            //---------//Xu ly tai len va tai xuong tap tin//---------//
            //Upload
            IWebElement uploadElement =driver.FindElement(By.Id("uploadElementId"));
            uploadElement.SendKeys("@D:\file.txt");
            //Download
            IWebElement downloadLink = driver.FindElement(By.Id("download"));
            string fileUrl = downloadLink.GetAttribute("href");

            //Tai tap tin xuong
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(fileUrl, "D:\\downloaded_file.txt");
            }


            //close browser
            driver.Quit();

        }
    }
}
