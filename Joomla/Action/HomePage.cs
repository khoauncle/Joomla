using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Joomla.Common;

namespace Joomla.Action
{
    public class HomePage:BaseAction
    {

        public void OpenCreateArticleForm()
        {
            click("lnkNewArticle");
        }
    }
}
