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
    class NaukariPageDemo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Naukari Registration page Demo");
            //Launching Chrome browser
            IWebDriver driver = new ChromeDriver("C:\\Users\\sadda\\OneDrive\\Desktop\\Selenium Practice");
            driver.Manage().Window.Maximize();

            //Opening URL
            driver.Url = "https://www.naukri.com/account/createaccount";
            driver.FindElement(By.Name("userType")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("fname")).SendKeys("Javid");
            driver.FindElement(By.Name("password")).SendKeys("testing123");
            driver.FindElement(By.Name("number")).SendKeys("7894563210");
            driver.FindElement(By.CssSelector("input.sugInp")).SendKeys("Pune");
            driver.FindElement(By.Name("state")).SendKeys("Maharashtra");

            //IWebElement check_box = driver.FindElement(By.Id("term"));
            //check_box.Click();
            driver.FindElement(By.Name("basicDetailSubmit")).Click();
            //Printing error message
            string errmsg = driver.FindElement(By.Id("email_err")).Text;
            Thread.Sleep(3000);
            Console.WriteLine(errmsg);
            //driver.Close();
            driver.Quit();
        }
        
    }
}
