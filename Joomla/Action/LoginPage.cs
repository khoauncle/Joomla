using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joomla.Interface;
using OpenQA.Selenium;
using Joomla.Common;

namespace Joomla
{  
        
   public class LoginPage:BaseAction
    {
       
         public void Login(string username, string password)
        {
            type("txtUserName", username);
            type("txtPassword", password);
            click("btnLogin");
        }
        public void EnterUserName(string username)
        {
            type("txtUserName", username);
        }

        public void EnterPassword(string password)
        {
            type("txtPassword", password);
        }
    }
}
