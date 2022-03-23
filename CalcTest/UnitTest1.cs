using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using Calc;
using System.Reflection;
using System;

namespace CalcTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double sub = Operations.Sub(10, 4);
            double subEx = 6;
            Assert.AreEqual(subEx, sub);

            double div = Operations.Div(6, 3);
            double divEx = 2;
            Assert.AreEqual(divEx, div);

            double multi = Operations.Mult(10, 20);
            double multiEx = 200;
            Assert.AreEqual(multiEx, multi);

            double add = Operations.Add(1, 2);
            double addEx = 3;
            Assert.AreEqual(addEx, add);

            double sqr = Operations.Pow(9);
            double sqrEx = 81;
            Assert.AreEqual(sqrEx, sqr);

            double sqrt = Operations.Sqrt(49);
            double sqrtEx = 7;
            Assert.AreEqual(sqrtEx, sqrt);

            double oneX = Operations.OneThroughX(200);
            double oneEx = 0.005;
            Assert.AreEqual(oneEx, oneX);

            double percent = Operations.Percent(260);
            double percentEx = 2.6;
            Assert.AreEqual(percentEx, percent);
        }


    }
}
