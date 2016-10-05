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
    }
}
