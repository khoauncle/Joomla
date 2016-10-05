using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Joomla.Action;

namespace Joomla.Steps
{
    [Binding]
    public sealed class ArticleManageSteps:ArticleManagePage
    {
        [Then(@"Verify the article is saved successfull with text: '(.*)'")]
        public void ThenVerifyTheArticleIsSavedSuccessfullWithText(string message)
        {
            VerifySuccessfullyMessage(message);
        }

    }
}
