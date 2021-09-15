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
    class AbsoluteXpath
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello this is Locate by Absolute XPath practical");
            //Launch Browser
            IWebDriver driver = new ChromeDriver("C:\\Users\\sadda\\OneDrive\\Desktop\\Selenium Practice");

            //Maximize browser
            driver.Manage().Window.Maximize();

            //Open url(open google)
            driver.Url = "https://www.google.co.in/";

            //By LinkText
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input")).SendKeys("Selenium");

            Thread.Sleep(3000);
            //Close Browser
            driver.Close();
        }
    }
}
