using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Joomla.Interface;

namespace Joomla.Action
{
    public class AcCreateArticlePage : Common.CommonActions
    {
        private IWebDriver driver;
        private InCreateArticlePage inCreateArticlePage = new InCreateArticlePage();

        public AcCreateArticlePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void FillArticleInfor(string title, string category, string content)
        {
            type(inCreateArticlePage.txtTitleArticle, title, driver);

            //Fill Article Content
            click(inCreateArticlePage.btnToggleEditor, driver);
            click(inCreateArticlePage.txtContentArticle, driver);
            type(inCreateArticlePage.txtContentArticle, content, driver);
        }

        public void ClickArticleButton(string button)
        {
            switch (button)
            {
                case "Save & Close":
                    click(inCreateArticlePage.btnSaveAndClose, driver);
                    break;

                default:
                    Console.WriteLine("The button it not match ");
                    break;
            }

        }
    }
}
