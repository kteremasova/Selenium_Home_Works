using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task50.Tasks;
using System.Threading;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace Task50
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test, Order(1)]
        public void Task5()
        {

            //Task5

            driver.Navigate().GoToUrl("https://demo.seleniumeasy.com/basic-select-dropdown-demo.html");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Manage().Window.Maximize();

            var element = driver.FindElement(By.CssSelector("#multi-select > option:nth-child(6)"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).ClickAndHold().Perform();
            MultiSelection5 selector1 = new MultiSelection5(driver);
            selector1.Selector();

            Thread.Sleep(1000);
        }
        [Test, Order(2)]
         public void Task6()
         { 
            //Task6

            driver.Navigate().GoToUrl("https://demo.seleniumeasy.com/javascript-alert-box-demo.html");
          
            Alerts alert = new Alerts(driver);
            alert.Alert();

            Thread.Sleep(1000);
         }

        [Test, Order(3)]
        public void Task7()
        {
            //Task6

            driver.Navigate().GoToUrl("https://demo.seleniumeasy.com/dynamic-data-loading-demo.html");

            UserWaiter waiter = new UserWaiter(driver);
            waiter.WaitUser();

            ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='loading']/br[2]"));

        }

        [TestCleanup]
        public void Cleanup()

        {
            driver.Close();
        }
    }
}