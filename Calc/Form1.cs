using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calc
{
    /// <summary>
    /// All the code for the actual calculator and all the buttons etc. This class is where every
    /// event comes. For instance, click, enter, leave etc. This is also where all the code for
    /// what each element does, for example the text within a textbox changes if some statements
    /// are met
    /// </summary>
    public partial class Form1 : Form
    {
        public double result = 0;
        // Captures the operation that was pressed
        public string operation = "";
        // Used so that the numbers that are pressed, after an operation is pressed,
        // won't append to the same number. Basically if we would enter 2 and then + the text
        // would continue to append to the textbox (the 2) before the + instead of resetting the
        // texbox after and appending new numbers to the textbox
        public bool operationPressed = false;
        public string num1, num2;

        public Form1()
        {
            InitializeComponent();
            // Have the visibility false in the form otherwise the recycle bin button will always be visible untill clicked, which makes it look like the button is inconsistent
            ButtonBin.Visible = false;
        }

        #region Mouse enter/Mouse leave

        // Needs to be a function for each button otherwise the hover effect won't work properly

        private void Button0_MouseEnter(object sender, EventArgs e)
        {
            // Changes background color on mouse enter
            Button0.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void Button0_MouseLeave(object sender, EventArgs e)
        {
            // Changes background color on mouse leave
            Button0.BackColor = Color.FromArgb(6, 6, 6);
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            Button1.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            Button1.BackColor = Color.FromArgb(6, 6, 6);
        }

        private void Button2_MouseEnter(object sender, EventArgs e)
        {
            Button2.BackColor = Color.FromArgb(54, 52, 52);
        }

        private void Button2_MouseLeave(object sender, EventArgs e)
        {
            Button2.BackColor = Color.FromArgb(6, 6, 6);
        }

        private void Button3_MouseEnter(object sender, EventArgs e)
        {
            Button3.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void Button3_MouseLeave(object sender, EventArgs e)
        {
            Button3.BackColor = Color.FromArgb(6, 6, 6);
        }

        private void Button4_MouseEnter(object sender, EventArgs e)
        {
            Button4.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void Button4_MouseLeave(object sender, EventArgs e)
        {
            Button4.BackColor = Color.FromArgb(6, 6, 6);
        }

        private void Button5_MouseEnter(object sender, EventArgs e)
        {
            Button5.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void Button5_MouseLeave(object sender, EventArgs e)
        {
            Button5.BackColor = Color.FromArgb(6, 6, 6);
        }

        private void Button6_MouseEnter(object sender, EventArgs e)
        {
            Button6.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void Button6_MouseLeave(object sender, EventArgs e)
        {
            Button6.BackColor = Color.FromArgb(6, 6, 6);
        }

        private void Button7_MouseEnter(object sender, EventArgs e)
        {
            Button7.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void Button7_MouseLeave(object sender, EventArgs e)
        {
            Button7.BackColor = Color.FromArgb(6, 6, 6);
        }

        private void Button8_MouseEnter(object sender, EventArgs e)
        {
            Button8.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void Button8_MouseLeave(object sender, EventArgs e)
        {
            Button8.BackColor = Color.FromArgb(6, 6, 6);
        }

        private void Button9_MouseEnter(object sender, EventArgs e)
        {
            Button9.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void Button9_MouseLeave(object sender, EventArgs e)
        {
            Button9.BackColor = Color.FromArgb(6, 6, 6);
        }

        // Operator buttons
        private void ButtonPlusMinus_MouseEnter(object sender, EventArgs e)
        {
            ButtonPlusMinus.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void ButtonPlusMinus_MouseLeave(object sender, EventArgs e)
        {
            ButtonPlusMinus.BackColor = Color.FromArgb(6, 6, 6);
        }

        private void ButtonDot_MouseEnter(object sender, EventArgs e)
        {
            ButtonDot.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void ButtonDot_MouseLeave(object sender, EventArgs e)
        {
            ButtonDot.BackColor = Color.FromArgb(6, 6, 6);
        }

        private void ButtonEqual_MouseEnter(object sender, EventArgs e)
        {
            ButtonEqual.BackColor = Color.FromArgb(213, 3, 87);
        }

        private void ButtonEqual_MouseLeave(object sender, EventArgs e)
        {
            ButtonEqual.BackColor = Color.FromArgb(112, 19, 56);
        }

        private void ButtonPlus_MouseEnter(object sender, EventArgs e)
        {
            ButtonPlus.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void ButtonPlus_MouseLeave(object sender, EventArgs e)
        {
            ButtonPlus.BackColor = Color.FromArgb(19, 19, 19);
        }

        private void ButtonMinus_MouseEnter(object sender, EventArgs e)
        {
            ButtonMinus.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void ButtonMinus_MouseLeave(object sender, EventArgs e)
        {
            ButtonMinus.BackColor = Color.FromArgb(19, 19, 19);
        }

        private void ButtonMultiply_MouseEnter(object sender, EventArgs e)
        {
            ButtonMultiply.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void ButtonMultiply_MouseLeave(object sender, EventArgs e)
        {
            ButtonMultiply.BackColor = Color.FromArgb(19, 19, 19);
        }

        private void ButtonDivide_MouseEnter(object sender, EventArgs e)
        {
            ButtonDivide.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void ButtonDivide_MouseLeave(object sender, EventArgs e)
        {
            ButtonDivide.BackColor = Color.FromArgb(19, 19, 19);
        }

        private void ButtonSquareRoot_MouseEnter(object sender, EventArgs e)
        {
            ButtonSquareRoot.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void ButtonSquareRoot_MouseLeave(object sender, EventArgs e)
        {
            ButtonSquareRoot.BackColor = Color.FromArgb(19, 19, 19);
        }

        private void ButtonPower_MouseEnter(object sender, EventArgs e)
        {
            ButtonPower.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void ButtonPower_MouseLeave(object sender, EventArgs e)
        {
            ButtonPower.BackColor = Color.FromArgb(19, 19, 19);
        }

        private void ButtonOneDevidedX_MouseEnter(object sender, EventArgs e)
        {
            ButtonOneDevidedX.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void ButtonOneDevidedX_MouseLeave(object sender, EventArgs e)
        {
            ButtonOneDevidedX.BackColor = Color.FromArgb(19, 19, 19);
        }

        // Functional button
        private void ButtonRemove_MouseEnter(object sender, EventArgs e)
        {
            ButtonBackSpace.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void ButtonRemove_MouseLeave(object sender, EventArgs e)
        {
            ButtonBackSpace.BackColor = Color.FromArgb(19, 19, 19);
        }

        private void ButtonC_MouseEnter(object sender, EventArgs e)
        {
            ButtonC.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void ButtonC_MouseLeave(object sender, EventArgs e)
        {
            ButtonC.BackColor = Color.FromArgb(19, 19, 19);
        }

        private void ButtonCE_MouseEnter(object sender, EventArgs e)
        {
            ButtonCE.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void ButtonCE_MouseLeave(object sender, EventArgs e)
        {
            ButtonCE.BackColor = Color.FromArgb(19, 19, 19);
        }

        private void ButtonPercent_MouseEnter(object sender, EventArgs e)
        {
            ButtonPercent.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void ButtonPercent_MouseLeave(object sender, EventArgs e)
        {
            ButtonPercent.BackColor = Color.FromArgb(19, 19, 19);
        }

        private void ButtonBin_MouseEnter(object sender, EventArgs e)
        {
            ButtonBin.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void ButtonBin_MouseLeave(object sender, EventArgs e)
        {
            ButtonBin.BackColor = Color.FromArgb(31, 31, 31);
        }

        // Labels
        private void LabelNav_MouseEnter(object sender, EventArgs e)
        {
            LabelNav.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void LabelNav_MouseLeave(object sender, EventArgs e)
        {
            LabelNav.BackColor = Color.FromArgb(31, 31, 31);
        }

        private void LabelHistory_MouseEnter(object sender, EventArgs e)
        {
            LabelHistory.ForeColor = Color.FromArgb(145, 145, 145);
        }

        private void LabelHistory_MouseLeave(object sender, EventArgs e)
        {
            LabelHistory.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void LabelMemory_MouseEnter(object sender, EventArgs e)
        {
            LabelMemory.ForeColor = Color.FromArgb(145, 145, 145);
        }

        private void LabelMemory_MouseLeave(object sender, EventArgs e)
        {
            LabelMemory.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void BUttonBin_MouseEnter(object sender, EventArgs e)
        {
            ButtonBin.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void LabelBin_MouseLeave(object sender, EventArgs e)
        {
            ButtonBin.BackColor = Color.FromArgb(31, 31, 31);
        }

        #endregion Mouse enter/Mouse leave
        // Own click event because I don't know how to apply this in Numbers_Click
        private void ChangeSign_Click(object sender, EventArgs e)
        {
            if (TextDisplay.Text != "0" || operationPressed)
            {
                TextDisplay.Text = Operations.ChangeSign(double.Parse(TextDisplay.Text)).ToString();
            }
        }
        private void Numbers_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            // If the display shows zero then the display will be cleared and if
            // an operation has been pressed then it determinates whether the textbox should be cleared
            if ((TextDisplay.Text == "0") || (operationPressed))
            {
                TextDisplay.Clear();
                TextDisplay.Text += TextDisplay.Text + b.Text;
                operationPressed = false;
            }
            // Want to check if the text of the button is a decimal
            else if (b.Text == "." && TextDisplay.Text == "0")
            {
                // if the text of the button is a decimal then this if-statement checks whether the display already contains a decimal or not
                // and if the dispaly does not contain a decimal, then a decimal can be added
                // Want to make sure that the 0 still stays if the decimal is pressed, however, I do not know how to do this
                if (!TextDisplay.Text.Contains("."))
                {
                    TextDisplay.Text += TextDisplay.Text + b.Text;
                }
            }
            // Otherwise it will just add the numbers that are clicked
            else
            {
                TextDisplay.Text += b.Text;
            }

            

            // Takes focus so that the enter button on the keyboard is not focused by any other button
            LabelFocus.Focus();
        }

        #region operations_Click



        private void BasicOperations_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            // If result is not 0 buttonEqual performs click and operationPressed is true and b.text will become the string operation

            if (result != 0)
            {
                ButtonEqual.PerformClick();
                operationPressed = true;
                operation = b.Text;
            }

            operation = b.Text;

            result = double.Parse(TextDisplay.Text);
            operationPressed = true;
            // The label will show the result and the operation

            LabelEquation.Text = result + " " + operation;

            num1 = LabelEquation.Text;
        }

        private void AdvancedOperations_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            // If result is not 0 buttonEqual performs click and operationPressed is true and b.text will become the string operation
            if (result != 0)
            {
                // performs click because when any of the advanced operator is clicked the display and label equation should change
                // immediatly, however not append any text to the textbox unless the equal button is clicked but I do not know how to
                // do this properly since the calculator will append the wrong answer if the equal button is clicked, hence I let the equal button
                // perform click as soon as one of the advanced operators are clicked
                ButtonEqual.PerformClick();
                operationPressed = true;
                operation = b.Text;
            }
            operation = b.Text;
            result = double.Parse(TextDisplay.Text);
            operationPressed = true;
            num1 = TextDisplay.Text;
            if (b.Text != "")
            {
                ButtonEqual.PerformClick();
            }
        }

        #endregion operations_Click

        private void ButtonCE_Click(object sender, EventArgs e)
        {
            // Clears entry
            TextDisplay.Text = "0";
            LabelEquation.Text = "";
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            // Clears everything, the result will automatically become 0 and a new equation can be started
            TextDisplay.Text = "0";
            result = 0;
            LabelEquation.Text = "";
        }

        private void ButtonBin_Click(object sender, EventArgs e)
        {
            // Clears the history if the recycle bin is pressed
            HistoryBox.Clear();
            // Since the recycle bin is cleared the label should show that there is no history             if (LabelNoHistory.Text == "")
            {
                LabelNoHistory.Text = "There's no history yet";
            }
            // Won't be able to see the recycle bin and there will be no scrollbar when the recycle bin is pressed
            ButtonBin.Visible = false;
            HistoryBox.ScrollBars = 0;
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            num2 = TextDisplay.Text;
            LabelEquation.Text = result + " " + operation + " " + TextDisplay.Text + " =";
            operationPressed = false;

            // Switch statement for every operation and the operations is taken from a separate class

            #region switch statement

            History history = new History();
            switch (operation)
            {
                case "+":
                    TextDisplay.Text = Operations.Add(result, double.Parse(TextDisplay.Text)).ToString();
                    break;

                case "-":
                    TextDisplay.Text = Operations.Sub(result, double.Parse(TextDisplay.Text)).ToString();
                    break;

                case "x":
                    TextDisplay.Text = Operations.Mult(result, double.Parse(TextDisplay.Text)).ToString();
                    break;

                case "/":
                    TextDisplay.Text = Operations.Div(result, double.Parse(TextDisplay.Text)).ToString();
                    break;
                // Since all the advanced operations performs the equal click then they show the equation click
                case "√":
                    TextDisplay.Text = Operations.Sqrt(double.Parse(TextDisplay.Text)).ToString();
                    // Shows the label equation
                    history.LabelSqrt(LabelEquation, result);
                    // Appends the entered equation to the history windows/textbox
                    history.TextSqrt(HistoryBox, result);
                    break;
                case "x²":
                    TextDisplay.Text = Operations.Pow(double.Parse(TextDisplay.Text)).ToString();
                    // Shows the label equation
                    history.LabelPow(LabelEquation, double.Parse(num2));
                    // Appends the entered equation to the history windows/textbox
                    history.TextPow(HistoryBox, double.Parse(num2));
                    break;

                case "1/x":
                    TextDisplay.Text = Operations.OneThroughX(double.Parse(TextDisplay.Text)).ToString();
                    // Shows the label equation
                    history.LabelOneThroughX(LabelEquation, result);
                    // Appends the entered equation to the history windows/textbox
                    history.TextOneThroughX(HistoryBox, result);
                    break;
                case "%":
                    TextDisplay.Text = Operations.Percent(double.Parse(TextDisplay.Text)).ToString();
                    // Shows the label equation
                    history.LabelPercent(LabelEquation, result);
                    // Appends the entered equation to the history windows/textbox
                    history.TextPercent(HistoryBox, result);
                    break;
                default:
                    break;
            } // End of switch

            #endregion switch statement

            // If the entered equation is one of the basic operations

            //DivideByZeroException ex = new DivideByZeroException("Cannot divide by zero");
            DivideByZeroException DivZero = new DivideByZeroException("Cannot divide by zero");

            if (operation == "/")
            {
                // This needs to be here otherwise it will append the error message
                // to the richtextbox/HistoryBox
                if (num2 == null || num2 == "0")
                {
                    TextDisplay.Text = "";
                    LabelEquation.Text = num1;
                }
            }
            // This if statement is here since all of these "basic operations" should
            // append the same text and I did not want to write this in the class and
            // in the switch statement, hence I created a else if statement
            else if (operation == "+" || operation == "-" || operation == "x" || operation == "/")
            {
                HistoryBox.AppendText(LabelEquation.Text + "\n");
                HistoryBox.AppendText("\t" + TextDisplay.Text + "\n\n");
            }
            // Tries the result

            try
            {
                result = double.Parse(TextDisplay.Text);
            }
            // Catch expection if result was wrong input
            catch (Exception ex)
            {
                // If the input was wrong and contains division then the texbox will
                // show Divide by zero expection
                if (LabelEquation.Text.Contains("/"))
                {
                    TextDisplay.Text = DivZero.Message;
                }
                // Otherwise it will just show the normal exception error
                else
                {
                    TextDisplay.Text = ex.Message;
                }
            }

            operation = "";

            // Resets the result to 0 which leads to that result won't be stored all the time
            result = 0;
            // Since equal button is pressed then the history will append and you should be able to clear the history if you want to
            ButtonBin.Visible = true;

            LabelNoHistory.Text = "";
        }

        private void ButtonBackSpace_Click(object sender, EventArgs e)
        {
            // If the display text is greater than 0
            if (TextDisplay.Text.Length > 0)
            {
                // Then remove the last button
                TextDisplay.Text = TextDisplay.Text.Remove(TextDisplay.Text.Length - 1, 1);
            }
            // If all the numbers are removed with backspace then there should be a 0 shown
            if (TextDisplay.Text == "")
            {
                TextDisplay.Text = "0";
            }
        }




        #region Keyboard inputs

        private void Buttons_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Did if statement since keychar cannot be converted to string. Explicit casting 
            // the Keys.Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                ButtonEqual.PerformClick();
            }
            // Needs to be converted to string since the cases are string
            switch (e.KeyChar.ToString())
            {
                case "0":
                    Button0.PerformClick();
                    break;

                case "1":
                    Button1.PerformClick();
                    break;

                case "2":
                    Button2.PerformClick();
                    break;

                case "3":
                    Button3.PerformClick();
                    break;

                case "4":
                    Button4.PerformClick();
                    break;

                case "5":
                    Button5.PerformClick();
                    break;

                case "6":
                    Button6.PerformClick();
                    break;

                case "7":
                    Button7.PerformClick();
                    break;

                case "8":
                    Button8.PerformClick();
                    break;

                case "9":
                    Button9.PerformClick();
                    break;

                case ".":
                    ButtonDot.PerformClick();
                    break;

                case "+":
                    ButtonPlus.PerformClick();
                    break;

                case "-":
                    ButtonMinus.PerformClick();
                    break;

                case "x":
                    ButtonMultiply.PerformClick();
                    break;

                case "/":
                    ButtonDivide.PerformClick();
                    break;

                case "=":
                    ButtonEqual.PerformClick();
                    break;

                default:
                    break;
            }
        }

        #endregion Keyboard inputs
    }
}