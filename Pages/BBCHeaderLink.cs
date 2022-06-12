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
    public class BBCHeaderLink
    {
        public IWebDriver Driver;
        string url = "https://www.bbc.com";

        public BBCHeaderLink(IWebDriver browser)
        {
            Driver = browser;
            PageFactory.InitElements(Driver, this);
        }

        public void NavigateToBBC()
        {
            Driver.Navigate().GoToUrl("https://bbc.com");
        }

        [FindsBy(How = How.LinkText, Using = "News")]
        public IWebElement NewsLink;
        [FindsBy(How = How.LinkText, Using = "Sport")]
        public IWebElement SportLink;
        [FindsBy(How = How.LinkText, Using = "Reel")]
        public IWebElement ReelLink;
        [FindsBy(How = How.LinkText, Using = "Worklife")]
        public IWebElement WorklifeLink;
        [FindsBy(How = How.LinkText, Using = "Travel")]
        public IWebElement TravelLink;
        [FindsBy(How = How.LinkText, Using = "Future")]
        public IWebElement FutureLink;
        [FindsBy(How = How.LinkText, Using = "Culture")]
        public IWebElement CultureLink;
        [FindsBy(How = How.LinkText, Using = "TV")]
        public IWebElement TVLink;
        [FindsBy(How = How.LinkText, Using = "Weather")]
        public IWebElement WeatherLink;
        [FindsBy(How = How.LinkText, Using = "Sounds")]
        public IWebElement SoundsLink;

        string NewsUrl = "https://www.bbc.com/news";
        string SportUrl = "https://www.bbc.com/sport";
        string ReelUrl = "https://www.bbc.com/reel";
        string WorklifeUrl = "https://www.bbc.com/worklife";
        string TravelUrl = "https://www.bbc.com/travel";
        string FutureUrl = "https://www.bbc.com/future";
        string CultureUrl = "https://www.bbc.com/culture";
        string TVUrl = "https://www.bbc.co.uk/schedules/p00fzl9m";
        string WeatherUrl = "https://www.bbc.com/weather";
        string SoundsUrl = "https://www.bbc.co.uk/sounds";

        public void ClickLinks(string link)
        {
            switch (link)
            {
                case "News":
                    NewsLink.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                    break;
                case "Sport":
                    SportLink.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                    break;
                case "Reel":
                    ReelLink.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                    break;
                case "Worklife":
                    WorklifeLink.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                    break;
                case "Travel":
                    TravelLink.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                case "Future":
                    FutureLink.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                    break;
                case "Culture":
                    CultureLink.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                    break;
                case "TV":
                    TVLink.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                    break;
                case "Weather":
                    WeatherLink.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                    break;
                case "Sounds":
                    SoundsLink.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                    break;
                default: Console.WriteLine("No Link Match - ClickLinks method");
                    break;
            }
        }

        public void VerifyLinks(string link)
        {
            switch (link)
            {
                case "News":
                    Driver.Url.Contains(NewsUrl).Should().BeTrue();
                    break;
                case "Sport":
                    Driver.Url.Contains(SportUrl).Should().BeTrue();
                    break;
                case "Reel":
                    Driver.Url.Contains(ReelUrl).Should().BeTrue();
                    break;
                case "Worklife":
                    Driver.Url.Contains(WorklifeUrl).Should().BeTrue();
                    break;
                case "Travel":
                    Driver.Url.Contains(TravelUrl).Should().BeTrue();
                    break;
                case "Future":
                    Driver.Url.Contains(FutureUrl).Should().BeTrue();
                    break;
                case "Culture":
                    Driver.Url.Contains(CultureUrl).Should().BeTrue();
                    break;
                case "TV":
                    Driver.Url.Contains(TVUrl).Should().BeTrue();
                    break;
                case "Weather":
                    Driver.Url.Contains(WeatherUrl).Should().BeTrue();
                    break;
                case "Sounds":
                    Driver.Url.Contains(SoundsUrl).Should().BeTrue();
                    break;
                default: Console.WriteLine("No Link Match - VerifyLinks method");
                    break;
            }
        }
    }
}
