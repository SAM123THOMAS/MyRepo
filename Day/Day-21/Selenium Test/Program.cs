using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Test
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://demoqa.com/text-box");
            //driver.Manage().Window.Maximize();
            //IWebElement element = driver.FindElement(By.Id("userName"));
            //element.SendKeys("I am Sam");

            //IWebElement clickElement = driver.FindElement(By.Id("submit"));
            //clickElement.Click();

            //driver.Navigate().GoToUrl("https://www.google.com/");
            //IWebElement element = driver.FindElement(By.Name("q"));
            //element.SendKeys("I am Sam");
            //IWebElement clickElement = driver.FindElement(By.Name("btnK"));
            //clickElement.Click();

            //driver.Navigate().GoToUrl("https://www.amazon.in/");
            //IWebElement element = driver.FindElement(By.Id("twotabsearchtextbox"));
            //element.SendKeys("I am Sam");
            //IWebElement clickElement = driver.FindElement(By.Id("nav-search-submit-button"));
            //clickElement.Click();

            //driver.Navigate().GoToUrl("http://automationpractice.com/");
            //IWebElement element = driver.FindElement(By.XPath("//p"));
            //var attribute=element.Text;
            //Console.WriteLine(attribute);

            driver.Navigate().GoToUrl("http://automationpractice.com/");
            IWebElement element = driver.FindElement(By.XPath("//p"));
            var attribute = element.Text;
            Console.WriteLine(attribute);
        }
    }
}