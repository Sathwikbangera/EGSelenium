using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSeleniumTraining.NUNITests
{
   // [Allure.NUnit.AllureNUnit]
    internal class Assertion
    {
        [Test]
        public void testassertion()
        {
            string actual = "google";
            string expected = "yahoo";
            //if (actual == expected)
            //{
            //    Console.WriteLine("the results are matching");
            //}
            //else
            //{
            //    Console.WriteLine("the results are not matching");
            //}

            //assert equal
            //Assert.AreEqual(expected, actual);
            Assert.AreNotEqual(actual, expected);

            //assert that
            //Assert.That(actual, Is.EqualTo(expected));
            Assert.That(actual, Is.Not.EqualTo(expected));

            //assert for string ignore case


        }
    }
}
