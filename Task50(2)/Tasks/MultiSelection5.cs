using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Task50.Tasks
{ 
    public class MultiSelection5
    {
        IWebDriver _driver;

        const string select1 = ("//option[. = 'Washington']");
        const string select2 = ("//option[. = 'Ohio']");
        const string select3 = ("//option[. = 'Pennsylvania']");
        const string select4 = ("//option[. = 'Texas']");

        IWebElement Select1 { get; }
        IWebElement Select2 { get; }
        IWebElement Select3 { get; }
        IWebElement Select4 { get; }

        public MultiSelection5(IWebDriver driver)
        {
            _driver = driver;
            Select1 = _driver.FindElement(By.XPath(select1));
            Select2 = _driver.FindElement(By.XPath(select2));
            Select3 = _driver.FindElement(By.XPath(select3));
            Select4 = _driver.FindElement(By.XPath(select4));
        }

        public void Selector()
        {
            Select1.Click();
            Select2.Click();
            Select3.Click();
            Select4.Click();
        }

    }

}
