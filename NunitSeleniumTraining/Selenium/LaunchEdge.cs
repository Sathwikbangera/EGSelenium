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
    internal class LaunchEdge
    {
        IWebDriver driver;


        [SetUp]
        public void startbrowser()
        {

            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // intialize the web driver 
            driver = new ChromeDriver();


        }

        [Test]
        public void testcase1()
        {
            //launch the browser
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
