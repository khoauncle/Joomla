using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joomla.Interface
{
    public class InCreateArticlePage
    {
        public string txtTitleArticle = "//input[@id='jform_title']";
        public string txtContentArticle = "//textarea[@id='jform_articletext']";
        public string btnSaveAndClose = "//div[@id='toolbar-save']/button";
        public string btnToggleEditor = "//a[@title='Toggle editor']";

    }
}
