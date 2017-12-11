using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.Driver;
using Selenium.Pages;

namespace Selenium.Test.Pages
{
    [TestFixture]
    public class MainPageTest
    {
        private IWebDriver driver;
        private static string mainPageUrl = "https://www.tumblr.com/";
        private static string postsByTagUrl = "https://www.tumblr.com/search/girl";
        private static string explorerPageUrl = "https://www.tumblr.com/explore/trending";

        [SetUp]
        public void Init()
        {
            driver = DriverInstance.Get();
        }

        [TearDown]
        public void Close()
        {
            DriverInstance.Close();
        }

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
            new MainPage(driver).Open().FindPostsByTag("girl");
            Assert.AreEqual(driver.Url, postsByTagUrl);
        }
    }
}