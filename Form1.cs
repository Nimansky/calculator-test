using System;
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

        private calculatorstuff cs = new calculatorstuff();
        private int cursorpos = 0;
        private int arraypos = 0;

        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.FixedHeight, true);
            this.SetStyle(ControlStyles.FixedWidth, true);
            panel2.VerticalScroll.Enabled = false;
            pictureBox1.Parent = panel2;
            label1.Text = "";
        }

        private void pressButton(object sender, EventArgs e)
        {
            int btnnmbr = Convert.ToInt32((sender as Button).Name.Substring(6));
            switch (btnnmbr)
            {
                case 1:
                    cs.entersymbol("1", arraypos, label1);
                    moveCursor(1);
                    break;
                case 2:
                    cs.entersymbol("2", arraypos, label1);
                    moveCursor(1);
                    break;
                case 3:
                    cs.entersymbol("3", arraypos, label1);
                    moveCursor(1);
                    break;
                case 4:
                    cs.entersymbol("4", arraypos, label1);
                    moveCursor(1);
                    break;
                case 5:
                    cs.entersymbol("5", arraypos, label1);
                    moveCursor(1);
                    break;
                case 6:
                    cs.entersymbol("6", arraypos, label1);
                    moveCursor(1);
                    break;
                case 7:
                    cs.entersymbol("7", arraypos, label1);
                    moveCursor(1);
                    break;
                case 8:
                    cs.entersymbol("8", arraypos, label1);
                    moveCursor(1);
                    break;
                case 9:
                    cs.entersymbol("9", arraypos, label1);
                    moveCursor(1);
                    break;
                case 10:
                    cs.entersymbol("0", arraypos, label1);
                    moveCursor(1);
                    break;
                case 11:
                    cs.entersymbol("*10^(", arraypos, label1);
                    moveCursor(5);
                    break;
                case 12:
                    cs.entersymbol("Ans", arraypos, label1);
                    moveCursor(3);
                    break;
                case 14:
                    cs.entersymbol(",", arraypos, label1);
                    moveCursor(1);
                    break;
                case 15:
                    cs.entersymbol("+", arraypos, label1);
                    moveCursor(1);
                    break;
                case 16:
                    cs.entersymbol("-", arraypos, label1);
                    moveCursor(1);
                    break;
                case 17:
                    cs.entersymbol("*", arraypos, label1);
                    moveCursor(1);
                    break;
                case 18:
                    cs.entersymbol("/", arraypos, label1);
                    moveCursor(1);
                    break;
                case 19:
                    if (arraypos != 0)
                    {
                        moveCursor(-1 * cs.getStack()[arraypos-1].Length);
                        cs.deletesymbol(arraypos-1, label1);
                    }
                    break;
                case 20:
                    moveCursor(-1 * cursorpos);
                    cursorpos = 0;
                    arraypos = 0;
                    cs.clearsymbols(label1);
                    break;
                case 21:
                    cs.entersymbol("log(", arraypos, label1);
                    moveCursor(4);
                    break;
                case 22:
                    cs.entersymbol(")∑(", arraypos, label1);
                    moveCursor(3);
                    break;
                case 23:
                    cs.entersymbol(")∏(", arraypos, label1);
                    moveCursor(3);
                    break;
                case 24:
                    cs.entersymbol(")/(", arraypos, label1);
                    moveCursor(3);
                    break;
                case 25:
                    cs.entersymbol("sqrt(", arraypos, label1);
                    moveCursor(5);
                    break;
                case 26:
                    cs.entersymbol("rt(", arraypos, label1);
                    moveCursor(3);
                    break;
                case 27:
                    cs.entersymbol("^(2)", arraypos, label1);
                    moveCursor(4);
                    break;
                case 28:
                    cs.entersymbol("^(", arraypos, label1);
                    moveCursor(2);
                    break;
                case 29:
                    cs.entersymbol("sin(", arraypos, label1);
                    moveCursor(4);
                    break;
                case 30:
                    cs.entersymbol("cos(", arraypos, label1);
                    moveCursor(4);
                    break;
                case 31:
                    cs.entersymbol("tan(", arraypos, label1);
                    moveCursor(4);
                    break;
                case 32:
                    cs.entersymbol("arcsin(", arraypos, label1);
                    moveCursor(7);
                    break;
                case 33:
                    cs.entersymbol("arccos(", arraypos, label1);
                    moveCursor(7);
                    break;
                case 34:
                    cs.entersymbol("arctan(", arraypos, label1);
                    moveCursor(7);
                    break;
                case 35:
                    cs.entersymbol("!", arraypos, label1);
                    moveCursor(1);
                    break;
                case 36:
                    cs.entersymbol(";", arraypos, label1);
                    moveCursor(1);
                    break;
                case 37:
                    cs.entersymbol("(", arraypos, label1);
                    moveCursor(1);
                    break;
                case 38:
                    cs.entersymbol(")", arraypos, label1);
                    moveCursor(1);
                    break;
                case 39:
                    cs.entersymbol("e", arraypos, label1);
                    moveCursor(1);
                    break;
                case 40:
                    cs.entersymbol("π", arraypos, label1);
                    moveCursor(1);
                    break;
                case 41:
                    if (arraypos > 0) { moveCursor(-1 * cs.getStack()[arraypos-1].Length); }
                    break;
                case 42:
                    if (arraypos < cs.getStack().Count()) { moveCursor(1 * cs.getStack()[arraypos].Length); }
                    break;
                case 43:
                    cs.entersymbol("X", arraypos, label1);
                    moveCursor(1);
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible)
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void moveCursor(int length) {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 11*length, pictureBox1.Location.Y);
            if (length > 0)
            {
                arraypos += 1;
            }
            else if(length < 0)
            {
                arraypos -= 1;
            }
            cursorpos += length;
            panel2.ScrollControlIntoView(pictureBox1);
        }
    }
}
