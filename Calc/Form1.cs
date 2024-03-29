﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calc
{
    /// <summary>
    /// All the code for the actual calculator and all the buttons etc. This class is where every
    /// event comes. For instance, click, enter, leave etc. This is also where all the code for
    /// what each element does, for example the text within a textbox changes if some conditions are met.
    /// Many exceptions are handeled without needing to use try catch or similar exception handelers
    /// Most of the code is in the class Form1 because all the event handelers is linked to Form1 by default
    /// </summary>

    public partial class Form1 : Form
    {
        public double result = 0;

        // Captures the operation that was pressed
        public string operation = "";

        // If we would enter 2 and then + the text would continue to append to the 2
        // that was entered before the operation instead of resetting the
        // texbox after and appending new numbers to the textbox
        public bool operationPressed = false;

        public string num1, num2;

        public Form1()
        {
            InitializeComponent();
            // Have the visibility false in the form otherwise the recycle bin button will always be visible untill clicked
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

        // Changes the current number to positive/negative number

        private void ChangeSign_Click(object sender, EventArgs e)
        {
            if (TextDisplay.Text != "0" || operationPressed)
            {
                TextDisplay.Text = Operations.ChangeSign(double.Parse(TextDisplay.Text)).ToString();
            }
        }

        // Event for all numbers including dot
        private void Numbers_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            // If the display shows zero then the display will be cleared and if
            // an operation has been pressed then it determinates whether the textbox should be cleared
            if ((TextDisplay.Text == "0") || (operationPressed))
            {
                TextDisplay.Clear();
                TextDisplay.Text += b.Text;
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
                    TextDisplay.Text += b.Text;
                }
            }
            // Otherwise it will just add the numbers that are clicked
            else
            {
                TextDisplay.Text += b.Text;
            }
            // Takes care of that the numbers still work after the divide by zero exception
            if (TextDisplay.Text.Contains("Cannot divide"))
            {
                TextDisplay.Clear();
                // Enables all the button again
                foreach (Button button in DisableEnable)
                {
                    button.Enabled = true;
                }
                LabelEquation.Text = "";
                TextDisplay.Text += b.Text;
            }
            // Takes focus none of the buttons will be focosed keyboard has been used
            LabelFocus.Focus();
        }

        #region operations_Click

        private void BasicOperations_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            // If result is not 0 buttonEqual performs click, this means that if a number was pressed, and then an operator but not a second number
            // then it will just do the operation of the only number that was clicked
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
            // Adds all the buttons that should be disabled if division with 0 is tried
            // Want to do this in a class but don't know how to get elements from Form1.cs add
            // those elements to that class

            DisableEnable.Add(ButtonPlusMinus);
            DisableEnable.Add(ButtonPlus);
            DisableEnable.Add(ButtonMinus);
            DisableEnable.Add(ButtonMultiply);
            DisableEnable.Add(ButtonDivide);
            DisableEnable.Add(ButtonOneDevidedX);
            DisableEnable.Add(ButtonPercent);
            DisableEnable.Add(ButtonPower);
            DisableEnable.Add(ButtonSquareRoot);
            DisableEnable.Add(ButtonDot);
        }

        // Generated outside of a method which gives us access to the list inside of the foreach loops the button
        // needs to be added before the line of code where the list is generated, I'm unsure why but
        // I think it's because division is in the Basic operation method hence why all buttons will be
        // added there since the buttons should only be disabled if division with 0 was tried
        private readonly List<Button> DisableEnable = new List<Button>();

        private void AdvancedOperations_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            // If result is not 0 buttonEqual performs click, this means that if a number was pressed, and then an operator but not a second number
            // then it will just do the operation of the only number that was clicked
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
            // Enables all the button again
            foreach (Button button in DisableEnable)
            {
                button.Enabled = true;
            }
            // If divide by zero exception but backspace is clicked then it will do the same as the clear button does
            if (TextDisplay.Text.Contains("Cannot divide"))
            {
                ButtonC.PerformClick();
            }
        }

        private void ButtonCE_Click(object sender, EventArgs e)
        {
            // Clears entry
            TextDisplay.Text = "0";
            LabelEquation.Text = "";
            // Enables all the button again
            foreach (Button button in DisableEnable)
            {
                button.Enabled = true;
            }
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            // Clears everything, the result will automatically become 0 and a new equation can be started
            TextDisplay.Text = "0";
            result = 0;
            LabelEquation.Text = "";
            // Enables all the button again
            foreach (Button button in DisableEnable)
            {
                button.Enabled = true;
            }
        }

        private void ButtonBin_Click(object sender, EventArgs e)
        {
            // Clears the history if the recycle bin is pressed
            HistoryBox.Clear();
            // Since the recycle bin is cleared the label should show that there is no history
            if (LabelNoHistory.Text == "")
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

            #region switch operations

            // Creates local variable which gives access to the methods in the History class
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
                // Since all the advanced operations performs equal click then they show the operation performed
                // All history.label... takes a label as an argument and this label should be the LabelEquation since in the histoy class
                // we are basically asking "Which label should get this text appended" and we want the text appended to LabelEquation
                // In the History class we have a double n1 which is the number that should be appended. For example if we want to calculate the sqrt(81)
                // we want the labelequation to show that we calculated sqrt(81) and the the result display should show the 9.
                // We also have double n2 which is equivalent of the operation. This mean that n2 is the result of an operation and should immedeatly show the answer of the operation
                // histoy.text... is basically asking "where should we append text" and we want the text to append to the HistoryBox
                case "√":
                    TextDisplay.Text = Operations.Sqrt(double.Parse(TextDisplay.Text)).ToString();
                    // Shows the label equation
                    history.LabelSqrt(LabelEquation, result);
                    // Appends the entered equation to the history windows/textbox
                    history.TextSqrt(HistoryBox, result);
                    break;

                case "x²":
                    TextDisplay.Text = Operations.Pow(double.Parse(TextDisplay.Text)).ToString();
                    // Shows the label equation,
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

            #endregion switch operations

            // new divide exception declared
            DivideByZeroException ex = new DivideByZeroException("Cannot divide by zero");
            // Needs to be here so the if statement within the try catch works
            if (operation == "/" && num2 == null || num2 == "0")
            {
                // This needs to be here otherwise it will append the error message
                // to the richtextbox/HistoryBox
                LabelEquation.Text = num1;
                // Without this line below the Display won't show the message in display
                // when the exception is caught
                TextDisplay.Text = ex.Message;
                // Disables all buttons in the list if division with 0 was tried
                // The disabled buttons cannot that where added to the list cannot be used unless something else,
                // such as a number is pressed. The boolean variable DisableEnableButton is set to true which means
                // that if this condition is met, the foreach shouuld work and show true in the UnitTest
                foreach (Button button in DisableEnable)
                {
                    button.Enabled = false;
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
            catch (Exception errorMessage)
            {
                /// <summary>
                /// If the input was wrong and contains division then the texbox will
                /// show Divide by zero expection.If division was tried then the exception
                /// should be division exception and not the input string however the problem
                /// is that I want to throw this in the if-statement above, if (operation == "/")
                /// however if I throw an exception, the program will stop/break instead which is not what I want to achieve
                /// I want the calculator to just display the divide exception message and not break, but I do not know how to do this so this is the work arund
                /// </summary>
                if (LabelEquation.Text.Contains("/"))
                {
                    TextDisplay.Text = ex.Message;
                }
                else
                {
                    TextDisplay.Text = errorMessage.Message;
                }
            }
            operation = "";

            // Resets the result to 0 which leads to that result won't be stored all the time
            result = 0;
            // Since equal button is pressed then the history will append and you should be able to clear the history if you want to
            ButtonBin.Visible = true;
            // Hides the text "There is no history yet"
            LabelNoHistory.Text = "";
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