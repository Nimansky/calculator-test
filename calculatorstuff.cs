﻿using System;
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

        //Display a given symbol on the calculator and add it to the stack
        public void entersymbol(String input, int pos, Label display)
        {
            stack.Insert(pos, input);

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

            //Again: Refresh the entire label by refilling it from 0, needs to be done so you can delete symbols in the middle of the stack
            //Second variable to prevent automatic panel scrolling from bugging
            String content = "";
            foreach (String s in stack)
            {
                content += s;
            };
            display.Text = content;
        }

        //get the current stack of symbols
        public List<String> getStack()
        {
            return stack;
        }
    }
}
