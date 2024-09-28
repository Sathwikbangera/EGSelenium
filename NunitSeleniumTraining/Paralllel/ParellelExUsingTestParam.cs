using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NunitSeleniumTraining.Utility;
using OpenQA.Selenium;

namespace NunitSeleniumTraining.Paralllel
{
  //  [Parallelizable]
    internal class ParellelExUsingTestParam : Base
    {
        
        //[Test, TestCaseSource("GetTestData")]
        //[Parallelizable(ParallelScope.Children)]
        public void LoginTest(string username, string password)
        {
            DateTime currentTime = DateTime.Now;
            string time = currentTime.ToString("yyyy-MM-dd-_HH-mm-ss");
            Console.WriteLine(username + ":" + password + "......." + time);
            Thread.Sleep(5000);

            // Find the element usibg the By class locators 
            IWebElement Username = driver.FindElement(By.Name("username"));
            // inputing text using send keys 
            Username.SendKeys(username);

            Thread.Sleep(2000);

            IWebElement Password = driver.FindElement(By.Name("password"));
            // inputing text using send keys 
            Password.SendKeys(password);


            IWebElement LoginButton = driver.FindElement(By.XPath("//button[@type = 'submit']"));
            LoginButton.Click();

            Thread.Sleep(4000);

            IWebElement Errmsg = driver.FindElement(By.XPath("//div[@class='oxd-alert-content oxd-alert-content--error']"));

            string errmsg = Errmsg.Text;
            Thread.Sleep(4000);

            Console.WriteLine(errmsg);

            Assert.AreEqual("Invalid credentials", errmsg);


        }
        public static IEnumerable<TestCaseData> GetTestData()
        {

            yield return new TestCaseData("abc.com", "gfgfgf");

            yield return new TestCaseData("sds.com", "jnkb");
            yield return new TestCaseData("pram.com", "nmbbjk");

        }
    }
}
