using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Joomla.Action;
using Joomla.Common;

namespace Joomla.TestCases
{
    [Binding]
    public sealed class LoginSteps :LoginPage
    {

        [Given(@"Enter username ""(.*)"" and password ""(.*)""")]
        public void GivenEnterUsernameAndPassword(string username, string password)
        {
            Login(username,password);
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
