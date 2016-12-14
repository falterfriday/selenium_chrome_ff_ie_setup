using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("test-type");
            string drivePath = (@"C:\testing\chrome\");
            IWebDriver driver = new ChromeDriver(drivePath, option);
            driver.Navigate().GoToUrl("http://www.google.com");
            
            var searchBox = driver.FindElement(By.Id("lst-ib"));
            searchBox.SendKeys("Pandas");

            var searchButton = driver.FindElement(By.Name("btnG"));
            searchButton.Click();

            //if it cant find the element - wait for 10 seconds - then try again
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));

            var imagesLink = driver.FindElements(By.ClassName("q"))[0];
            imagesLink.Click();
        }
    }
}
