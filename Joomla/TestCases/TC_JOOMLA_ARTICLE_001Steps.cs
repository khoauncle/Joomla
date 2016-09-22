using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Joomla.Action;

namespace Joomla.TestCases
{
    [Binding]
    public class TC_JOOMLA_ARTICLE_001Steps
    {
        public static IWebDriver driver;

        [Given(@"Open Firefox Browser")]
        public void GivenOpenFirefoxBrowser()
        {
            driver = new FirefoxDriver();
            
            driver.Manage().Window.Maximize();
        }
        
        [Given(@"Navigate to the URL: ""(.*)""")]
        public void GivenNavigateToTheURL(string p0)
        {
            driver.Navigate().GoToUrl(p0);
        }

        [Given(@"Enter username ""(.*)"" and password ""(.*)""")]
        public void GivenEnterUsernameAndPassword(string username, string password)
        {
            AcLoginPage acloginPage = new AcLoginPage(driver);
            acloginPage.Login(username, password);
        }
      
        [Given(@"Click on Create Article link")]
        public void GivenClickOnCreateArticleLink()
        {
            AcHomePage acHomepage = new AcHomePage(driver);
            acHomepage.OpenCreateArticleForm();
        }

        [Given(@"Enter ""(.*)"" ""(.*)"" ""(.*)"" on Title, Category, Content field")]
        public void GivenEnterOnTitleCategoryContentField(string title, string category, string content)
        {
            AcCreateArticlePage acCreateArticlePage = new AcCreateArticlePage(driver);
            acCreateArticlePage.FillArticleInfor(title, category, content);
        }
       
        [When(@"Click on ""(.*)"" icon of the top right toolbar")]
        public void WhenClickOnIconOfTheTopRightToolbar(string p0)
        {
            AcCreateArticlePage acCreateArticlePage = new AcCreateArticlePage(driver);
            acCreateArticlePage.ClickArticleButton("Save & Close");
        }
               
        [Then(@"Verify the article is saved successfull")]
        public void ThenVerifyTheArticleIsSavedSuccessfull()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
