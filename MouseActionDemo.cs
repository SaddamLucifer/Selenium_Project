using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_Project
{
    class MouseActionDemo
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello.....!!!!!!!!!!!");
            //Launch Browser
            IWebDriver driver = new ChromeDriver("C:\\Users\\sadda\\OneDrive\\Desktop\\Selenium Practice");
           
            //Maximize browser
            driver.Manage().Window.Maximize();
            
            //Open url(open google)
            driver.Url = "https://www.google.co.in/";

            IWebElement gmail = driver.FindElement(By.LinkText("Gmail"));
            Actions actions = new Actions(driver);

            //Click using mouse
            actions.MoveToElement(gmail).Click().Perform();

            //Hover using mouse
            //actions.MoveToElement(gmail).Build().Perform();

            //right click
            //actions.MoveToElement(gmail).ContextClick().Perform();

            //Double click
            //actions.MoveToElement(gmail).DoubleClick().Perform();

            //Close Browser
            Thread.Sleep(3000);
            driver.Close();
        }
    }
}
