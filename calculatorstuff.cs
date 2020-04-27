using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_test
{
    class calculatorstuff
    {
        public calculatorstuff() {
        }
            
        public void entersymbol(String input, Label display)
        {
            if (input == "-1")
            {
                display.Text = display.Text.Substring(0, display.Text.Length-1);
                
            }
            else
            {
                display.Text += input;
            }
        }
    }
}
