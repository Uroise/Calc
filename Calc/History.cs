using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace Calc
{
    /// <summary>
    /// Class for the history and the label
    /// Adhere, this class is saved as a form/new solution because I've created new labels 
    /// and new RichTextBoxes
    /// </summary>
    public class History 
    {
        public double historyResult;
        public void LabelSqrt(Label l, double n1)
        {
            l.Text = "√(" + n1 + ") = ";
        }
        public void TextSqrt(RichTextBox t, double n2)
        {
            historyResult = Operations.Sqrt(n2);
            t.AppendText("√(" + n2 + ") = \n");
            t.AppendText("\t" + historyResult + "\n\n");

        }
        public void LabelPow(Label l, double n1)
        {
            l.Text = "sqr(" + n1 + ") = ";
        }
        public void TextPow(RichTextBox t, double n2)
        {
            historyResult = Operations.Pow(n2);
            t.AppendText("sqr(" + n2 + ") = \n");
            t.AppendText("\t" + historyResult + "\n\n");
        }
        public void LabelOneThroughX(Label l, double n1)
        {
            l.Text = "1/(" + n1 + ") = ";
        }
        public void TextOneThroughX(RichTextBox t, double n2)
        {
            historyResult = Operations.OneThroughX(n2);
            t.AppendText("1/(" + n2 + ") = \n");
            t.AppendText("\t" + historyResult + "\n\n");
        }
        public void LabelPercent(Label l, double n1)
        {
            l.Text = n1 + "/(100) =";
        }
        public void TextPercent(RichTextBox t, double n2)
        {
            historyResult = Operations.Percent(n2);
            t.AppendText(n2 + "/(100) = \n");
            t.AppendText("\t" + historyResult + "\n\n");
        }
    }
}
