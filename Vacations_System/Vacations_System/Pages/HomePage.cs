
using Vacations_System.Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Vacations_System.Pages
{
    class HomePage
    {
        public static void AssertLogo(int WaitTime)
        { 
            //validate as true element log into Home page
            Initialize.WaitElementUntilVisible(WaitTime);
            var element = Initialize.driver.FindElement(By.CssSelector("div#logo"));
            Assert.IsTrue(element.Displayed);
        }

        public static void AssertSuccessBanner(string TextBanner, int WaitTime)

        {
            //validate the banner contains the expected text
            Initialize.WaitElementUntilVisible(WaitTime);
            var element = Initialize.driver.FindElement(By.CssSelector("p.flash_notice")).Text;
            Assert.IsTrue(element.Contains(TextBanner));

        }


        public static void AssertUserLoggedBanner(string UserBanner, int WaitTime)
        {
            //validate the user banner contains the expected text
            Initialize.WaitElementUntilVisible(WaitTime);
            var element = Initialize.driver.FindElement(By.CssSelector("span")).Text;
            Assert.IsTrue(element.Contains(UserBanner));

        }


        /////////////////////CreateUser page objects////////////
        public static void CreateNewEmployeeLink()
        {
            Initialize.ScrollToElement("//a[contains(@href,'/employees/new')]");
            Initialize.WaitElementUntilVisible(500);
            Initialize.driver.FindElement(By.XPath("//a[contains(@href,'/employees/new')]")).Click();
        }


        public static void SetFirstNameEmployee(string firstName)
        {
            //method to set value into firstName field on createUser page
            IWebElement element = Initialize.driver.FindElement(By.Id("employee_first_name"));
            element.Clear();
            element.Click();
            element.SendKeys(firstName);
        }

        public static void SetLastNameEmployee(string lastName)
        {
            //method to set value into lastName field on createUser page
            var element = Initialize.driver.FindElement(By.Id("employee_last_name"));
            element.Clear();
            element.Click();
            element.SendKeys(lastName);
        }

        public static void SetEmailEmployee(string emailEmployee)
        {
            //method to set value into emailEmployee field on createUser page
            var element = Initialize.driver.FindElement(By.Id("employee_email"));
            element.Clear();
            element.Click();
            element.SendKeys(emailEmployee);
        }

        public static void SetIdEmployee(string IdEmployee)
        {
            //method to set value into IdEmployee field on createUser page
            var element = Initialize.driver.FindElement(By.Id("employee_identification"));
            element.Clear();
            element.Click();
            element.SendKeys(IdEmployee);
        }

        public static void SetLeaderName(string LeaderName)
        {
            //method to set value into LeaderName field on createUser page
            var element = Initialize.driver.FindElement(By.Id("employee_leader_name"));
            element.Clear();
            element.Click();
            element.SendKeys(LeaderName);
        }

        public static void SetStartedYear(string Year)
        {
            //method to set value on the Start working date field on createUser page
            var elementYear = Initialize.driver.FindElement(By.Id("employee_start_working_on_1i"));
            var selectElement = new SelectElement(elementYear);
            selectElement.SelectByValue(Year);
        }

        public static void SetStartedMonth(string Month)
        {
            //method to set value on the Start working date field on createUser page
            var elementYear = Initialize.driver.FindElement(By.Id("employee_start_working_on_2i"));
            var SelectElement = new SelectElement(elementYear);
            SelectElement.SelectByValue(Month);
        }

        public static void SetStartedDay(string Day)
        {
            //method to set value on the Start working date field on createUser page
            var elementYear = Initialize.driver.FindElement(By.Id("employee_start_working_on_3i"));
            var SelectElement = new SelectElement(elementYear);
            SelectElement.SelectByValue(Day);
        }


        public static void PressCreateEmployeeButton()
        {
            //method to press Button to create a new employee
            var element = Initialize.driver.FindElement(By.Name("commit"));
            element.Click();
            Initialize.WaitElementUntilVisible(500);

            //validate successful message on createUser page
            var sucesslabel = Initialize.driver.FindElement(By.XPath("//p[contains(text(),'Employee was successfully created.')]"));
            Assert.IsTrue(sucesslabel.Displayed);
        }


        public static void GoBackToHomePage(int waitTime)
        {
            Initialize.ScrollToElement("//a[text()='Back' and @href='/employees']");
            var GobackLink = Initialize.driver.FindElement(By.XPath("//a[contains(text(),'Back')]"));
            GobackLink.Click();
            Initialize.WaitElementUntilVisible(waitTime);
        }


    }
}
