using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSeleniumTraining.NUNITests
{
    internal class SetUpTearDown
    {
        [SetUp]
        public void setup()
        {
            Console.WriteLine("Launcing chrome");
        }
        [TearDown]
        public void teardown()
        {
            Console.WriteLine("Closing browser");
        }



        [Test, Order(1)]
        //order numbers
        public void Login()
        {
            Console.WriteLine("Login");

        }
        [Test, Order(2)]
        public void addtoCart()
        {
            Console.WriteLine("add");

        }
        [Test, Order(3)]
        public void products()
        {
            Console.WriteLine("pro");

        }
    }
}
