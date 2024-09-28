using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NunitSeleniumTraining.Utility;
using OpenQA.Selenium;

namespace NunitSeleniumTraining.Assignment
{
    [Allure.NUnit.AllureNUnit]
    [Parallelizable]
    internal class parasoftregister : Base
    {
       // [TestCase("Sjhsddda", "admin123","admin123")]
        //[TestCase("absakjac.com", "12shj334","vaga")]
       // [TestCase("aasbsjbc.com", "12sja334","ahghsjsj")]
        public void register(string user,string pass,string cpass)
        {
            Thread.Sleep(1000);


            IWebElement register = driver.FindElement(By.XPath("//a[normalize-space()='Register']"));
            register.Click();
            Thread.Sleep(1000);

            IWebElement FName = driver.FindElement(By.XPath("//input[@id='customer.firstName']"));
            FName.SendKeys("Sathwik");
            Thread.Sleep(1000);

            IWebElement LName = driver.FindElement(By.XPath("//input[@id='customer.lastName']"));
            LName.SendKeys("Bangera");
            Thread.Sleep(1000);

            IWebElement address = driver.FindElement(By.XPath("//input[@id='customer.address.street']"));
            address.SendKeys("Thodar");
            Thread.Sleep(1000);

            IWebElement city = driver.FindElement(By.XPath("//input[@id='customer.address.city']"));
            city.SendKeys("Moodbdire");
            Thread.Sleep(1000);


            IWebElement state = driver.FindElement(By.XPath("//input[@id='customer.address.state']"));
            state.SendKeys("karnataka");
            Thread.Sleep(1000);

            IWebElement ZipCode = driver.FindElement(By.XPath("//input[@id='customer.address.zipCode']"));
            ZipCode.SendKeys("575007");
            Thread.Sleep(1000);

            IWebElement phone = driver.FindElement(By.XPath("//input[@id='customer.phoneNumber']"));
            phone.SendKeys("9876543210");
            Thread.Sleep(1000);

            IWebElement ssn = driver.FindElement(By.XPath("//input[@id='customer.ssn']"));
            ssn.SendKeys("1234");
            Thread.Sleep(1000);

            IWebElement username = driver.FindElement(By.XPath("//input[@id='customer.username']"));
            username.SendKeys(user);
            Thread.Sleep(1000);

            IWebElement password = driver.FindElement(By.XPath("//input[@id='customer.password']"));
            password.SendKeys(pass);
            Thread.Sleep(1000);

            IWebElement confirmpassword = driver.FindElement(By.XPath("//input[@id='repeatedPassword']"));
            confirmpassword.SendKeys(cpass);
            Thread.Sleep(1000);


            IWebElement registerbtn = driver.FindElement(By.XPath("//input[@value='Register']"));
            registerbtn.Click();
            Thread.Sleep(1000);

            //p[contains(text(),'Your account was created successfully. You are now')]
            IWebElement FileUploadMsg = driver.FindElement(By.XPath("//p[contains(text(),'Your account was created successfully. You are now')]"));

            string textmsg = FileUploadMsg.Text;

            string expectedtext = "Your account was created successfully. You are now logged in.";

            Console.WriteLine(textmsg);

            Assert.AreEqual(textmsg, expectedtext);
        }
      
        public void login()
        {

        }
    }
}
