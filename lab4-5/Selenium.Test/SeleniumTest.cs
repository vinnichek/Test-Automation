using NUnit.Framework;
using OpenQA.Selenium;
using Selenium;

namespace Selenium.Test
{
    [TestFixture]
    public class MainPageTest
    {
        private IWebDriver driver;
        private static string mainPageUrl = "https://www.tumblr.com/";
        private static string explorerPageUrl = "https://www.tumblr.com/explore/trending";
        private static string postsByTagUrl = "https://www.tumblr.com/search/girl";
        private static string followWithoutRegisterUrl = "https://www.tumblr.com/register?redirect_to=/explore";
        private static string enterPageUrl = "https://www.tumblr.com/login";
        private static string dashboardUrl = "https://www.tumblr.com/dashboard";

        [SetUp]
        public void Init()
        {
            driver = Driver.Get();
        }

        [TearDown]
        public void Close()
        {
            Driver.Close();
        }

        [Test]
        public void AddPost()
        {
            var enterPage = new EnterPage(driver);
            enterPage.Open().AddPost();

            Driver.SetWaitTime(60);

            Assert.AreEqual(driver.Url, dashboardUrl);
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
        public void OpenEnterPage()
        {
            var enterPage = new EnterPage(driver);
            enterPage.Open();

            Assert.AreEqual(driver.Url, enterPageUrl);
        }
        
        [Test]
        public void Login()
        {
            var enterPage = new EnterPage(driver);
            enterPage.Open().Login();

            Driver.SetWaitTime(60);

            Assert.AreEqual(driver.Url, dashboardUrl);
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