using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.TestScenario
{   
    internal class Cookie
    {
        private static string windowHandle;
        static void Main(string[] args)
        {
            //-------------// Xu ly Cookie //------------//
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");

            //Lay ra cookie
            var allCookies = driver.Manage().Cookies.AllCookies;

            //Lay gia tri cua mot cookie cu the
            var cookieValue = driver.Manage().Cookies.GetCookieNamed("cookieName").Value;

            //xoa cookie cu the
            driver.Manage().Cookies.DeleteCookieNamed("cookieName");
            
            //Xoa tat ca cookie
            driver.Manage().Cookies.DeleteAllCookies();

            driver.Quit();

            //-------------// Xu ly huong trinh duyet nhu Back Forward Refresh //------------//
            IWebDriver driver2 = new ChromeDriver();
            driver2.Navigate().GoToUrl("https://www.google.com");
            //Back
            driver2.Navigate().GoToUrl("https://www.facebook.com");
            driver2.Navigate().Back();

            //Forward: Di toi trang tiep theo sau khi da su dung Back
            driver2.Navigate().Forward();

            //Refresh: Lam moi trang hien tai
            driver2.Navigate().Refresh();

            //Tam dung chuong trinh xem ket qua
            Console.WriteLine("Nhấn Enter để đóng trình duyệt...");
            Console.ReadLine();
            driver2.Quit();
        }
    }
}
