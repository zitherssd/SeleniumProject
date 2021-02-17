using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace SeleniumRegistrationDemo
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void Start()
        {
            driver = new ChromeDriver("D:\\chrome");
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void Quit()
        {
            driver.Quit();
        }

        
    }
}
