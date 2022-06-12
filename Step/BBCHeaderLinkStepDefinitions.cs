using System;
using TechTalk.SpecFlow;
using AutomationProject13.Base;
using AutomationProject13.Pages;
using OpenQA.Selenium;

namespace AutomationProject13
{
    [Binding]
    [Scope(Tag = "BBCHeaderLink")]

    public class BBCHeaderLinkStepDefinitions : SetUp
    {
        public IWebDriver Browser;
        public BBCHeaderLink bbcheaderlink;

        [Given(@"I navigate to BBC website")]
        public void GivenINavigateToBBCWebsite()
        {
            Browser = driver;
            bbcheaderlink = new BBCHeaderLink(Browser);
            bbcheaderlink.NavigateToBBC();
        }

        [When(@"I click on (.*)")]
        public void WhenIClickOn(string link)
        {
            bbcheaderlink.ClickLinks(link);
        }

        [Then(@"I can see (.*) page")]
        public void ThenICanSeePage(string link)
        {
            bbcheaderlink.VerifyLinks(link);
        }
    }
}
