using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joomla.Interface;
using OpenQA.Selenium;

namespace Joomla
{  
   public class AcLoginPage:Common.CommonActions
    {
        private IWebDriver driver;
        private InLoginPage inLoginPage = new InLoginPage();

        public AcLoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
            
       public void Login(string username, string password)
        {
            type(inLoginPage.txtUserName, username, driver);
            type(inLoginPage.txtPassword, password, driver);
            click(inLoginPage.btnLogin, driver);
        }

    }
}
