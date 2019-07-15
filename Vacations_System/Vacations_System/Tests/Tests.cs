using NUnit.Framework;
using OpenQA.Selenium;
using Vacations_System.Objects;
using Vacations_System.Pages;

namespace Vacations_System
{
    class Tests
    {
        
        [Test]
        public void LogIn()
        {
            //This test should complete logIn into the aplication
            Initialize.OpenBrowser();
            LoginPage.SetEmailLogin("gap-automation-test@mailinator.com");
            LoginPage.SetPasswordLogin("12345678");
            LoginPage.PressSignInButton();
            
        }

        [Test]
        public void ValidateHomePage()
        {

            HomePage.AssertLogo(500);
            HomePage.AssertUserLoggedBanner("Welcome gap, ", 500);
            HomePage.AssertSuccessBanner("Signed in successfully.", 500);
            Initialize.WaitElementUntilVisible(500);

            //createUserObjects
            HomePage.CreateNewEmployeeLink();
            HomePage.SetFirstNameEmployee("James");
            HomePage.SetLastNameEmployee("Smith");
            HomePage.SetEmailEmployee("email@example.com");
            HomePage.SetIdEmployee("1234567890");
            HomePage.SetLeaderName("Emilio Marin Vizcaino");

            HomePage.SetStartedYear("2014");
            HomePage.SetStartedMonth("1");
            HomePage.SetStartedDay("21");
            HomePage.PressCreateEmployeeButton();
            HomePage.GoBackToHomePage(1000);

        }

        [Test]
        public void ValidateUserList()
        {
            UserList.SearchUserFromTable();
            Initialize.CloseBrowser();
        }


    }
}
