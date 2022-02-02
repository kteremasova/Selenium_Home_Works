using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;
using System.Threading;

namespace Task50.Tasks
{
    class UserWaiter
    {
        IWebDriver _driver;

        const string getNewUser = ("//button[@class = 'btn btn-default']");


        IWebElement GetNewUser { get; }

        public UserWaiter(IWebDriver driver)
        {
            _driver = driver;
            GetNewUser = _driver.FindElement(By.XPath(getNewUser));
        }

        public void WaitUser()
        {
            GetNewUser.Click();
            Thread.Sleep(1000);
        }

    }
}
