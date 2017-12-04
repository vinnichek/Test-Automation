using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Linq;
using System.Threading;

namespace Selenium
{
    public class MainPage : Page
    {
        public readonly string MAIN_URL = "https://tumblr.com/";

        public MainPage(IWebDriver driver) : base(driver) { }

        public MainPage Open()
        {
            driver.Navigate().GoToUrl(MAIN_URL);
            return this;
        }

        public FinderPage FindPostsByTag()
        {
            IWebElement tag = driver.FindElement(By.ClassName("search_query"));
            tag.Click();
            tag.SendKeys("girl");
            tag.SendKeys(Keys.Enter);
            return new FinderPage(driver);
        }

    }
}