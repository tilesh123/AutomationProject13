using System;
using TechTalk.SpecFlow;
using AutomationProject13.Base;
using AutomationProject13.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationProject13
{
    [Binding]
    [Scope(Tag = "BBCSignIn")]

    public class BBCSignInStepDefinitions : SetUp
    {
        public IWebDriver Browser;
        public BBCSignIn bbcsignin;

        [Given(@"I navigate to BBC Website")]
        public void GivenINavigateToBBCWebsite()
        {
            Browser = driver;
            bbcsignin = new BBCSignIn(Browser);
            bbcsignin.NavigateToBBC();
        }

        [When(@"I click on account link")]
        public void WhenIClickOnAccountLink()
        {
            bbcsignin.ClickSigninLink();
        }

        [When(@"I enter my username and password")]
        public void WhenIEnterMyUsernameAndPassword()
        {
            bbcsignin.UserDetails();
        }

        [When(@"I click on Sign in")]
        public void WhenIClickOnSignIn()
        {
            bbcsignin.ClickSignInButton();
        }

        [Then(@"I am able to sign in successfully")]
        public void ThenIAmAbleToSignInSuccessfully()
        {
            bbcsignin.Verifylogin();
        }
    }
}
