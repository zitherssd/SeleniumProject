using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumRegistrationDemo.Pages
{
    public class Homepage
    {
        IWebDriver driver;

        private IWebElement myAccountButton => driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/a/i"));
        private IWebElement registerButton => driver.FindElement(By.XPath("//a[contains(text(),'Register')]"));
        private IWebElement loginButton => driver.FindElement(By.XPath("//*[@id=\"top - links\"]/ul/li[2]/ul/li[2]"));

        public Homepage(IWebDriver driver) //Constructor
        {
            this.driver = driver;
        }

        public void GoTo()
        {
            driver.Navigate().GoToUrl("http://tutorialsninja.com/demo/");
        }

        public void ClickMyAccountButton()
        {
            myAccountButton.Click();
        }

        public void ClickRegisterButton()
        {
            registerButton.Click();
        }

        public void ClickLoginButton()
        {
            registerButton.Click();
        }
    }
}
