using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryAutoTest;

namespace MathCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            MathsHelper calculator = new MathsHelper();
            int r = calculator.Add(3, 7);
            int R = calculator.Subtract(r, -7);
            Console.WriteLine("3 + 7 = {0} 10 - 7 = {1}" + Environment.NewLine + "Press any key...",r,8);
            Console.ReadKey();
        }
    }
}
