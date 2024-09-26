using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSeleniumTraining.NUNITests
{
    internal class Calculator
    {
 
        public int Add(int x, int y)
        {
            int c = x + y;
            return c;
        }
        public int Sub(int x, int y)
        {
            int c = x - y;
            return c;
        }
        public int Mul(int x, int y)
        {
            int c = x * y;
            return c;
        }
        public int Div(int x, int y)
        {
            int c = x / y;
            return c;
        }

    }
}
