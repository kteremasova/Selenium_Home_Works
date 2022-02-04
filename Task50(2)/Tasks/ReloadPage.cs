using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Task50.Tasks
{
    class ReloadPage
    {
        IWebDriver _driver;

        const string downloadButton = ("//button[@id='cricle-btn']"); //*[@id="cricle-btn"]

        IWebElement DownloadButton { get; }

        public ReloadPage(IWebDriver driver)
        {
            _driver = driver;
            DownloadButton = _driver.FindElement(By.XPath(downloadButton));
        }

        public void ReloadBar()
        {
            DownloadButton.Click();
        }
    }
}
