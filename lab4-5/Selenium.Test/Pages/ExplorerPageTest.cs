using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.Driver;
using Selenium.Pages;

namespace Selenium.Test.Pages
{
    class ExplorerPageTest
    {
        private IWebDriver driver;
        private static string followWithoutRegistrationUrl = "https://www.tumblr.com/register?redirect_to=/explore";
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

        public void OpenExplorerPage()
        {
            var explorerPage = new ExplorerPage(driver);
            explorerPage.Open();

            Assert.AreEqual(driver.Url, explorerPageUrl);
        }

        [Test]
        public void FollowWithoutRegistration()
        {
            new ExplorerPage(driver).Open().Follow();
            Assert.AreEqual(driver.Url, followWithoutRegistrationUrl);
        }
        
        [Test]
        public void GoToPopularSearchers()
        {
            new ExplorerPage(driver).Open().GoToPopularSearchers();
        }
    }
}
