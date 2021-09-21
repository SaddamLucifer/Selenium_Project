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
    class MultipleSelectDemo_1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello this is Select Multiple from dropdown demo");
            //Launch Browser
            IWebDriver driver = new ChromeDriver("C:\\Users\\sadda\\OneDrive\\Desktop\\Selenium Practice");

            //Maximize browser
            driver.Manage().Window.Maximize();

            //Open url
       
            driver.Url = "https://www.seleniumeasy.com/test/jquery-dual-list-box-demo.html";

            //Finding Select box by using
           
            IWebElement select_box = driver.FindElement(By.CssSelector("select.form-control"));
            //Multiple Select Demo
            SelectElement select = new SelectElement(select_box);

            bool multiple_select = select.IsMultiple;
            Console.WriteLine(multiple_select);

            select.SelectByIndex(1);
            select.SelectByIndex(3);
            select.SelectByIndex(5);
            select.SelectByText("Valentina");
            Console.WriteLine(select.AllSelectedOptions.Count);


            IList<IWebElement> options = select.AllSelectedOptions;
            //Console.WriteLine(select.AllSelectedOptions.Count);

            foreach (IWebElement option in options)
            {
                Console.WriteLine(option.Text);
            }

            driver.FindElement(By.CssSelector("button.pAdd")).Click();
            


            Thread.Sleep(4000);
            //Close Browser
            //driver.Close();
        }
    }
}
