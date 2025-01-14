using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTesting
{
    public class SearchTest
    {
        public static void RunTest()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                Console.WriteLine("Starting for searching...");

                // Mở trang chủ
                driver.Navigate().GoToUrl("D:\\BE\\SeleniumTesting\\SeleniumTesting\\SeleniumFrontend\\search.html");
                driver.Manage().Window.Maximize();

                // Nhập từ khóa tìm kiếm và nhấn Enter
                driver.FindElement(By.Id("searchBox")).SendKeys("Selenium");
                driver.FindElement(By.Id("searchBox")).SendKeys(Keys.Enter);

                // Kiểm tra kết quả tìm kiếm
                System.Threading.Thread.Sleep(2000); // Chờ kết quả tải
                var results = driver.FindElements(By.ClassName("search-result"));
                Console.WriteLine($"The amount of searching: {results.Count}");

                if (results.Count > 0)
                {
                    Console.WriteLine("Search Successfully!");
                }
                else
                {
                    Console.WriteLine("No Result.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in testing for searching: {ex.Message}");
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
