using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Joomla.Action;

namespace Joomla.TestCases
{
    class TC_JOOMLA_ARTICLE_001
    {

        public static IWebDriver driver;
        
        public static void TC_JOOMLA_ARTICLE_001_Verify_user_can_create_new_article_with_valid_information()
        {

            Console.WriteLine("Step1: Navigate to the URL: http://192.168.189.119/abyssal/administrator/index.php");

            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://192.168.189.119/abyssal/administrator/index.php");
            driver.Manage().Window.Maximize();

            Console.WriteLine("Step2: Enter valid username into Username field");
            Console.WriteLine("Step3: Enter valid password into Password field");
            Console.WriteLine("Step4: Click on 'Log in' button");

            //string username = "long.ngoc.nguyen";
            //string password = "123456";
            //AcLoginPage acloginPage = new AcLoginPage(driver);
           // acloginPage.Login(username, password);

            Console.WriteLine("Step5: Select Content > Article Manager");
            Console.WriteLine("Step6: Click on 'New' icon of the top right toolbar");
            AcHomePage acHomepage = new AcHomePage(driver);
            acHomepage.OpenCreateArticleForm();
            
            Console.WriteLine("Step7: Enter a title on 'Title' field");
            Console.WriteLine("Step8: Select an item from the 'Category' dropdown list");
            Console.WriteLine("Step9: Enter value on 'Article Text' text area");

            string title = "Shen Title";
            string category = "Shen Category";
            string content = "Shen Content";

            AcCreateArticlePage acCreateArticlePage = new AcCreateArticlePage(driver);
            acCreateArticlePage.FillArticleInfor(title,category,content);

            Console.WriteLine("Step10: Click on 'Save & Close' icon of the top right toolbar");
            acCreateArticlePage.ClickArticleButton("Save & Close");

            Console.WriteLine("Step11: Verify the article is saved successfully");

        }

       public static void Main(string[] args)
        {
            TC_JOOMLA_ARTICLE_001_Verify_user_can_create_new_article_with_valid_information();
        }
    }
}
