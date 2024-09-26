using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NunitSeleniumTraining.Selenium
{
    internal class RegularExpression
    {
        


        //div[ends-with(@class,'wrapper')]

        //div[contains(@id,'Combined-Shape')]

        //*[@id="//*[name()='path' and @id='Combined-Shape']"]/p

        IWebDriver driver;


        [SetUp]
        public void startbrowser()
        {

            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            // intialize the web driver 
            driver = new EdgeDriver();
            // launch the chrome browser
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/windows");

        }
        [Test]
        public void testcase1()
        {
            IWebElement footer = driver.FindElement(By.XPath("//div[starts-with(@class, 'Footer__')]"));



        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
