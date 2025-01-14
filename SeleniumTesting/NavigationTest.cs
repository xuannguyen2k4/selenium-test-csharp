using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTesting
{
    public class NavigationTest
    {
        public static void RunTest()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                Console.WriteLine("Start Testing, Redirect...");

                // Mở trang chủ
                driver.Navigate().GoToUrl("D:\\BE\\SeleniumTesting\\SeleniumTesting\\SeleniumFrontend\\navigation.html");
                driver.Manage().Window.Maximize();

                // Tìm các liên kết trong menu điều hướng
                var navLinks = driver.FindElements(By.ClassName("nav-link"));
                foreach (var link in navLinks)
                {
                    string linkText = link.Text;
                    link.Click();

                    // Chờ tải trang và kiểm tra URL
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine($"Redirected to: {driver.Url} with link: {linkText}");

                    // Quay lại trang trước
                    driver.Navigate().Back();
                    System.Threading.Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in testing redirect: {ex.Message}");
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
