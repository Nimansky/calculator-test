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

        //Create a stack of symbols for the calculator display
        private List<String> stack = new List<String>();

        //the last result stored in a variable
        private Double _ans = Double.NaN;

        public double calculate(String input)
        {
            //create the context and refer to the math functions
            Methods lib = new Methods(_ans);
            Context context = new Context(lib);

            //store the result and return it
            _ans = Parser.Parse(input, context).Eval(context);
            return _ans;
        }

        //get the last result
        public Double Ans()
        {
            return _ans;
        }

        //Display a given symbol on the calculator and add it to the stack
        public void entersymbol(String input, int pos, Label display)
        {
            stack.Insert(pos, input);
            displayStack(display);
        }

        private void displayStack(Label display)
        {
            //Refresh the entire label by refilling it from 0, so it also works if you insert a symbol in the middle of the stack
            //This needs to be done via a second variable because otherwise, the automatic panel scrolling would malfunction
            String content = "";
            foreach (String s in stack)
            {
                content += s;
            };
            display.Text = content;
        }

        //Clear the stack and the label
        public void clearsymbols(Label display)
        {
            stack.Clear();
            display.Text = "";
        }

        //delete the symbol left to the cursor
        public void deletesymbol(int pos, Label display)
        {
            stack.RemoveAt(pos);
            displayStack(display);
        }

        //get the current stack of symbols
        public List<String> getStack()
        {
            return stack;
        }

        //calculate the factorial of an input number via for-loop
        public double factorial(int input)
        {
            double result = 1;
            for (int i = 1; i<=input; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
