using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Joomla.Common
{
    public class CommonActions
    {
        public void click(String strXpath, IWebDriver driver)
        {
            driver.FindElement(By.XPath(strXpath)).Click();
        }

        public void type(String strXpath, String strText, IWebDriver driver)
        {
            driver.FindElement(By.XPath(strXpath)).SendKeys(strText);
        }

        public void closeBrowser(IWebDriver driver)
        {
            driver.Close();
        }
    }
}
