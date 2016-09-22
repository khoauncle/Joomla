using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Joomla.Interface;

namespace Joomla.Action
{
    public class AcHomePage:Common.CommonActions
    {
        private IWebDriver driver;
        private InHomePage inHomePage = new InHomePage();

        public AcHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void OpenCreateArticleForm()
        {
            click(inHomePage.lnkNewArticle, driver);
        }
    }
}
