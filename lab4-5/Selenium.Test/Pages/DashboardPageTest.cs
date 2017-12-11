using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.Driver;
using Selenium.Pages;

namespace Selenium.Test.Pages
{
    class DashboardPageTest
    {
        private IWebDriver driver;
        private static string dashboardUrl = "https://www.tumblr.com/dashboard";

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
        public void OpenDashboardPage()
        {
            var loginPage = new LoginPage(driver);
            loginPage.Open().Login("vinnichekira@gmail.com", "qwerty123");
            Assert.AreEqual(driver.Url, dashboardUrl);
        }
        
        [Test]
        public void AddPost()
        {
            var loginPage = new LoginPage(driver);
            loginPage.Open().Login("vinnichekira@gmail.com", "qwerty123");
            new DashboardPage(driver).AddPost("hello", "world");
            Assert.AreEqual(driver.Url, dashboardUrl);
        }
    }
}
