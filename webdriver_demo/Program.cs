using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;

namespace webdriver_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("test-type");
            string drivePath = (@"C:\testing\chrome\");
            IWebDriver driver = new ChromeDriver(drivePath, option);
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.FindElement(By.Id("lst-ib"));
            driver.Close();
        }
    }
}
