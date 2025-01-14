﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace NunitSeleniumTraining.NUNITests
{
   // [Allure.NUnit.AllureNUnit]
    internal class CategoryTesting
    {
        [Test, Category("Regression")]
        public void login()
        {
            Console.WriteLine("lOGGING IN");
        }
        [Test, Category("Sanity"), Category("Regression")]
        public void addtocart()
        {
            Console.WriteLine("added to cart");
        }
        [Test, Ignore("Sanity")]
        public void products()
        {
            Console.WriteLine("selected products");
        }
    }
}
