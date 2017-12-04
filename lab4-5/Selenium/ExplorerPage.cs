using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium
{
    public class ExplorerPage : Page
    {
        public readonly string explorerPageUrl = "https://www.tumblr.com/explore/trending";

        public ExplorerPage(IWebDriver driver) : base(driver) { }

        public ExplorerPage Open()
        {
            driver.Navigate().GoToUrl(explorerPageUrl);
            return this;
        }

        public MainPage Follow()
        {
            IWebElement tag = driver.FindElement(By.ClassName("follow_link"));
            tag.Click();

            return new MainPage(driver);
        }
    }
}