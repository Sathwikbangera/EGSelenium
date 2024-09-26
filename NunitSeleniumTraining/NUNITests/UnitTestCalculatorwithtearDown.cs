using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSeleniumTraining.NUNITests
{
    internal class UnitTestCalculatorwithtearDown
    {
        public Calculator cl;
        [SetUp]
        public void setup()
        {
            cl = new Calculator();
            Console.WriteLine("Executing setup");

        }
        [Test]
        public void AddTest()
        {
            int result = cl.Add(2, 3);
            int result1 = cl.Add(3, -4);
            //Assertion
            Assert.AreEqual(-1, result1);

            Assert.AreEqual(5, result);

        }
        [Test]
        public void MulTest()
        {
            int result = cl.Mul(2, 3);
            int result1 = cl.Mul(3, 4);
            //Assertion
            Assert.AreEqual(12, result1);

            Assert.AreEqual(6, result);

        }
        [TearDown]
        public void teardown()
        {
            Console.WriteLine("All unit tst of Cslculator functionality are executed");
        }

    }
}
