using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSeleniumTraining.NUNITests
{
    internal class Description
    {
        [Test]
        [Description("testcase verifies the login functinality with valid credentials")]
        public void testcase1()
        {
            Console.WriteLine("this is the first testcase");
        }
    }
}
