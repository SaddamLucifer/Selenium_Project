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
    class AlertDemo_1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello this is Select Multiple from dropdown demo");
            //Launch Browser
            IWebDriver driver = new ChromeDriver("C:\\Users\\sadda\\OneDrive\\Desktop\\Selenium Practice");

            //Maximize browser
            driver.Manage().Window.Maximize();

            //Open url
           
            driver.Url = "https://www.seleniumeasy.com/test/javascript-alert-box-demo.html";
            //Click button
            driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[2]/div[2]/button")).Click();
            IAlert alert = driver.SwitchTo().Alert();
            String alert_text = alert.Text;
            Console.WriteLine(alert_text);
            Thread.Sleep(3000);

            // Respond to alert
            alert.Dismiss();
            Thread.Sleep(2000);
            //Close Browser
            driver.Close();
        }
    }
}
