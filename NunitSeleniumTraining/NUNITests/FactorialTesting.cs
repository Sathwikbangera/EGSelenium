using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSeleniumTraining.NUNITests
{
  //  [Allure.NUnit.AllureNUnit]
    internal class FactorialTesting
    {

        Factorial fac;
        [SetUp]
        public void setup()
        {
            fac = new Factorial();
            Console.WriteLine("Executing setup");

        }
        [Test]
        public void factTest()
        {
            int result = fac.Fact(5);
            Assert.AreEqual(120, result);
        }
        [TearDown]
        public void teardown()
        {
            Console.WriteLine("All unit tst of Cslculator functionality are executed");
        }
    }
}
