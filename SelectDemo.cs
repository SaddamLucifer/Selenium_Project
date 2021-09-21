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
    class SelectDemo
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello this is Select from dropdown demo");
            //Launch Browser
            IWebDriver driver = new ChromeDriver("C:\\Users\\sadda\\OneDrive\\Desktop\\Selenium Practice");

            //Maximize browser
            driver.Manage().Window.Maximize();

            //Open url(open google)
            driver.Url = "https://formstone.it/components/dropdown/demo/";

            //Finding Select box by using ID
            IWebElement select_box = driver.FindElement(By.Id("demo_basic"));

            //Selct from Dropdown Demo
            SelectElement select = new SelectElement(select_box);

            //select.SelectByIndex(1);
            //select.SelectByValue("2");
            select.SelectByText("One");
           
            Thread.Sleep(3000);
            //Close Browser
            driver.Close();
        }
    }
}
