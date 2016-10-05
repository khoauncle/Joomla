using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Joomla.Action;

namespace Joomla.Steps
{
    [Binding]
    public sealed class HomeSteps:HomePage
    {
        [Given(@"Click on Create Article link")]
        public void GivenClickOnCreateArticleLink()
        {
            OpenCreateArticleForm();
        }
    }
}
