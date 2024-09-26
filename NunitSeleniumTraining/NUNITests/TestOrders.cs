using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSeleniumTraining.NUNITests
{
    internal class TestOrders
    {
        [SetUp]
        public void setup()
        {
            Console.WriteLine("Launcing chrome");
        }
        [Test,Order(0)]
        //order numbers
        public void Login() {
            Console.WriteLine("Login");

        }
        [Test, Order(1)]
        public void addtoCart()
        {
            Console.WriteLine("add");

        }
        [Test, Order(2)]
        public void products()
        {
            Console.WriteLine("pro");

        }
        [TearDown]
        public void teardown()
        {
            Console.WriteLine("Closing browser");
        }
    }
}
