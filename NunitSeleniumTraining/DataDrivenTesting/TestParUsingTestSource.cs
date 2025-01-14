﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSeleniumTraining.DataDrivenTesting
{

    //[Parallelizable]
    
    internal class TestParUsingTestSource
    {
        [Test, TestCaseSource("GetTestData"),Category("register")]
        public void LoginTest(string username, string password)
        {
            Console.WriteLine(username + ":" + password);   

        }
        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData("ad", "admin123");
            yield return new TestCaseData("ad0", "ad");
           yield return new TestCaseData("adm", "ghhjm");
           
        }
    }
}
