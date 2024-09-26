using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSeleniumTraining.NUNITests
{
    internal class CalculatorUnitTestin
    {
        [SetUp]
        public void setup()
        {
            Console.WriteLine("Launcing chrome");
        }
        Calculator cl=new Calculator();

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
            Console.WriteLine("Closing browser");
        }
    }
}
