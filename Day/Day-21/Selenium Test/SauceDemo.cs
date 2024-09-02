using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Test
{
    internal class SauceDemo
    {
        public static void Main4()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();

            //var suggestions = driver.FindElements(By.XPath("//div[@id='login_credentials']"));
            //var text = suggestions.Select(x => x.Text).ToList();

            //var usernameval = text[0].Split("\n\r")[1];


            IWebElement usernameElmt = driver.FindElement(By.Name("user-name"));
            usernameElmt.SendKeys("standard_user");

            IWebElement passElmt = driver.FindElement(By.Name("password"));
            passElmt.SendKeys("secret_sauce");

            IWebElement submitElemt = driver.FindElement(By.Name("login-button"));
            submitElemt.Click();

            

            IWebElement addCart = driver.FindElement(By.XPath("//*[@id=\"add-to-cart-sauce-labs-bike-light\"]"));
            addCart.Click();

            IWebElement clickCart = driver.FindElement(By.ClassName("shopping_cart_link"));
            clickCart.Click();

            IWebElement checkOut = driver.FindElement(By.Name("checkout"));
            checkOut.Click();



        }
    }

}
