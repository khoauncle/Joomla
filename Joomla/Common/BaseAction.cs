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
    public class BaseAction
    {
        public IWebDriver driver;


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
            Console.WriteLine("Namecontrol: "+ nameControl);
            string page = GetClassCaller();
            Console.WriteLine(page);
            string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName;
            path = path.Replace("\\bin\\Debug", "");
            Console.WriteLine(path);
            string content = string.Empty;
            switch (page)
            {
                case "LoginPage":
                    content = File.ReadAllText(path + @"\Interface\" + page + ".json");
                    Console.WriteLine(content);
                    break;
                default:
                    break;
            }

            Console.WriteLine("Enter Read Json File");

            JavaScriptSerializer ser = new JavaScriptSerializer();
            control[] result = ser.Deserialize<control[]>(content);
            string[] getControl = new string[2];
            Console.WriteLine(result.Length);
            for (int item = 0; item < result.Length; item++)
            {
                Console.WriteLine("NameControl get doc: "+result[item].controlName);
                if (result[item].controlName.Equals(nameControl))
                {
                    Console.WriteLine("Enter if loop");
                    getControl[0] = result[item].type;
                    getControl[1] = result[item].value;
                    Console.WriteLine(result[item].value);
                    return getControl;
                }

                Console.WriteLine("write for...");
            }
              return null;
        }

        // #Block - Read File JSOM - End Block 


        public IWebElement FindElement(String ElementPath)
        {
            string[] control = GetControlValue(ElementPath);
            Console.WriteLine("Enter FindElemnt action");
            Console.WriteLine("Value: " + control[1]);

            try
            {
                Console.WriteLine("Report type: "+control[0]);

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
