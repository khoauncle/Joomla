using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Joomla.Common
{
    public class Browser
    {

        private IWebDriver driver;
        public void OpenBrowser()
        { 
            driver = new FirefoxDriver();

            driver.Manage().Window.Maximize();

        }

        public void navigateURL(String strUrl)
        {
            driver.Navigate().GoToUrl(strUrl);
            driver.Manage().Window.Maximize();
        }
    }
}
