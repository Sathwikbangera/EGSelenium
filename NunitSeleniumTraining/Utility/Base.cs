﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace NunitSeleniumTraining.Utility
{
    public class Base
    {
        public IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            string browserName = ConfigurationManager.AppSettings["browser"];
            InitBrowser(browserName);
            // launch the chrome browser
          driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/register.html");

           // driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            driver.Manage().Window.Maximize();

        }
        public void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":

                    // confifgure the web driver manager to set up the chrome capabilities
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    // intialize the web driver 
                    driver = new FirefoxDriver();
                    break;

                case "Chrome":

                    // confifgure the web driver manager to set up the chrome capabilities
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    // intialize the web driver 
                    driver = new ChromeDriver();
                    break;

                case "Edge":
                    // confifgure the web driver manager to set up the chrome capabilities
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    // intialize the web driver 
                    driver = new ChromeDriver();
                    break;
            }
        }

        [TearDown]
        public void TearDown()
        {

            driver.Close();
        }
    }
}
