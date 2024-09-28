using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;

namespace NunitSeleniumTraining.Selenium
{
    internal class Facebook
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
            driver.Navigate().GoToUrl("https://www.facebook.com/login/");

        }



        [Test]
        public void testcase1()
        {

            
            IWebElement Frame = driver.FindElement(By.XPath("//input[@id='email']"));
            Frame.Click();
            new Actions(driver)
                .KeyDown(Keys.Shift)
                .SendKeys("s")
                .KeyUp(Keys.Shift)
                .SendKeys("ath")
                .KeyDown(Keys.Shift)
                .SendKeys("2")
               .KeyUp(Keys.Shift)
               .SendKeys("gmail.com")
                .Perform();
            Thread.Sleep(2000);
        }


        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
