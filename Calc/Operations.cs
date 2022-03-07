using System;
using System.Collections.Generic;
using System.Text;

namespace Calc
{
    internal class Operations
    {
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }
        public static double Sub(double n1, double n2)
        {
            return n1 - n2;
        }
        public static double Mult(double n1, double n2)
        {
            return n1 * n2;
        }
        public static double Div(double n1, double n2)
        {
            return n1 / n2;
        }
        public static double Sqrt(double n1)
        {
            return Math.Sqrt(n1);
        }
        public static double Pow(double n1)
        {
            return Math.Pow(n1, 2);
        }
        public static double OneThroughX(double n1)
        {
            return 1 / n1;
        }
    }
}
