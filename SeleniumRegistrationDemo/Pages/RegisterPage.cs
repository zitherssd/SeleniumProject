using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumRegistrationDemo.Models;

namespace SeleniumRegistrationDemo.Pages
{
    public class RegisterPage
    {
        IWebDriver driver;

        private IWebElement firstNameTextbox => driver.FindElement(By.Id("input-firstname"));
        private IWebElement lastNameTextbox => driver.FindElement(By.Id("input-lastname"));
        private IWebElement emailTextbox => driver.FindElement(By.Id("input-email"));
        private IWebElement telephoneTextbox => driver.FindElement(By.Id("input-telephone"));
        private IWebElement passwordTextbox => driver.FindElement(By.Id("input-password"));
        private IWebElement confirmPasswordTextbox => driver.FindElement(By.Id("input-confirm"));
        private IWebElement subscribeRadioButtonYes => driver.FindElement(By.XPath("//*[@id=\"content\"]/form/fieldset[3]/div/div/label[1]"));
        private IWebElement subscribeRadioButtonNo => driver.FindElement(By.XPath("//*[@id=\"content\"]/form/fieldset[3]/div/div/label[2]"));
        private IWebElement termsAgreeCheckbox => driver.FindElement(By.XPath("//*[@id=\"content\"]/form/div/div/input[1]"));
        private IWebElement continueButton => driver.FindElement(By.XPath("//*[@id=\"content\"]/form/div/div/input[2]"));

        public RegisterPage(IWebDriver driver) //Constructor
        {
            this.driver = driver;
            firstNameTextbox.Click();
        }

        public void FillRegistrationForm(UserDataModel userData)
        {
            setFirstName(userData.firstName);
            setLastName(userData.lastName);
            setEmail(userData.email);
            setTelephone(userData.telephone);
            setPassword(userData.password);
            setConfirmPassword(userData.password);
            if (userData.subscribed)
                subscribeRadioButtonYes.Click();
            else
                subscribeRadioButtonNo.Click();
        }


        public void setFirstName(string firstname)
        {
            firstNameTextbox.SendKeys(firstname);
        }
        public void setLastName(string lastname)
        {
            lastNameTextbox.SendKeys(lastname);
        }
        public void setEmail(string email)
        {
            emailTextbox.SendKeys(email);
        }

        public void setTelephone(string telephone)
        {
            telephoneTextbox.SendKeys(telephone);
        }

        public void setPassword(string password)
        {
            passwordTextbox.SendKeys(password);
        }

        public void setConfirmPassword(string password)
        {
            confirmPasswordTextbox.SendKeys(password);
        }

        public void CheckPrivacyPolicy()
        {
            termsAgreeCheckbox.Click();
        }

        public void ClickContinueButton()
        {
            continueButton.Click();
        }

    }
}
