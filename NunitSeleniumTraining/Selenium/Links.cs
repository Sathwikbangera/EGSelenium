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
    internal class Links
    {
        
        ChromeDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // initialized driver
            chromeDriver = new ChromeDriver();

            chromeDriver.Navigate().GoToUrl("https://www.selenium.dev/");

            chromeDriver.Manage().Window.Maximize();
        }


        [Test]
        public void test()
        {
            IReadOnlyList<IWebElement> elements = chromeDriver.FindElements(By.TagName("a"));

            foreach (IWebElement element in elements)
            {
                Console.WriteLine(element.Text + " The URL is " + element.GetAttribute("href"));
            }

        }

        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(5000);
            chromeDriver.Dispose();
        }
    }
}
