using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium.Pages
{
    public class LoginPage : Page
    {
        public readonly string enterPageUrl = "https://tumblr.com/login";

        public LoginPage(IWebDriver driver) : base(driver) { }
        
        public LoginPage Open()
        {
            driver.Navigate().GoToUrl(enterPageUrl);
            return this;
        }

        [FindsBy(How = How.Id, Using = "signup_determine_email")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.ClassName, Using = "signup_determine_btn")]
        public IWebElement NextButton { get; set; }

        [FindsBy(How = How.Id, Using = "signup_password")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.ClassName, Using = "signup_login_btn")]
        public IWebElement LoginButton { get; set; }

        public DashboardPage Login(string email, string password)
        {
            EmailField.Click();
            EmailField.SendKeys(email);
            EmailField.SendKeys(Keys.Enter);

            NextButton.Click();

            PasswordField.SendKeys(password);

            LoginButton.Click();

            return new DashboardPage(driver);
        }
       
       
    }
}
