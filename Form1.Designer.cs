namespace calculator_test
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button43 = new calculator_test.calcbutton();
            this.button36 = new calculator_test.calcbutton();
            this.button42 = new calculator_test.calcbutton();
            this.button41 = new calculator_test.calcbutton();
            this.button40 = new calculator_test.calcbutton();
            this.button39 = new calculator_test.calcbutton();
            this.button38 = new calculator_test.calcbutton();
            this.button37 = new calculator_test.calcbutton();
            this.button35 = new calculator_test.calcbutton();
            this.button34 = new calculator_test.calcbutton();
            this.button33 = new calculator_test.calcbutton();
            this.button32 = new calculator_test.calcbutton();
            this.button31 = new calculator_test.calcbutton();
            this.button30 = new calculator_test.calcbutton();
            this.button29 = new calculator_test.calcbutton();
            this.button28 = new calculator_test.calcbutton();
            this.button27 = new calculator_test.calcbutton();
            this.button26 = new calculator_test.calcbutton();
            this.button25 = new calculator_test.calcbutton();
            this.button24 = new calculator_test.calcbutton();
            this.button23 = new calculator_test.calcbutton();
            this.button22 = new calculator_test.calcbutton();
            this.button21 = new calculator_test.calcbutton();
            this.button20 = new calculator_test.calcbutton();
            this.button19 = new calculator_test.calcbutton();
            this.button18 = new calculator_test.calcbutton();
            this.button17 = new calculator_test.calcbutton();
            this.button16 = new calculator_test.calcbutton();
            this.button15 = new calculator_test.calcbutton();
            this.button14 = new calculator_test.calcbutton();
            this.button13 = new calculator_test.calcbutton();
            this.button12 = new calculator_test.calcbutton();
            this.button11 = new calculator_test.calcbutton();
            this.button10 = new calculator_test.calcbutton();
            this.button9 = new calculator_test.calcbutton();
            this.button8 = new calculator_test.calcbutton();
            this.button7 = new calculator_test.calcbutton();
            this.button6 = new calculator_test.calcbutton();
            this.button5 = new calculator_test.calcbutton();
            this.button4 = new calculator_test.calcbutton();
            this.button3 = new calculator_test.calcbutton();
            this.button2 = new calculator_test.calcbutton();
            this.button1 = new calculator_test.calcbutton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 102);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(33, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 64);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2, 20);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14F);
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button43
            // 
            this.button43.InputSymbol = "X";
            this.button43.Location = new System.Drawing.Point(368, 159);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(45, 45);
            this.button43.TabIndex = 45;
            this.button43.Text = "X";
            this.button43.UseVisualStyleBackColor = true;
            this.button43.Click += new System.EventHandler(this.pressButton);
            // 
            // button36
            // 
            this.button36.InputSymbol = ";";
            this.button36.Location = new System.Drawing.Point(317, 159);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(45, 45);
            this.button36.TabIndex = 44;
            this.button36.Text = ";";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.pressButton);
            // 
            // button42
            // 
            this.button42.BackColor = System.Drawing.SystemColors.Info;
            this.button42.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button42.InputSymbol = "right";
            this.button42.Location = new System.Drawing.Point(365, 210);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(45, 45);
            this.button42.TabIndex = 43;
            this.button42.Text = ">";
            this.button42.UseVisualStyleBackColor = false;
            this.button42.Click += new System.EventHandler(this.pressButton);
            // 
            // button41
            // 
            this.button41.BackColor = System.Drawing.SystemColors.Info;
            this.button41.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button41.InputSymbol = "left";
            this.button41.Location = new System.Drawing.Point(317, 210);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(45, 45);
            this.button41.TabIndex = 42;
            this.button41.Text = "<";
            this.button41.UseVisualStyleBackColor = false;
            this.button41.Click += new System.EventHandler(this.pressButton);
            // 
            // button40
            // 
            this.button40.InputSymbol = "π";
            this.button40.Location = new System.Drawing.Point(164, 212);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(45, 45);
            this.button40.TabIndex = 40;
            this.button40.Text = "π";
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.pressButton);
            // 
            // button39
            // 
            this.button39.InputSymbol = "e";
            this.button39.Location = new System.Drawing.Point(113, 212);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(45, 45);
            this.button39.TabIndex = 39;
            this.button39.Text = "e";
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.pressButton);
            // 
            // button38
            // 
            this.button38.InputSymbol = ")";
            this.button38.Location = new System.Drawing.Point(62, 212);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(45, 45);
            this.button38.TabIndex = 38;
            this.button38.Text = ")";
            this.button38.UseVisualStyleBackColor = true;
            this.button38.Click += new System.EventHandler(this.pressButton);
            // 
            // button37
            // 
            this.button37.InputSymbol = "(";
            this.button37.Location = new System.Drawing.Point(11, 212);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(45, 45);
            this.button37.TabIndex = 37;
            this.button37.Text = "(";
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.pressButton);
            // 
            // button35
            // 
            this.button35.InputSymbol = "!";
            this.button35.Location = new System.Drawing.Point(215, 212);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(45, 45);
            this.button35.TabIndex = 35;
            this.button35.Text = "x!";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.pressButton);
            // 
            // button34
            // 
            this.button34.InputSymbol = "arctan(";
            this.button34.Location = new System.Drawing.Point(266, 159);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(45, 45);
            this.button34.TabIndex = 34;
            this.button34.Text = "arctan";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.pressButton);
            // 
            // button33
            // 
            this.button33.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.button33.InputSymbol = "arccos(";
            this.button33.Location = new System.Drawing.Point(215, 159);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(45, 45);
            this.button33.TabIndex = 33;
            this.button33.Text = "arccos";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.pressButton);
            // 
            // button32
            // 
            this.button32.InputSymbol = "arcsin(";
            this.button32.Location = new System.Drawing.Point(163, 159);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(45, 45);
            this.button32.TabIndex = 32;
            this.button32.Text = "arcsin";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.pressButton);
            // 
            // button31
            // 
            this.button31.InputSymbol = "tan(";
            this.button31.Location = new System.Drawing.Point(112, 159);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(45, 45);
            this.button31.TabIndex = 31;
            this.button31.Text = "tan";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.pressButton);
            // 
            // button30
            // 
            this.button30.InputSymbol = "cos(";
            this.button30.Location = new System.Drawing.Point(61, 159);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(45, 45);
            this.button30.TabIndex = 30;
            this.button30.Text = "cos";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.pressButton);
            // 
            // button29
            // 
            this.button29.InputSymbol = "sin(";
            this.button29.Location = new System.Drawing.Point(11, 159);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(45, 45);
            this.button29.TabIndex = 29;
            this.button29.Text = "sin";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.pressButton);
            // 
            // button28
            // 
            this.button28.InputSymbol = "^(";
            this.button28.Location = new System.Drawing.Point(215, 108);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(45, 45);
            this.button28.TabIndex = 28;
            this.button28.Text = "x^n";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.pressButton);
            // 
            // button27
            // 
            this.button27.InputSymbol = "^(2)";
            this.button27.Location = new System.Drawing.Point(317, 108);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(45, 45);
            this.button27.TabIndex = 27;
            this.button27.Text = "x^2";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.pressButton);
            // 
            // button26
            // 
            this.button26.InputSymbol = "rt(";
            this.button26.Location = new System.Drawing.Point(266, 108);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(45, 45);
            this.button26.TabIndex = 26;
            this.button26.Text = "nth root(y)";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.pressButton);
            // 
            // button25
            // 
            this.button25.InputSymbol = "sqrt(";
            this.button25.Location = new System.Drawing.Point(368, 108);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(45, 45);
            this.button25.TabIndex = 25;
            this.button25.Text = "sqrt()";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.pressButton);
            // 
            // button24
            // 
            this.button24.InputSymbol = ")/(";
            this.button24.Location = new System.Drawing.Point(164, 108);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(45, 45);
            this.button24.TabIndex = 24;
            this.button24.Text = "x/y";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.pressButton);
            // 
            // button23
            // 
            this.button23.InputSymbol = ")∏(";
            this.button23.Location = new System.Drawing.Point(113, 108);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(45, 45);
            this.button23.TabIndex = 23;
            this.button23.Text = "∏";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.pressButton);
            // 
            // button22
            // 
            this.button22.InputSymbol = ")∑(";
            this.button22.Location = new System.Drawing.Point(62, 108);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(45, 45);
            this.button22.TabIndex = 22;
            this.button22.Text = "∑";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.pressButton);
            // 
            // button21
            // 
            this.button21.InputSymbol = "log(";
            this.button21.Location = new System.Drawing.Point(11, 108);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(45, 45);
            this.button21.TabIndex = 21;
            this.button21.Text = "logx(y)";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.pressButton);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.DarkOrange;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button20.InputSymbol = "reset";
            this.button20.Location = new System.Drawing.Point(335, 263);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 75);
            this.button20.TabIndex = 20;
            this.button20.Text = "AC";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.pressButton);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.DarkOrange;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button19.InputSymbol = "del";
            this.button19.Location = new System.Drawing.Point(254, 263);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 75);
            this.button19.TabIndex = 19;
            this.button19.Text = "DEL";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.pressButton);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button18.InputSymbol = "/";
            this.button18.Location = new System.Drawing.Point(335, 344);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 75);
            this.button18.TabIndex = 18;
            this.button18.Text = "/";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.pressButton);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button17.InputSymbol = "*";
            this.button17.Location = new System.Drawing.Point(254, 344);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 75);
            this.button17.TabIndex = 17;
            this.button17.Text = "*";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.pressButton);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button16.InputSymbol = "-";
            this.button16.Location = new System.Drawing.Point(335, 425);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 75);
            this.button16.TabIndex = 16;
            this.button16.Text = "-";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.pressButton);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.InputSymbol = "+";
            this.button15.Location = new System.Drawing.Point(254, 425);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 75);
            this.button15.TabIndex = 15;
            this.button15.Text = "+";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.pressButton);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.InputSymbol = ",";
            this.button14.Location = new System.Drawing.Point(92, 506);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 75);
            this.button14.TabIndex = 14;
            this.button14.Text = ",";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.pressButton);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.InputSymbol = null;
            this.button13.Location = new System.Drawing.Point(335, 506);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 75);
            this.button13.TabIndex = 13;
            this.button13.Text = "=";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.InputSymbol = "Ans";
            this.button12.Location = new System.Drawing.Point(254, 506);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 75);
            this.button12.TabIndex = 12;
            this.button12.Text = "Ans";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.pressButton);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.InputSymbol = "*10^(";
            this.button11.Location = new System.Drawing.Point(173, 506);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 75);
            this.button11.TabIndex = 11;
            this.button11.Text = "*10^x";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.pressButton);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.InputSymbol = "0";
            this.button10.Location = new System.Drawing.Point(11, 506);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 75);
            this.button10.TabIndex = 10;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.pressButton);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.InputSymbol = "9";
            this.button9.Location = new System.Drawing.Point(173, 425);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 75);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.pressButton);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.InputSymbol = "8";
            this.button8.Location = new System.Drawing.Point(92, 425);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 75);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.pressButton);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.InputSymbol = "7";
            this.button7.Location = new System.Drawing.Point(11, 425);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 75);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.pressButton);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.InputSymbol = "6";
            this.button6.Location = new System.Drawing.Point(173, 344);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 75);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.pressButton);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.InputSymbol = "5";
            this.button5.Location = new System.Drawing.Point(92, 344);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 75);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.pressButton);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.InputSymbol = "4";
            this.button4.Location = new System.Drawing.Point(11, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 75);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.pressButton);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.InputSymbol = "3";
            this.button3.Location = new System.Drawing.Point(173, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 75);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.pressButton);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.InputSymbol = "2";
            this.button2.Location = new System.Drawing.Point(92, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.pressButton);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.InputSymbol = "1";
            this.button1.Location = new System.Drawing.Point(11, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.pressButton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 593);
            this.Controls.Add(this.button43);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button42);
            this.Controls.Add(this.button41);
            this.Controls.Add(this.button40);
            this.Controls.Add(this.button39);
            this.Controls.Add(this.button38);
            this.Controls.Add(this.button37);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(438, 632);
            this.MinimumSize = new System.Drawing.Size(438, 632);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private calcbutton button1;
        private calcbutton button2;
        private calcbutton button3;
        private calcbutton button4;
        private calcbutton button5;
        private calcbutton button6;
        private calcbutton button7;
        private calcbutton button8;
        private calcbutton button9;
        private calcbutton button10;
        private calcbutton button11;
        private calcbutton button12;
        private calcbutton button13;
        private calcbutton button14;
        private calcbutton button15;
        private calcbutton button16;
        private calcbutton button17;
        private calcbutton button18;
        private calcbutton button19;
        private calcbutton button20;
        private calcbutton button23;
        private calcbutton button24;
        private calcbutton button25;
        private calcbutton button26;
        private calcbutton button27;
        private calcbutton button28;
        private calcbutton button29;
        private calcbutton button30;
        private calcbutton button31;
        private calcbutton button32;
        private calcbutton button33;
        private calcbutton button34;
        private calcbutton button35;
        private calcbutton button37;
        private calcbutton button38;
        private calcbutton button39;
        private calcbutton button22;
        private calcbutton button21;
        private calcbutton button40;
        private calcbutton button41;
        private calcbutton button42;
        private System.Windows.Forms.Timer timer1;
        private calcbutton button36;
        private calcbutton button43;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

