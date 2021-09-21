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
    class RadioButtonDemo
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello this is Radio Button demo");
            //Launch Browser
            IWebDriver driver = new ChromeDriver("C:\\Users\\sadda\\OneDrive\\Desktop\\Selenium Practice");

            //Maximize browser
            driver.Manage().Window.Maximize();

            //Open url(open google)
            driver.Url = "https://www.seleniumeasy.com/test/basic-radiobutton-demo.html";


            //IWebElement radio_button = driver.FindElement(By.Name("optradio"));
            //IWebElement radio_button = driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[1]/div[2]/label[2]/input"));
            //IWebElement radio_button = driver.FindElement(By.CssSelector("input[value=Female]"));
            //ReadOnlyCollection<IWebElement> radio_button = driver.FindElements(By.Name("optradio"));


            //radio_button[1].Click();

            ReadOnlyCollection<IWebElement> radio_button1 = driver.FindElements(By.Name("gender"));
            radio_button1[0].Click(); //c_00000008
            Thread.Sleep(2000);
            ReadOnlyCollection<IWebElement> radio_button2 = driver.FindElements(By.Name("ageGroup"));
            radio_button2[2].Click(); //c_0000000a
            Thread.Sleep(3000);
            //Close Browser
            //driver.Close();
        }
    }
}
