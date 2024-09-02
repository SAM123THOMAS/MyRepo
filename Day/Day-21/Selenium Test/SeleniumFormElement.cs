using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace SeleniumTest
{
    internal class SeleniumFormElements
    {
        public static void Main3()
        {
                        IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            IWebElement inputField = driver.FindElement(By.Name("q"));
            inputField.SendKeys("haryana");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            var suggestions = driver.FindElements(By.CssSelector(".sbct"));
            var text = suggestions.Select(x => x.Text).ToList();
            Console.WriteLine("========Suggestion Test=========");


            var clickvalues = suggestions.FirstOrDefault(x => x.Text.Contains("haryana"));
            if (clickvalues != null)
            {
                clickvalues.Click();
            }

            Console.WriteLine("==============END=========");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Quit();
        }
    }
}