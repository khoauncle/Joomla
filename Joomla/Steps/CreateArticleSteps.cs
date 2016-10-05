using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Joomla.Action;

namespace Joomla.Steps
{
    [Binding]
    public sealed class CreateArticleSteps:CreateArticlePage
    {

        [Given(@"Enter ""(.*)"" ""(.*)"" ""(.*)"" on Title, Category, Content field")]
        public void GivenEnterOnTitleCategoryContentField(string title, string category, string content)
        {
            FillArticleInfor(title,category,content);
        }

        [When(@"Click on ""(.*)"" icon of the top right toolbar")]
        public void WhenClickOnIconOfTheTopRightToolbar(string button)
        {
            ClickArticleButton(button);
        }
    }
}
