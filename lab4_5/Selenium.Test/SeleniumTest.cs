using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.Logic;

namespace Selenium.Test.Pages
{
    [TestFixture]
    public class MainPageTest
    {
        private IWebDriver driver;
        private static string mainPageUrl = "https://www.tumblr.com/";
        private static string explorerPageUrl = "https://www.tumblr.com/explore/trending";
        private static string postsByTagUrl = "https://www.tumblr.com/search/girl";
        private static string followWithoutRegisterUrl = "https://www.tumblr.com/register?redirect_to=/explore";

        [SetUp]
        public void Init() => driver = Driver.Get();

        [TearDown]
        public void Close() => Driver.Close();

        [Test]
        public void OpenMainPage()
        {
            var mainPage = new MainPage(driver);
            mainPage.Open();

            Assert.AreEqual(driver.Url, mainPageUrl);
        }

        [Test]
        public void OpenExplorerPage()
        {
            var explorerPage = new ExplorerPage(driver);
            explorerPage.Open();

            Assert.AreEqual(driver.Url, explorerPageUrl);
        }
        
        [Test]
        public void FindPostByTag()
        {
            var mainPage = new MainPage(driver);
            mainPage.Open().FindPostsByTag();
            Driver.SetWaitTime(30);

            Assert.AreEqual(driver.Url, postsByTagUrl);
        }
        
        [Test]
        public void Follow()
        {
            var explorerPage = new ExplorerPage(driver);
            explorerPage.Open().Follow();

            Assert.AreEqual(driver.Url, followWithoutRegisterUrl);
        }
    }
}
