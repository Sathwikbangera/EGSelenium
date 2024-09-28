using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace NunitSeleniumTraining.Selenium
{
    internal class IFrame
    {
        IWebDriver driver;


       // [SetUp]
        public void startbrowser()
        {

            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            // intialize the web driver 
            driver = new FirefoxDriver();
            // launch the chrome browser
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/iframe");

        }



      //  [Test]
        public void testcase1()
        {
            IWebElement Frame = driver.FindElement(By.XPath("//iframe[@id='mce_0_ifr']"));
            driver.SwitchTo().Frame(Frame);
            Thread.Sleep(3000);

            IWebElement content = driver.FindElement(By.XPath("//p[normalize-space()='Your content goes here.']"));
            content.Clear();
            content.SendKeys("hello we changed!!!");
            Thread.Sleep(3000);
        }


       // [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
