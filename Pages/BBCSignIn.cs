using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using FluentAssertions;

namespace AutomationProject13.Pages
{
    public class BBCSignIn
    {
        public IWebDriver Driver;
        string ExpectedMessage = "Welcome to BBC.com";

        public BBCSignIn(IWebDriver browser)
        {
            Driver = browser;
            PageFactory.InitElements(Driver, this);
        }

        public void NavigateToBBC()
        {
            Driver.Navigate().GoToUrl("https://bbc.co.uk");
        }

        //[FindsBy(How = How.Id, Using = "idcta-username")]
        [FindsBy(How = How.Id, Using = "idcta-link")]
        public IWebElement SigninLink;

        [FindsBy(How = How.Id, Using = "user-identifier-input")]
        public IWebElement Username;

        [FindsBy(How = How.Id, Using = "password-input")]
        public IWebElement Password;

        [FindsBy(How = How.Id, Using = "submit-button")]
        public IWebElement SignInButton;

        [FindsBy(How = How.CssSelector, Using = "#page > section.module.module--header > h2 > span")]
        public IWebElement WelcomeMessage;

        public void ClickSigninLink()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            SigninLink.Click();
        }

        public void UserDetails()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Username.SendKeys("rtilesh@hotmail.com");
            Password.SendKeys("Tilesh123");
        }

        public void ClickSignInButton()
        {
            SignInButton.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        public void Verifylogin()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            WelcomeMessage.Text.Contains(ExpectedMessage).Should().BeTrue();
        }
        
    }
}