using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using Calc;
using System.Reflection;
using System;

namespace CalcTestProject
{
    [TestClass]
    public class UnitTest1 : Form1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1 f = new Form1();
            double add = Operations.Add(1, 2);
            double addEx = 3;
            Assert.AreEqual(addEx, add);

            double sqr = Operations.Pow(9);
            double sqrEx = 81;
            Assert.AreEqual(sqrEx, sqr);

            double sqrt = Operations.Sqrt(49);
            double sqrtEx = 7;
            Assert.AreEqual(sqrtEx, sqrt);

            if (f.operation == "/" && f.num2 == null || f.num2 == "0")
            {
                f.DivisionWthZeroTried = true;
                Assert.IsTrue(f.DivisionWthZeroTried);
            }
            

        }
    }
}
