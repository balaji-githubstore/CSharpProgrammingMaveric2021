using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Threading;

namespace SeleniumConcepts
{
    class Program123
    {
        static void Main3(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            
            driver.Url = "https://www.medibuddy.in/"; //after the page load complete

            driver.FindElement(By.Id("wzrk-cancel")).Click(); //tries to findelement in 500ms/0.5s

            driver.FindElement(By.LinkText("Signup")).Click(); //tries to findelement in 500ms/0.5s

            driver.FindElement(By.Name("firstName")).SendKeys("bala"); //tries to findelement in 500ms/0.5s

            driver.FindElement(By.Name("phone")).SendKeys("89899898888");

            driver.FindElement(By.Name("username")).SendKeys("bala@gmail.com");

            driver.FindElement(By.Name("password")).SendKeys("bala@123");

            driver.FindElement(By.XPath("(//input[@type='checkbox'])[2]")).Click();
            //driver.FindElement(By.XPath("//span[text()='Are you a corporate user?']")).Click();
        }
    }
}
