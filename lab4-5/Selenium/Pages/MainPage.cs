using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium.Pages
{
    public class MainPage : Page
    {
        public readonly string MAIN_URL = "https://tumblr.com/";

        [FindsBy(How = How.ClassName, Using = "search_query")]
        public IWebElement GetPostsByTag { get; set; }

        [FindsBy(How = How.ClassName, Using = "explore")]
        public IWebElement GoToExplorerPageButton { get; set; }

        public MainPage(IWebDriver driver) : base(driver) { }

        public MainPage Open()
        {
            driver.Navigate().GoToUrl(MAIN_URL);
            return this;
        }

        public ExplorerPage OpenExplorerPage()
        {
            driver.Navigate().GoToUrl(MAIN_URL);
            GoToExplorerPageButton.Click();
            return new ExplorerPage(driver);
        }

        public FinderPage FindPostsByTag(string tag)
        {
            GetPostsByTag.Click();
            GetPostsByTag.SendKeys(tag);
            GetPostsByTag.SendKeys(Keys.Enter);
            return new FinderPage(driver);
        }

    }
}