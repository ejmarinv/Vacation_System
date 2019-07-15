using System;
using Vacations_System.Objects;
using NUnit.Framework;
using OpenQA.Selenium;


namespace Vacations_System.Pages
{
    public class LoginPage
    {

        public static void SetEmailLogin(string emailLogin) {

            //email element into logIN page
            var element = Initialize.driver.FindElement(By.Id("user_email"));
            element.Clear();
            element.Click();
            element.SendKeys(emailLogin);
        }

        public static void SetPasswordLogin(string passwordLogin)
        {
           
            //password element into logIN page
            var element = Initialize.driver.FindElement(By.Id("user_password"));
            element.Clear();
            element.Click();
            element.SendKeys(passwordLogin);
        }

        public static void PressSignInButton()
        {
            //submit button into logIN
            var element = Initialize.driver.FindElement(By.XPath("//*[@type='submit']"));
            element.Click();
            Initialize.WaitElementUntilVisible(500);
         
        }
    }
}
