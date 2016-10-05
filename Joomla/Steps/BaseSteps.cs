using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Joomla.Common;

namespace Joomla.TestCases
{
    [Binding]
    public sealed class ConfigTestCase:Browser
    {
  

        [Given(@"Open Firefox Browser")]
        public void GivenOpenFirefoxBrowser()
        {
            OpenBrowser();
            
        }

        [Given(@"Navigate to the URL: ""(.*)""")]
        public void GivenNavigateToTheURL(string URL)
        {
            navigateURL(URL);
        }

        public static void Main(string[] args)
        {
        }
    }
}
