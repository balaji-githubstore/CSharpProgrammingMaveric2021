using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Threading;

namespace SeleniumConcepts
{
    class Meddibuddy
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.medibuddy.in/";
            //click on not now
            Thread.Sleep(10000);

            By notNowLocator=By.Id("wzrk-cancel");
            IWebElement element= driver.FindElement(notNowLocator);
            element.Click();



            driver.FindElement(By.LinkText("Signup")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Name("firstName")).SendKeys("bala");

        }
    }
}
