using System;
using System.Collections.Generic;
using System.Text;

namespace Calc
{
    /// <summary>
    /// Class for all the operations that can be done
    /// </summary>
    public class Operations
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
        // I am not sure how this operation works exactly like in the windows 10 calculator, hence I've made it so that it just divide with 100
        public static double Percent(double n1)
        {
            return n1 / 100;
        }
    }
}
