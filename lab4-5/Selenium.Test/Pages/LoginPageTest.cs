using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.Driver;
using Selenium.Pages;

namespace Selenium.Test.Pages
{
    class LoginPageTest
    {
        private IWebDriver driver;
        private static string loginPageUrl = "https://www.tumblr.com/login";
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
        public void OpenLoginPage()
        {
            var loginPage = new LoginPage(driver);
            loginPage.Open();

            Assert.AreEqual(driver.Url, loginPageUrl);
        }
        
        [Test]
        public void Login()
        {
            new LoginPage(driver).Open().Login("vinnichekira@gmail.com","qwerty123");
            Assert.AreEqual(driver.Url, dashboardUrl);
        }
    }
}
