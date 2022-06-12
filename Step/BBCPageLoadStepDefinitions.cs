using System;
using TechTalk.SpecFlow;
using AutomationProject13.Base;
using AutomationProject13.Pages;
using OpenQA.Selenium;

namespace AutomationProject13
{
    [Binding]
    [Scope(Tag = "BBCPageLoad")]
    public class BBCPageLoadStepDefinitions : SetUp
    {
        public IWebDriver Browser;
        BBCPageLoad bbcpageload;

        [Given(@"I Navigate To BBC")]
        public void GivenINavigateToBBC()
        {
            Browser = driver;
            bbcpageload = new BBCPageLoad(Browser);
            bbcpageload.NavigateToBBC();
        }

        [Then(@"I Am Able To View The Page")]
        public void ThenIAmAbleToViewThePage()
        {
            bbcpageload.CheckUrl();
        }
    }
}
