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
    class MultipleSelectDemo
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello this is Select Multiple from dropdown demo");
            //Launch Browser
            IWebDriver driver = new ChromeDriver("C:\\Users\\sadda\\OneDrive\\Desktop\\Selenium Practice");

            //Maximize browser
            driver.Manage().Window.Maximize();

            //Open url
       
            driver.Url = "https://www.seleniumeasy.com/test/basic-select-dropdown-demo.html";

            //Finding Select box by using Name
            IWebElement select_box = driver.FindElement(By.Name("States"));

            SelectElement select = new SelectElement(select_box);
            //Select is multiple  or not
            Boolean status_multiple = select.IsMultiple;
            Console.WriteLine(status_multiple); //Prints true or false

            //Selecting elements by index, value and name
            select.SelectByIndex(4);
            select.SelectByValue("California");
            select.SelectByText("New Jersey");

            //de-selecting values
            //select.DeselectAll();
            select.DeselectByIndex(0);

            Thread.Sleep(3000);
            //Close Browser
            //driver.Close();
        }
    }
}
