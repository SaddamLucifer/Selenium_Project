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
    class CheckBoxDemo_2
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello this is Select from dropdown demo");
            //Launch Browser
            IWebDriver driver = new ChromeDriver("C:\\Users\\sadda\\OneDrive\\Desktop\\Selenium Practice");

            //Maximize browser
            driver.Manage().Window.Maximize();

            //Open url(open google)
            driver.Url = "https://preview.colorlib.com/theme/bootstrap/checkbox-01/";

            //Finding Select box by using 
            IWebElement check_box = driver.FindElement(By.ClassName("col-md-4"));
            //IWebElement check_box1 = driver.FindElement(By.XPath("/html/body/section/div/div[2]/div/label[4]"));
            IWebElement cb = driver.FindElement(By.XPath("input.]"));
            check_box.Click();

            //IWebElement check_box = driver.FindElement(By.Id("1"));
            //Thread.Sleep(2000);
            //check_box.Click();

            //IWebElement check_box1 = driver.FindElement(By.Id("2"));
            //Thread.Sleep(2000);
            //check_box1.Click();

            //IWebElement check_box2 = driver.FindElement(By.Id("3"));
            //Thread.Sleep(2000);
            //check_box2.Click();

            //IWebElement check_box3 = driver.FindElement(By.Id("4"));
            //Thread.Sleep(2000);
            //check_box3.Click();

            //IWebElement check_box4 = driver.FindElement(By.Id("5"));
            //Thread.Sleep(2000);
            //check_box4.Click();

            //IWebElement check_box5 = driver.FindElement(By.Id("6"));
            //Thread.Sleep(2000);
            //check_box5.Click();

            Thread.Sleep(3000);
            //Close Browser
            //driver.Close();
        }
    }
}
