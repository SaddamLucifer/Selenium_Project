using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_Project
{
    class InputText
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            IWebDriver driver = new ChromeDriver("C:\\Users\\sadda\\OneDrive\\Desktop\\Selenium Practice");
            driver.Manage().Window.Maximize();

            //Open url
            driver.Url = "http://demo.automationtesting.in/Frames.html";

            //driver.SwitchTo().Frame(0);//By Indexstarts with 0
            //driver.SwitchTo().Frame("SingleFrame");//By name
            IWebElement frame = driver.FindElement(By.Id("singleframe")); //using IWebElement
            driver.SwitchTo().Frame(frame);
            driver.FindElement(By.XPath("/html/body/section/div/div/div/input")).SendKeys("Javid");
            

            Thread.Sleep(3000);
            
            //driver.Quit();
        }
    }
}
