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
        private List<List<String>> arraylist = new List<List<String>>();
        private List<String> operatorlist = new List<String>();
        private String lastsymbol = "";
        

        public void calculate()
        {
            for (int i = 0; i < arraylist.Count(); i++)
            {
                if (arraylist[i].Contains("Special Expressions and brackets go here"))
                {
                    //Do something with special expressions and brackets
                }
                else
                {
                    //Do something with normal operations
                }
            }
        }

        //Display a given symbol on the calculator and add it to the stack
        public void entersymbol(String input, int pos, Label display)
        {
            stack.Insert(pos, input);

            displayStack(display);

            addToNumArrays(input);

            lastsymbol = input;
        }

        private String encodeNumArray(List<String> input)
        {
            String output = "";
            foreach (String s in input)
            {
                output += s;
            }
            return output;
        }

        private void addToNumArrays(String input)
        {
            if (IsNumberOrExpr(input))
            {
                if (IsNumberOrExpr(lastsymbol) & lastsymbol != "")
                {
                    List<String> temp = arraylist[arraylist.Count - 1];
                    arraylist.RemoveAt(arraylist.Count - 1);
                    temp.Add(input);
                    arraylist.Add(temp);
                }
                else
                {
                    List<String> temp = new List<String>();
                    temp.Add(input);
                    arraylist.Add(temp);
                }
            }
            else
            {
                operatorlist.Add(input);
            }
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

        public Boolean IsNumberOrExpr(String input)
        {
            if (input == "+" | input == "-" | input == "*" | input == "/")
            {
                return false;
            }
            else
            {
                return true;
            }
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
    }
}
