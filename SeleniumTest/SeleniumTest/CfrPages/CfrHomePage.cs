using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SeleniumTest
{
    public class CfrHomePage
    {
        IWebDriver driver;

        private IWebElement departureTextbox => driver.FindElement(By.XPath("//*[@id=\"statiePlecare\"]"));
        private IWebElement destinationTextbox => driver.FindElement(By.XPath("//*[@id=\"statieDestinatie\"]"));
        private IWebElement searchButton => driver.FindElement(By.XPath("//*[@id=\"linkCautare\"]"));
        private IWebElement closePopupButton => driver.FindElement(By.CssSelector("#hwp-30238 > div > div.hwp-close"));
        private IWebElement subscribeRadioButtonYes => driver.FindElement(By.CssSelector("#hwp-30238 > div > div.hwp-close"));

        public CfrHomePage(IWebDriver driver) //Constructor
        {
            this.driver = driver;
        }

        public void GoTo()
        {
            driver.Navigate().GoToUrl("https://cfrcalatori.ro/");
        }

        public void SetDeparture(string departure)
        {
            departureTextbox.SendKeys(departure);
        }
        public void SetDestination(string destination)
        {
            destinationTextbox.SendKeys(destination);
        }

        public void ClickSearchButton()
        {
            searchButton.Click();
        }

        public void ClosePopup()
        {
            Thread.Sleep(2000);
            closePopupButton.Click();
        }

        public void SearchRoutes(string departure, string destination)
        {
            SetDeparture(departure);
            SetDestination(destination);
            ClickSearchButton();
        }
    }
}