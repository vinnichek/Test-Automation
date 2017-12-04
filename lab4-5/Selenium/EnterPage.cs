using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    public class EnterPage : Page
    {
        public readonly string enterPageUrl = "https://tumblr.com/login";

        public EnterPage(IWebDriver driver) : base(driver) { }
        
        public EnterPage Open()
        {
            driver.Navigate().GoToUrl(enterPageUrl);
            return this;
        }
        
        public DashboardPage Login()
        {
            IWebElement email = driver.FindElement(By.Id("signup_determine_email"));
            email.Click();
            email.SendKeys("vinnichekira@gmail.com");
            email.SendKeys(Keys.Enter);
            
            IWebElement button = driver.FindElement(By.ClassName("signup_determine_btn"));
            button.Click();
            
            IWebElement password = driver.FindElement(By.Id("signup_password"));
            password.Click();
            password.SendKeys("qwerty123");

            IWebElement enterButton = driver.FindElement(By.ClassName("signup_login_btn"));
            enterButton.Click();
            
            return new DashboardPage(driver);
        }
        
        public DashboardPage AddPost()
        {
            IWebElement email = driver.FindElement(By.Id("signup_determine_email"));
            email.Click();
            email.SendKeys("vinnichekira@gmail.com");
            email.SendKeys(Keys.Enter);

            IWebElement button = driver.FindElement(By.ClassName("signup_determine_btn"));
            button.Click();

            IWebElement password = driver.FindElement(By.Id("signup_password"));
            password.Click();
            password.SendKeys("qwerty123");

            IWebElement enterButton = driver.FindElement(By.ClassName("signup_login_btn"));
            enterButton.Click();

            IWebElement postButton = driver.FindElement(By.Id("new_post_label_text"));
            postButton.Click();

            IWebElement title = driver.FindElement(By.ClassName("editor-plaintext"));
            title.Click();
            title.SendKeys("hello");

            IWebElement text = driver.FindElement(By.ClassName("editor-richtext"));
            text.Click();
            text.SendKeys("world");

            IWebElement addPostButton = driver.FindElement(By.ClassName("create_post_button"));
            addPostButton.Click();

            return new DashboardPage(driver);
        }
    }
}
