﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_test
{
    public partial class Form1 : Form
    {

        //make it easier to access our calculatorstuff-methods
        private calculatorstuff cs = new calculatorstuff();

        //declare the current position of the cursor as well as the position in the array, 
        //since they're not the same (e.g. "cos(" is 3 symbols long, array position is 1, but cursor position is 3)
        private int cursorpos = 0;
        private int arraypos = 0;

        public Form1()
        {
            InitializeComponent();

            //Window should not be resizable
            this.SetStyle(ControlStyles.FixedHeight, true);
            this.SetStyle(ControlStyles.FixedWidth, true);

            //disable vertical scroll for label
            panel2.VerticalScroll.Enabled = false;
            pictureBox1.Parent = panel2;

            //clear the label
            label1.Text = "";
        }

        private void pressButton(object sender, EventArgs e)
        {
            //get the attribute "InputSymbol" from the buttons
            string inputsymbol = (sender as calcbutton).InputSymbol;

            //based on the inputsymbol, execute according code
            switch (inputsymbol) {

                //move left and right with the cursor, only if possible
                case "left":
                    if (arraypos > 0) { moveCursor(-1 * cs.getStack()[arraypos - 1].Length); }
                    break;
                case "right":
                    if (arraypos < cs.getStack().Count()) { moveCursor(1 * cs.getStack()[arraypos].Length); }
                    break;

                //delete the symbol to the left of the cursor, if possible
                case "del":
                    if (arraypos != 0)
                    {
                        moveCursor(-1 * cs.getStack()[arraypos - 1].Length);
                        cs.deletesymbol(arraypos, label1);
                    }
                    break;

                //reset the label and stack
                case "reset":
                    moveCursor(-1 * cursorpos);
                    cursorpos = 0;
                    arraypos = 0;
                    cs.clearsymbols(label1);
                    break;

                //calculate, but only if expression isn't empty 
                case "calc":
                    try
                    {
                        if (label1.Text != "")
                        {
                            //also, if Ans is used, check if it has anything stored in it
                            if (label1.Text.Contains("Ans") && Double.IsNaN(cs.Ans()))
                            {
                                throw new Exception("Ans does not currently contain any number");
                            }

                            //clear symbols and display result in label, also move cursor accordingly
                            double result = cs.calculate(label1.Text);
                            moveCursor(-1 * cursorpos);
                            arraypos = 0;
                            cursorpos = 0;
                            cs.clearsymbols(label1);
                            for (int i = 0; i < result.ToString().Length; i++)
                            {
                                cs.entersymbol(result.ToString()[i].ToString(), i, label1);
                                moveCursor(1);
                            }
                        }
                        break;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Invalid input! " + ex.Message);
                        break;
                    }

                //input the wanted symbol and move the cursor to the left accordingly
                default:
                    cs.entersymbol(inputsymbol, arraypos, label1);
                    moveCursor(inputsymbol.Length);
                    break;
            }
        }

        //a timer to make the cursor blink
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (pictureBox1.Visible) {
                case true:
                    pictureBox1.Visible = false;
                    break;
                case false:
                    pictureBox1.Visible = true;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //starting the cursor-blink-timer
            timer1.Start();
        }

        //move the cursor according to the given length of the symbol to be crossed
        private void moveCursor(int length) {

            //generate the new coordinates for the cursor
            pictureBox1.Location = new Point(pictureBox1.Location.X + 11*length, pictureBox1.Location.Y);

            //subtract or add 1 to arraypos based on whether the cursor moved left or right
            if (length > 0)
            {
                arraypos += 1;
            }
            else if(length < 0)
            {
                arraypos -= 1;
            }

            //assign the new cursorpos
            cursorpos += length;

            //scroll to the cursor, so it's always in the current field of view
            panel2.ScrollControlIntoView(pictureBox1);
        }
    }
}
