using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Project
{
    class LocateByName
    {
        static void Main(string[] args)
        {

            Console.WriteLine("hello Chrome browser is launched");
            //Launch Browser
            IWebDriver driver = new ChromeDriver("C:\\Users\\sadda\\OneDrive\\Desktop\\Selenium Practice");

            //Maximize browser
            driver.Manage().Window.Maximize();

            //Open url(open google)
            driver.Url = "https://www.google.co.in/";

            //Enter Selenium in search box
            IWebElement searchbox = driver.FindElement(By.Name("q"));
            searchbox.SendKeys("Selenium");

            //alternate way for entering text in search box

            //Close Browser
            driver.Close();
        }
    }
}
