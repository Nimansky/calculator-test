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

        private List<String> stack = new List<String>();
       
        public calculatorstuff() {
            
        }

        public void entersymbol(String input, int pos, Label display)
        {
            display.Text = "";
            stack.Insert(pos, input);
            foreach (String s in stack) {
                display.Text += s;
            };
        }

        public void clearsymbols(Label display)
        {
            stack.Clear();
            display.Text = "";
        }

        public void deletesymbol(int pos, Label display)
        {
            stack.RemoveAt(pos+1);
            display.Text = "";
            foreach (String s in stack)
            {
                display.Text += s;
            };
        }

        public List<String> getStack()
        {
            return stack;
        }
    }
}
