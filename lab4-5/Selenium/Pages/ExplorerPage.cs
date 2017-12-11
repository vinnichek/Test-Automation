using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium.Pages
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

        [FindsBy(How = How.ClassName, Using = "follow_link")]
        public IWebElement FollowButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "search-term-name")]
        public IWebElement PopularSearches { get; set; }

        public FinderPage GoToPopularSearchers()
        {
            PopularSearches.Click();
            return new FinderPage(driver);
        }

        public MainPage Follow()
        {
            FollowButton.Click();
            return new MainPage(driver);
        }
    }
}