using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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

                driver.Navigate().GoToUrl("D:\\BE\\SeleniumTesting\\SeleniumTesting\\SeleniumFrontend\\login.html");
                driver.Manage().Window.Maximize();

                // Enter the login details
                driver.FindElement(By.Id("username")).SendKeys("testuser");
                driver.FindElement(By.Id("password")).SendKeys("testpassword");
                driver.FindElement(By.Id("loginButton")).Click();

                // Wait for the page to load and check the result
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2000));

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
