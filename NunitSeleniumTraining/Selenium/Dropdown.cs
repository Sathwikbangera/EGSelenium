using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;
using NunitSeleniumTraining.Utility;

namespace NunitSeleniumTraining.Selenium
{
    internal class Dropdown : Base
    {
        

       // [Test]
        public void testcase1()
        {
            IWebElement DropDown = driver.FindElement(By.Id("dropdown-class-example"));
            Assert.IsNotNull(DropDown);
            var select =new SelectElement(DropDown);

            //select by visible text
            select.SelectByText("Option2");

            Thread.Sleep(1000); 
            //select by index
            select.SelectByIndex(1);

            //select by attribute value
            Thread.Sleep(2000);
            select.SelectByValue("option3");

            Thread.Sleep(2000);
        }

      
    }
}
