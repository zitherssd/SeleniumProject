using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumRegistrationDemo.Models;
using SeleniumRegistrationDemo.Pages;
using System.Threading;

namespace SeleniumRegistrationDemo.Test
{
    public class RegistrationTest : BaseTest
    {
        UserDataModel userData = new UserDataModel
        {
            firstName = "Eren",
            lastName = "Jaeger",
            email = "erenjaeger@yahoo.com",
            telephone = "0767676767",
            password = "rumbling",
            subscribed = true
        };

        [Test]
        public void Test ()
        {
            Homepage homepage = new Homepage(driver);
            homepage.GoTo();
            homepage.ClickMyAccountButton();
            homepage.ClickRegisterButton();

            RegisterPage registerPage = new RegisterPage(driver);
            registerPage.FillRegistrationForm(userData);
            registerPage.CheckPrivacyPolicy();
            registerPage.ClickContinueButton();
            
            Thread.Sleep(1000);
            Assert.IsTrue(driver.Title.Contains("Your Account Has Been Created!"));
        }

    }
}
