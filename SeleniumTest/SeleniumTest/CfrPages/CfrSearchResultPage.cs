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
    public class SearchResultPage
    {
        IWebDriver driver;
        String title;

        public SearchResultPage(IWebDriver driver)
        {
            this.driver = driver;
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            title = driver.Title;
        }

        public bool CheckTitle(string departure, string destination)
        {
            Thread.Sleep(2000);
            return title.Contains(departure) && title.Contains(destination);
        }
    }
}
