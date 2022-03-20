using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Calc
{
    internal class ButtonEnableDisable
    {
        public void PlusEnabled(Button b)
        {
            b.Enabled = true;
        }
        public void Disabled(Button b)
        {
            b.Enabled = false;
        }
    }
}
