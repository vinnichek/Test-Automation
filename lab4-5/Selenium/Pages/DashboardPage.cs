using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium.Pages
{
    public class DashboardPage : Page
    {
        public readonly string explorerPageUrl = "https://www.tumblr.com/dashboard";

        public DashboardPage(IWebDriver driver) : base(driver) { }

        public DashboardPage Open()
        {
            driver.Navigate().GoToUrl(explorerPageUrl);
            return this;
        }

        [FindsBy(How = How.ClassName, Using = "compose-button")]
        public IWebElement WritePostButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "post-type-name-span")]
        public IWebElement ChooseTypeOfPost { get; set; }

        [FindsBy(How = How.ClassName, Using = "editor-plaintext")]
        public IWebElement TitleField { get; set; }

        [FindsBy(How = How.ClassName, Using = "editor-richtext")]
        public IWebElement TextField { get; set; }

        [FindsBy(How = How.ClassName, Using = "create_post_button")]
        public IWebElement AddPostButton { get; set; }

        public DashboardPage AddPost(string title, string text)
        {
            WritePostButton.Click();

            ChooseTypeOfPost.Click();

            TitleField.Click();
            TitleField.SendKeys(title);

            TextField.Click();
            TextField.SendKeys(text);

            AddPostButton.Click();

            return new DashboardPage(driver);
        }
    }
}
