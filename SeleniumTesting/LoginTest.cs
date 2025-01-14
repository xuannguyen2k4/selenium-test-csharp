using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTesting
{
    public class LoginTest
    {
        public static void RunTest()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                Console.WriteLine("Start testing to login...");

                // Mở trang đăng nhập
                driver.Navigate().GoToUrl("D:\\BE\\SeleniumTesting\\SeleniumTesting\\SeleniumFrontend\\login.html");
                driver.Manage().Window.Maximize();

                // Nhập thông tin đăng nhập
                driver.FindElement(By.Id("username")).SendKeys("testuser");
                driver.FindElement(By.Id("password")).SendKeys("testpassword");
                driver.FindElement(By.Id("loginButton")).Click();

                // Kiểm tra kết quả
                System.Threading.Thread.Sleep(2000); // Chờ trang tải
                if (driver.PageSource.Contains("Welcome, testuser"))
                {
                    Console.WriteLine("Login Successfully!");
                }
                else
                {
                    Console.WriteLine("Login Failed.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in testing for login: {ex.Message}");
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
