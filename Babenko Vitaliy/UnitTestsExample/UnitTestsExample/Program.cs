using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = 0.0;
            Assert.AreNotEqual<double>(0.0, A, "A==0");
            
            Console.WriteLine("Press any key");
            Console.ReadKey(true);
        }
    }
}
