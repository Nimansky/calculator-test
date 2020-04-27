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

        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void pressButton(object sender, EventArgs e)
        {
            int btnnmbr = Convert.ToInt32((sender as Button).Name.Substring(6));
            switch (btnnmbr)
            {
                case 1:
                    moveCursor(1);
                    cs.entersymbol("1", label1);
                    break;
                case 2:
                    moveCursor(1);
                    cs.entersymbol("2", label1);
                    break;
                case 3:
                    moveCursor(1);
                    cs.entersymbol("3", label1);
                    break;
                case 4:
                    moveCursor(1);
                    cs.entersymbol("4", label1);
                    break;
                case 5:
                    moveCursor(1);
                    cs.entersymbol("5", label1);
                    break;
                case 6:
                    moveCursor(1);
                    cs.entersymbol("6", label1);
                    break;
                case 7:
                    moveCursor(1);
                    cs.entersymbol("7", label1);
                    break;
                case 8:
                    moveCursor(1);
                    cs.entersymbol("8", label1);
                    break;
                case 9:
                    moveCursor(1);
                    cs.entersymbol("9", label1);
                    break;
                case 10:
                    moveCursor(1);
                    cs.entersymbol("0", label1);
                    break;
                case 11:
                    moveCursor(5);
                    cs.entersymbol("*10^(", label1);
                    break;
                case 14:
                    moveCursor(1);
                    cs.entersymbol(",", label1);
                    break;
                case 15:
                    moveCursor(1);
                    cs.entersymbol("+", label1);
                    break;
                case 16:
                    moveCursor(1);
                    cs.entersymbol("-", label1);
                    break;
                case 17:
                    moveCursor(1);
                    cs.entersymbol("*", label1);
                    break;
                case 18:
                    moveCursor(1);
                    cs.entersymbol("/", label1);
                    break;
                case 19:
                    if (label1.Text != "")
                    {
                        cs.entersymbol("-1", label1);
                        pictureBox1.Location = new Point(pictureBox1.Location.X - 11, pictureBox1.Location.Y);
                    }
                    break;
                case 20:
                    pictureBox1.Location = new Point(32, pictureBox1.Location.Y);
                    label1.Text = "";
                    break;
                case 21:
                    moveCursor(6);
                    cs.entersymbol("log[](", label1);
                    break;
                case 22:
                    moveCursor(9);
                    cs.entersymbol("∑[n=;x=](", label1);
                    break;
                case 23:
                    moveCursor(9);
                    cs.entersymbol("∏[n=;x=](", label1);
                    break;
                case 24:
                    moveCursor(5);
                    cs.entersymbol("[]/[]", label1);
                    break;
                case 25:
                    moveCursor(5);
                    cs.entersymbol("sqrt(", label1);
                    break;
                case 26:
                    moveCursor(5);
                    cs.entersymbol("[]rt(", label1);
                    break;
                case 27:
                    moveCursor(4);
                    cs.entersymbol("^(2)", label1);
                    break;
                case 28:
                    moveCursor(2);
                    cs.entersymbol("^(", label1);
                    break;
                case 29:
                    moveCursor(4);
                    cs.entersymbol("sin(", label1);
                    break;
                case 30:
                    moveCursor(4);
                    cs.entersymbol("cos(", label1);
                    break;
                case 31:
                    moveCursor(4);
                    cs.entersymbol("tan(", label1);
                    break;
                case 32:
                    moveCursor(7);
                    cs.entersymbol("arcsin(", label1);
                    break;
                case 33:
                    moveCursor(7);
                    cs.entersymbol("arccos(", label1);
                    break;
                case 34:
                    moveCursor(7);
                    cs.entersymbol("arctan(", label1);
                    break;
                case 35:
                    moveCursor(1);
                    cs.entersymbol("!", label1);
                    break;
                case 37:
                    moveCursor(1);
                    cs.entersymbol("(", label1);
                    break;
                case 38:
                    moveCursor(1);
                    cs.entersymbol(")", label1);
                    break;
                case 39:
                    moveCursor(1);
                    cs.entersymbol("e", label1);
                    break;
                case 40:
                    moveCursor(1);
                    cs.entersymbol("π", label1);
                    break;
                case 41:
                    if (pictureBox1.Location.X - 32 > 0) { pictureBox1.Location = new Point(pictureBox1.Location.X - 11, pictureBox1.Location.Y); }
                    break;
                case 42:
                    if (pictureBox1.Location.X - 21 <= label1.Width) { pictureBox1.Location = new Point(pictureBox1.Location.X + 11, pictureBox1.Location.Y); }
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
        }
    }
}
