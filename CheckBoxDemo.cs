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
    class CheckBoxDemo
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello this is Select from dropdown demo");
            //Launch Browser
            IWebDriver driver = new ChromeDriver("C:\\Users\\sadda\\OneDrive\\Desktop\\Selenium Practice");

            //Maximize browser
            driver.Manage().Window.Maximize();

            //Open url(open google)
            driver.Url = "https://www.seleniumeasy.com/test/basic-checkbox-demo.html";

            //Finding Select box by using
            IWebElement check_box = driver.FindElement(By.Id("isAgeSelected"));

            Thread.Sleep(3000);
            check_box.Click();

            Thread.Sleep(3000);
            //Close Browser
            driver.Close();
        }
    }
}
