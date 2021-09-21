using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_Project
{
    class RadioButtonDemo2
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello this is Radio Button demo");
            //Launch Browser
            IWebDriver driver = new ChromeDriver("C:\\Users\\sadda\\OneDrive\\Desktop\\Selenium Practice");

            //Maximize browser
            driver.Manage().Window.Maximize();

            //Open url(open google)
            driver.Url = "https://www.123formbuilder.com/free-form-templates/Customer-Satisfaction-Survey-37155/";

            //radio_button[1].Click();

            ReadOnlyCollection<IWebElement> radio_button1 = driver.FindElements(By.Name("c_00000008"));
            radio_button1[0].Click(); 
            Thread.Sleep(2000);
            ReadOnlyCollection<IWebElement> radio_button2 = driver.FindElements(By.Name("c_0000000a"));
            radio_button2[2].Click(); 
            Thread.Sleep(3000);
            //Close Browser
            //driver.Close();
        }
    }
}
