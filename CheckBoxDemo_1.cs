using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_Project
{
    class CheckBoxDemo_1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello this is Select from dropdown demo");
            //Launch Browser
            IWebDriver driver = new ChromeDriver("C:\\Users\\sadda\\OneDrive\\Desktop\\Selenium Practice");

            //Maximize browser
            driver.Manage().Window.Maximize();

            //Open url(open google)
            driver.Url = "https://preview.colorlib.com/theme/bootstrap/checkbox-04/";

            //Finding Select box by using ID
            IWebElement check_box = driver.FindElement(By.Id("checkboxOne"));
            check_box.Click();

            IWebElement check_box1 = driver.FindElement(By.Id("checkboxTwo"));
            check_box1.Click();

            IWebElement check_box2 = driver.FindElement(By.Id("checkboxThree"));
            check_box2.Click();

            Thread.Sleep(3000);
            //Close Browser
            driver.Close();
        }
    }
}
