using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Project
{
    class LaunchChrome
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Chrome browser is launched");
            //Launch Browser
            //IWebDriver driver = new ChromeDriver("C:\\Users\\sadda\\OneDrive\\Desktop\\Selenium Practice");
            IWebDriver driver = new ChromeDriver();
            //Maximize browser
            driver.Manage().Window.Maximize();
            
            //Open url(open google)
            driver.Url = "https://www.google.co.in/";
            
            //Close Browser
            driver.Quit();
        }
    }
}
