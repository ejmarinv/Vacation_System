using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;


namespace Vacations_System.Objects
{
    public static class Initialize
    {
        public static IWebDriver driver;
        public static IWebElement webElement;

        [SetUp]
        public static void OpenBrowser()
        {
            driver = new ChromeDriver("C:/GAP_Project/Vacations_System");
            driver.Url = "https://vacations-management.herokuapp.com/";
            driver.Manage().Window.Maximize();
        }

        public static void WaitElementUntilVisible(int WaitTime)
        {
            Thread.Sleep(WaitTime);
        }

        public static void ScrollToElement(string elementToselect)
        {
            var elementTopick = driver.FindElement(By.XPath(elementToselect));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", elementTopick);
        }
        
        [TearDown]
        public static void CloseBrowser()
        {
            driver.Close();
        }



    }
}   


    
                
  






























    



