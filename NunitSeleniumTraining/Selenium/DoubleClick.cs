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
using OpenQA.Selenium.Firefox;

namespace NunitSeleniumTraining.Selenium
{
    internal class DoubleClick
    {
        

            IWebDriver driver;

            [SetUp]

            public void StartBrowser()

            {

                // confifgure the web driver manager to set up the chrome capabilities

                new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

                // intialize the web driver 

                driver = new FirefoxDriver();

                // launch the forefox browser

                driver.Navigate().GoToUrl("https://www.amazon.in/");

                driver.Manage().Window.Maximize();

            }

            [Test]

            public void testcase1()

            {


                IWebElement TdyDeal = driver.FindElement(By.XPath("//a[contains(text(),\"Today's Deals\")]"));

                new Actions(driver)

                  .DoubleClick(TdyDeal)

                  .Perform();

                Thread.Sleep(1000);



            }

            [TearDown]

            public void tearDownbrowser()

            {

                driver.Close();

            }


        }

    
}
