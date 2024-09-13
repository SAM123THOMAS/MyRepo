using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
namespace TestWithJQuery
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IJavaScriptExecutor javascript = (IJavaScriptExecutor)driver;
            javascript.ExecuteScript("$('#firstName').val('jQuery');");
        }
    }
}