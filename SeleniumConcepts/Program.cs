using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://www.irctc.co.in/nget/train-search";

            driver.FindElement(By.XPath("//button[text()='OK']")).Click();
            driver.FindElement(By.XPath("//input[@role='searchbox']")).SendKeys("chenn");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//span[text()='CHENNAI EGMORE - MS']")).Click();

            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}
