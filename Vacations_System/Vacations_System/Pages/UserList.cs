using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacations_System.Objects;
using OpenQA.Selenium;
using NUnit.Framework;

namespace Vacations_System.Pages
{
    class UserList
    {
        public static void  SearchUserFromTable()
        {
            //This method capture read all the present rows and validate if user name already exist
            var table = Initialize.driver.FindElement(By.XPath("//table"));
            IList<IWebElement> tableRows = table.FindElements(By.XPath("//tr"));

            for (int fila = 1; fila <= tableRows.Count; fila++)
            {
                if (tableRows.Equals("Emilio Marin Vizcaino"))
                {
                    Assert.Pass("Success!..the user was found..");
                    break;
                }
                else {

                    Console.WriteLine("the automation has not found the register yet, trying the next row!");
                }
            }

        }
    }
}
