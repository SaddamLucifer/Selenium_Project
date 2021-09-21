using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_Project
{
    class TitleNameDemo
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello this is Title Name Demo");
            //Launch Browser
            IWebDriver driver = new ChromeDriver("C:\\Users\\sadda\\OneDrive\\Desktop\\Selenium Practice");

            //Maximize browser
            driver.Manage().Window.Maximize();

            //Open url(open google)
            driver.Url = "https://www.google.co.in/";

            //Displaying Title Nmae of web page before Clicking on link
            string t1 = driver.Title;
            Console.WriteLine("Home Page Title is: "+t1);
            //By LinkText
            //Displaying Title Nmae of web page after Clicking on link
            driver.FindElement(By.LinkText("Gmail")).Click();
            string t2 = driver.Title;
            Console.WriteLine("Next Page Title is: " + t2);

            Thread.Sleep(3000);
            //Close Browser
            driver.Close();
        }
    }
}
