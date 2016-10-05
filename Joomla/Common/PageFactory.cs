using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Joomla.Common;

namespace Joomla.Common
{
    public class PageFactory
    {
        public static IWebDriver driver;
        public void OpenBrowser()
        {
            driver = new FirefoxDriver();

            driver.Manage().Window.Maximize();

        }

        

    }
}
