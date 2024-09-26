using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSeleniumTraining.NUNITests
{
    internal class Test1
    {
        [SetUp]
        public void setup()
        {
            Console.WriteLine("Launcing chrome");
        }
        [Test]
        public void testcase1()
        {
            Console.WriteLine("This is the first testcase");
        }
        [TearDown]
        public void teardown()
        {
            Console.WriteLine("Closing browser");
        }
    }
}
