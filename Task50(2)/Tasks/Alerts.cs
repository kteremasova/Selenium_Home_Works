using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Task50.Tasks
{
    class Alerts
    {
        IWebDriver _driver;

        const string alert1 = ("//button[@class='btn btn-default']");
        string expectedAlertText1 = "I am an alert box!";
        const string alert2 = ("//button[@class='btn btn-default btn-lg']");
        string expectedAlertText2 = "Press a button!";
        const string alert3 = ("//button[@onclick='myPromptFunction()']");
        string expectedAlertText3 = "Please enter your name";

        IWebElement Alert1 { get; }
        IWebElement Alert2 { get; }
        IWebElement Alert3 { get; }

        public Alerts(IWebDriver driver)
        {
            _driver = driver;
            Alert1 = _driver.FindElement(By.XPath(alert1));
            Alert2 = _driver.FindElement(By.XPath(alert2));
            Alert3 = _driver.FindElement(By.XPath(alert3));
        }

        public void Alert()
        {
            Alert1.Click();
            var alert_win1 = _driver.SwitchTo().Alert();
            NUnit.Framework.Assert.AreEqual(expectedAlertText1, alert_win1.Text);
            alert_win1.Accept();
            Thread.Sleep(1000);

            Alert2.Click();
            var alert_win2 = _driver.SwitchTo().Alert();
            NUnit.Framework.Assert.AreEqual(expectedAlertText2, alert_win2.Text);
            alert_win1.Accept();
            Thread.Sleep(1000);

            Alert3.Click();
            var alert_win3 = _driver.SwitchTo().Alert();
            NUnit.Framework.Assert.AreEqual(expectedAlertText3, alert_win3.Text);
            alert_win1.Accept();
            Thread.Sleep(1000);

        }
    }
}
