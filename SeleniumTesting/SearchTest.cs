using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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
                Console.WriteLine("Starting search test...");

                driver.Navigate().GoToUrl("D:\\BE\\SeleniumTesting\\SeleniumTesting\\SeleniumFrontend\\search.html");
                driver.Manage().Window.Maximize();

                // Perform search
                driver.FindElement(By.Id("searchBox")).SendKeys("Selenium");
                driver.FindElement(By.Id("searchBox")).SendKeys(Keys.Enter);

                // Wait for search results to appear
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2000));

                var results = driver.FindElements(By.ClassName("search-result"));
                Console.WriteLine($"Number of results: {results.Count}");

                if (results.Count > 0)
                {
                    Console.WriteLine("Search Successful!");
                }
                else
                {
                    Console.WriteLine("No Results.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in search test: {ex.Message}");
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
