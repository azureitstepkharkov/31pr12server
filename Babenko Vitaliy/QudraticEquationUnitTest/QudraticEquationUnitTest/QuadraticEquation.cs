using System;

namespace QudraticEquationUnitTest
{
    internal class QuadraticEquation
    {
        private double a;
        private double b;
        private double c;

        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool calc(out double x1, out double x2)
        {
            double D = b * b - 4 * a * c;
            x1 = x2 = 0;

            if (D < 0)
                return false;
            x1 = (-b + Math.Sqrt(D)) / (2 * a);
            x2 = (-b - Math.Sqrt(D)) / (2 * a);
            return true;
        }
    }
}