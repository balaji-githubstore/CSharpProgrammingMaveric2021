using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumConcepts
{
    class OpenEMR
    {
        static void Main3(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "http://demo.openemr.io/b/openemr/interface/login/login.php?site=default";


            driver.FindElement(By.XPath("//*[text()='Username:']/following::input")).SendKeys("admin");
            driver.FindElement(By.Id("clearPass")).SendKeys("pass");

            SelectElement select = new SelectElement(driver.FindElement(By.Name("languageChoice")));
            select.SelectByText("English (Indian)");

            //driver.FindElement(By.ClassName("btn")).Click();
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();


        }
    }
}
