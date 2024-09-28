using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;

namespace NunitSeleniumTraining.Selenium
{
    internal class HotelBooking
    {
        IWebDriver driver;


        [SetUp]
        public void startbrowser()
        {

            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
        
            // intialize the web driver 
            driver = new ChromeDriver();
            // launch the chrome browser
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.booking.com/");

        }




        [Test]
        public void testcase1()
        {
            Thread.Sleep(8000);
            

            IWebElement Close = driver.FindElement(By.XPath("//button[@aria-label='Dismiss sign-in info.']"));
             Close.Click();
            Thread.Sleep(1000);
         
            IWebElement Where = driver.FindElement(By.XPath("//input[@id=':rh:']"));
            Where.Click();
            Thread.Sleep(1000);
            Where.SendKeys("Mangalore");

            IWebElement WHen = driver.FindElement(By.XPath("//div[@class='a1139161bf']"));
            WHen.Click();
            Thread.Sleep(1000);

            IWebElement From = driver.FindElement(By.XPath("//span[@aria-label='25 September 2024']"));
            From.Click();

            IWebElement To = driver.FindElement(By.XPath("//span[@aria-label='28 September 2024']"));
            To.Click();

            IWebElement WHo = driver.FindElement(By.XPath("//button[@class='a83ed08757 ebbedaf8ac dbaff8df6f ada2387af8']"));
            WHo.Click();
            


            IWebElement Search = driver.FindElement(By.XPath("//span[normalize-space()='Search']"));
            Search.Click();

            Thread.Sleep(10000);
        }


        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
