using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Base2.Testes;

namespace Base2
{
    public static class Driver
    {
        public static IWebDriver driver { get; set; }

        public static void WaitForElementUpTo(int seconds = 5)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }

        public static void InitializeDriver(string BaseURL, int tempo)
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(BaseURL);
            Driver.WaitForElementUpTo(tempo);
        }
    }
}
