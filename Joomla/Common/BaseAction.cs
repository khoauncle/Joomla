using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.IO;
using System.Web.Script.Serialization;

namespace Joomla.Common
{
    public class BaseAction: Browser
    {  

    // #Block - Read File JSOM - Start Block

    private static string GetClassCaller(int level = 4)
        {

            var m = new System.Diagnostics.StackTrace().GetFrame(level).GetMethod();
            string className = m.DeclaringType.Name;
            return className;
       
        }

        public class control
        {
            public string controlName { get; set; }
            public string type { get; set; }
            public string value { get; set; }

        }

        public string[] GetControlValue(string nameControl)
        {
            string page = GetClassCaller();
            string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName;
            path = path.Replace("\\bin\\Debug", "");
             string content = string.Empty;
            switch (page)
            {
                case "LoginPage":
                    content = File.ReadAllText(path + @"\Interface\" + page + ".json");
                    break;
                default:
                    break;
            }

            JavaScriptSerializer ser = new JavaScriptSerializer();
            control[] result = ser.Deserialize<control[]>(content);
            string[] getControl = new string[2];
            for (int item = 0; item < result.Length; item++)
            {
                if (result[item].controlName.Equals(nameControl))
                {
                    getControl[0] = result[item].type;
                    getControl[1] = result[item].value;
                     return getControl;
                }
            }
              return null;
        }

        // #Block - Read File JSOM - End Block 


        public IWebElement FindElement(String ElementPath)
        {
            string[] control = GetControlValue(ElementPath);
            try
            {
 
                switch (control[0].ToUpper())
                {
                    case "XPATH":
                        Console.WriteLine("Enter return element ");
                        return driver.FindElement(By.XPath(control[1]));
                    default:
                        return driver.FindElement(By.XPath(control[1]));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("go to Exception");
                IWebElement Element = null;
                return Element;
            }
        }

        public void click(String ElementPath)
        {
            FindElement(ElementPath).Click();
        }

        public void type(String ElementPath, String strText)
        {
            FindElement(ElementPath).SendKeys(strText);
        }

        public void closeBrowser()
        {
            driver.Close();
        }

    }
}
