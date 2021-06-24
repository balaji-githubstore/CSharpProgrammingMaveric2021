using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumConcepts
{
    class Demo1BrowserLaunchTest
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://www.gmail.com/";

            String actualTitle = driver.Title;
            Console.WriteLine(actualTitle);

            String actualUrl = driver.Url;
            Console.WriteLine(actualUrl);

            String pageSource = driver.PageSource;
            Console.WriteLine(pageSource);

        }
    }
}
