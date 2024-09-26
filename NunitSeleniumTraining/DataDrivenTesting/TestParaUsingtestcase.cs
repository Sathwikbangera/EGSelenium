using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NunitSeleniumTraining.Utility;
using OpenQA.Selenium;

namespace NunitSeleniumTraining.DataDrivenTesting
{
    internal class TestParaUsingtestcase :Base
    {
        
        [TestCase("Admin","admin123")]
        [TestCase("absakjac.com", "12shj334")]
        [TestCase("aasbsjbc.com", "12sja334")]
        public void LoginTest(string username, string password)
        {
            Thread.Sleep(2000);
            IWebElement Ussername = driver.FindElement(By.Name("username"));
            Ussername.SendKeys(username);

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys(password);

            /*IWebElement LoginButton = driver.FindElement(By.XPath("//button[@type='submit']"));
            LoginButton.Click();*/
            Thread.Sleep(2000);
        }
    }
}