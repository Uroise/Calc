using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc;

namespace CalcTest
{
    [TestClass]
    public class UnitTest1 : Form1
    {
        [TestMethod]
        public void TestMethod1()
        {
            if (LabelNoHistory.Text == "")
            {
                LabelNoHistory.Text = "There's no history yet";
            }
            // Won't be able to see the recycle bin and there will be no scrollbar when the recycle bin is pressed
            ButtonBin.Visible = false;
            HistoryBox.ScrollBars = 0;
        }
    }
}
