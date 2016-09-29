using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Joomla.Action;
using Joomla.Common;

namespace Joomla.TestCases
{
    [Binding]
    public class TC_JOOMLA_ARTICLE_001Steps
    {
        BaseAction Browser = new BaseAction();
        private LoginPage LoginPage;
        
        [Given(@"Open Firefox Browser")]
        public void GivenOpenFirefoxBrowser()
        {
            Browser.OpenBrowser();
        }
        
        [Given(@"Navigate to the URL: ""(.*)""")]
        public void GivenNavigateToTheURL(string URL)
        {
            Browser.navigateURL(URL);
        }

        [Given(@"Enter username ""(.*)"" and password ""(.*)""")]
        public void GivenEnterUsernameAndPassword(string username, string password)
        {
            LoginPage.Login(username,password);
        }
      
        [Given(@"Click on Create Article link")]
        public void GivenClickOnCreateArticleLink()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"Enter ""(.*)"" ""(.*)"" ""(.*)"" on Title, Category, Content field")]
        public void GivenEnterOnTitleCategoryContentField(string title, string category, string content)
        {
            ScenarioContext.Current.Pending();
        }
       
        [When(@"Click on ""(.*)"" icon of the top right toolbar")]
        public void WhenClickOnIconOfTheTopRightToolbar(string p0)
        {
            ScenarioContext.Current.Pending();
        }
               
        [Then(@"Verify the article is saved successfull")]
        public void ThenVerifyTheArticleIsSavedSuccessfull()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
