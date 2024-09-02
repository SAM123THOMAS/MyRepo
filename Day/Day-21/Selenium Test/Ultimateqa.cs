using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateQA
{
    internal class Program
    {
        static void Main2(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ultimateqa.com/filling-out-forms/");
            IWebElement nameElement = driver.FindElement(By.Id("et_pb_contact_name_0"));
            nameElement.SendKeys("Sam");

            IWebElement msgElement = driver.FindElement(By.Id("et_pb_contact_message_0"));
            msgElement.SendKeys("This is a Sample MEssage");

            IWebElement submitElement = driver.FindElement(By.Name("et_builder_submit_button"));
            submitElement.Click();

            IWebElement nameElement1 = driver.FindElement(By.Id("et_pb_contact_name_1"));
            nameElement1.SendKeys("Sam");

            IWebElement msgElement1 = driver.FindElement(By.Id("et_pb_contact_message_1"));
            msgElement1.SendKeys("This is a Sample MEssage");

            IWebElement captaElement = driver.FindElement(By.XPath("//*[@id=\'et_pb_contact_form_1\']/div[2]/form/div/div/p/span"));
            var capta = captaElement.Text;
            int a = Convert.ToInt16(capta.Split("+")[0]);
            int b = Convert.ToInt16(capta.Split("+")[1]);
            int c = a + b;

            IWebElement captaVal = driver.FindElement(By.Name("et_pb_contact_captcha_1"));
            captaVal.SendKeys(Convert.ToString(c));

            IWebElement submitElement1 = driver.FindElement(By.Name("et_builder_submit_button"));
            submitElement1.Click();


        }


    }
}
