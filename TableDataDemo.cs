using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_Project
{
    class TableDataDemo
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Chrome browser is launched");
            //Launch Browser
            //IWebDriver driver = new ChromeDriver("C:\\Users\\sadda\\OneDrive\\Desktop\\Selenium Practice");
            IWebDriver driver = new ChromeDriver();
            //Maximize browser
            driver.Manage().Window.Maximize();
            
            //Open url(open google)
            driver.Url = "https://www.techlistic.com/p/demo-selenium-practice.html";

            Console.WriteLine("Table Headings");
            ReadOnlyCollection<IWebElement> headings = driver.FindElements(By.XPath("//table[@class='tsc_table_s13']/thead//tr/th"));
            Console.WriteLine(headings.Count);
            foreach (IWebElement heading in headings)
            {
                Console.WriteLine(heading.Text);
            }

            ReadOnlyCollection<IWebElement> no_rows = driver.FindElements(By.XPath("//table[@class='tsc_table_s13']/tbody//tr"));
            Console.WriteLine(no_rows.Count);
            for (int row = 1; row<=no_rows.Count ; row++)
            {
                ReadOnlyCollection<IWebElement> data_cells = driver.FindElements(By.XPath("//table[@class='tsc_table_s13']/tbody//tr["+row+"]/td"));
                Console.WriteLine("No of cells for row: "+row+"is"+data_cells.Count);
                Console.WriteLine("Table Data");
                foreach (IWebElement cell in data_cells)
                {
                    Console.WriteLine(cell.Text);
                }
            }


            Thread.Sleep(3000);
            //Close Browser
            driver.Quit();
        }
    }
}
