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
    class MouseActionDragDropDemo
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello.....!!!!!!!!!!!");
            //Launch Browser
            IWebDriver driver = new ChromeDriver("C:\\Users\\sadda\\OneDrive\\Desktop\\Selenium Practice");
           
            //Maximize browser
            driver.Manage().Window.Maximize();
            
            //Open url(open google)
            driver.Url = "https://www.seleniumeasy.com/test/drag-and-drop-demo.html";

            IWebElement source = driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div[2]/div[1]/span[1]"));
            
            IWebElement destination = driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div[2]/div[2]/div"));
            Actions actions = new Actions(driver);
            //actions.ClickAndHold(source).MoveToElement(destination).Release(destination).Build().Perform();
            actions.DragAndDrop(source, destination).Build().Perform();

            //Close Browser
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
