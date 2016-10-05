using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Joomla.Common;

namespace Joomla.Action
{
    public class CreateArticlePage:BaseAction
    {

        public void FillArticleInfor(string title, string category, string content)
        {
            type("txtTitleArticle", title);


            //Fill Article Content
            click("btnToggleEditor");
            click("txtContentArticle");
            type("txtContentArticle",content);
        }

        public void ClickArticleButton(string button)
        {
            switch (button)
            {
                case "Save & Close":
                    click("btnSaveAndClose");
                    break;

                default:
                    Console.WriteLine("The button it not match ");
                    break;
            }

        }

    }
}
