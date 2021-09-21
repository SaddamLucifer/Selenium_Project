using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Project
{
    class LaunchMozillaFirefox
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Mozilla-Firefox browser is launched");
            //Launch Browser
            //IWebDriver driver = new FirefoxDriver("C:\\Users\\sadda\\OneDrive\\Desktop\\Selenium Practice");
            IWebDriver driver = new FirefoxDriver();
            //Maximize browser
            driver.Manage().Window.Maximize();

            //Open url(open google)
            driver.Url = "https://www.instagram.com/";

            //Close Browser
            driver.Quit();
        }
    }
}

