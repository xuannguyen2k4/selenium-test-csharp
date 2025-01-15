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
                Console.WriteLine("Start testing navigation...");

                driver.Navigate().GoToUrl("D:\\BE\\SeleniumTesting\\SeleniumTesting\\SeleniumFrontend\\navigation.html");
                driver.Manage().Window.Maximize();

                var navLinks = driver.FindElements(By.ClassName("nav-link"));
                foreach (var link in navLinks)
                {
                    string linkText = link.Text;
                    link.Click();

                    // Wait for the page to load and check the URL
                    System.Threading.Thread.Sleep(2000); // Can be replaced with WebDriverWait for better synchronization
                    Console.WriteLine($"Redirected to: {driver.Url} with link: {linkText}");

                    // Go back to the previous page
                    driver.Navigate().Back();
                    System.Threading.Thread.Sleep(2000); // Adjust timing if needed
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in navigation test: {ex.Message}");
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
