using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSeleniumTraining.NUNITests
{
    internal class Factorial
    {
        
        public int Fact(int x)
        {
            if (x == 0 || x == 1)
            {
                return 1;
            }
            else return x*Fact(x - 1);
        }
    }
}
