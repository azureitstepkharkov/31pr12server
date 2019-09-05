using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathHelperLib;
namespace MathCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            MathHelper calculator = new MathHelper();
            int r = calculator.Add(3, 7);
            int R = calculator.Subtract(r, -7);

            Console.WriteLine($"3 + 7 = {r}; {r} - (-7) = {R}");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);

        }
    }
}
