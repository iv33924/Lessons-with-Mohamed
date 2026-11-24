namespace paint_interface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button27 = new Button();
            trackBar1 = new TrackBar();
            button1 = new Button();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            panel3 = new Panel();
            button30 = new Button();
            button28 = new Button();
            button23 = new Button();
            button24 = new Button();
            button25 = new Button();
            button26 = new Button();
            button29 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button8 = new Button();
            button6 = new Button();
            button7 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            видToolStripMenuItem = new ToolStripMenuItem();
            увеличитьМасштабToolStripMenuItem = new ToolStripMenuItem();
            уменьшитьМасштабToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1381, 644);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(button27);
            panel1.Controls.Add(trackBar1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1381, 77);
            panel1.TabIndex = 1;
            // 
            // button27
            // 
            button27.BackColor = Color.Silver;
            button27.FlatStyle = FlatStyle.Flat;
            button27.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button27.ForeColor = Color.Red;
            button27.Location = new Point(1047, 16);
            button27.Name = "button27";
            button27.Size = new Size(158, 45);
            button27.TabIndex = 9;
            button27.Text = "Сохранить";
            button27.UseVisualStyleBackColor = false;
            button27.Click += Save_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(304, 29);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(160, 45);
            trackBar1.TabIndex = 8;
            trackBar1.Value = 3;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(1211, 16);
            button1.Name = "button1";
            button1.Size = new Size(158, 45);
            button1.TabIndex = 3;
            button1.Text = "Очистить всё";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Clear_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(206, 21);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(92, 34);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Линия";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(103, 21);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(97, 34);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Ластик";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(12, 21);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(85, 34);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Кисть";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(button30);
            panel3.Controls.Add(button28);
            panel3.Controls.Add(button23);
            panel3.Controls.Add(button24);
            panel3.Controls.Add(button25);
            panel3.Controls.Add(button26);
            panel3.Controls.Add(button29);
            panel3.Controls.Add(button16);
            panel3.Controls.Add(button17);
            panel3.Controls.Add(button18);
            panel3.Controls.Add(button19);
            panel3.Controls.Add(button20);
            panel3.Controls.Add(button21);
            panel3.Controls.Add(button22);
            panel3.Controls.Add(button9);
            panel3.Controls.Add(button10);
            panel3.Controls.Add(button11);
            panel3.Controls.Add(button12);
            panel3.Controls.Add(button13);
            panel3.Controls.Add(button14);
            panel3.Controls.Add(button15);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button5);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 596);
            panel3.Name = "panel3";
            panel3.Size = new Size(1381, 72);
            panel3.TabIndex = 2;
            // 
            // button30
            // 
            button30.BackColor = Color.Red;
            button30.FlatStyle = FlatStyle.System;
            button30.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button30.ForeColor = Color.Red;
            button30.Location = new Point(92, 17);
            button30.Name = "button30";
            button30.Size = new Size(74, 43);
            button30.TabIndex = 11;
            button30.Text = "→";
            button30.UseVisualStyleBackColor = false;
            button30.Click += Redo_Click;
            // 
            // button28
            // 
            button28.BackColor = Color.Red;
            button28.FlatStyle = FlatStyle.System;
            button28.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button28.ForeColor = Color.Red;
            button28.Location = new Point(12, 17);
            button28.Name = "button28";
            button28.Size = new Size(74, 43);
            button28.TabIndex = 10;
            button28.Text = "←";
            button28.UseVisualStyleBackColor = false;
            button28.Click += Undo_Click;
            // 
            // button23
            // 
            button23.BackColor = Color.FromArgb(64, 64, 64);
            button23.FlatStyle = FlatStyle.Flat;
            button23.ForeColor = Color.Black;
            button23.Location = new Point(1029, 26);
            button23.Name = "button23";
            button23.Size = new Size(25, 25);
            button23.TabIndex = 27;
            button23.UseVisualStyleBackColor = false;
            button23.Click += Color_Click;
            // 
            // button24
            // 
            button24.BackColor = Color.Silver;
            button24.FlatStyle = FlatStyle.Flat;
            button24.ForeColor = Color.Black;
            button24.Location = new Point(1091, 26);
            button24.Name = "button24";
            button24.Size = new Size(25, 25);
            button24.TabIndex = 25;
            button24.UseVisualStyleBackColor = false;
            button24.Click += Color_Click;
            // 
            // button25
            // 
            button25.BackColor = Color.Gray;
            button25.FlatStyle = FlatStyle.Flat;
            button25.ForeColor = Color.Black;
            button25.Location = new Point(1060, 26);
            button25.Name = "button25";
            button25.Size = new Size(25, 25);
            button25.TabIndex = 26;
            button25.UseVisualStyleBackColor = false;
            button25.Click += Color_Click;
            // 
            // button26
            // 
            button26.BackColor = Color.White;
            button26.FlatStyle = FlatStyle.Flat;
            button26.ForeColor = Color.Black;
            button26.Location = new Point(1153, 26);
            button26.Name = "button26";
            button26.Size = new Size(25, 25);
            button26.TabIndex = 21;
            button26.UseVisualStyleBackColor = false;
            button26.Click += Color_Click;
            // 
            // button29
            // 
            button29.BackColor = Color.FromArgb(224, 224, 224);
            button29.FlatStyle = FlatStyle.Flat;
            button29.ForeColor = Color.Black;
            button29.Location = new Point(1122, 26);
            button29.Name = "button29";
            button29.Size = new Size(25, 25);
            button29.TabIndex = 24;
            button29.UseVisualStyleBackColor = false;
            button29.Click += Color_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.Blue;
            button16.FlatStyle = FlatStyle.Flat;
            button16.ForeColor = Color.Black;
            button16.Location = new Point(812, 26);
            button16.Name = "button16";
            button16.Size = new Size(25, 25);
            button16.TabIndex = 20;
            button16.UseVisualStyleBackColor = false;
            button16.Click += Color_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.FromArgb(192, 192, 255);
            button17.FlatStyle = FlatStyle.Flat;
            button17.ForeColor = Color.Black;
            button17.Location = new Point(874, 26);
            button17.Name = "button17";
            button17.Size = new Size(25, 25);
            button17.TabIndex = 18;
            button17.UseVisualStyleBackColor = false;
            button17.Click += Color_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.FromArgb(128, 128, 255);
            button18.FlatStyle = FlatStyle.Flat;
            button18.ForeColor = Color.Black;
            button18.Location = new Point(843, 26);
            button18.Name = "button18";
            button18.Size = new Size(25, 25);
            button18.TabIndex = 19;
            button18.UseVisualStyleBackColor = false;
            button18.Click += Color_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.FromArgb(255, 128, 255);
            button19.FlatStyle = FlatStyle.Flat;
            button19.ForeColor = Color.Black;
            button19.Location = new Point(936, 26);
            button19.Name = "button19";
            button19.Size = new Size(25, 25);
            button19.TabIndex = 14;
            button19.UseVisualStyleBackColor = false;
            button19.Click += Color_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.FromArgb(255, 192, 255);
            button20.FlatStyle = FlatStyle.Flat;
            button20.ForeColor = Color.Black;
            button20.Location = new Point(967, 26);
            button20.Name = "button20";
            button20.Size = new Size(25, 25);
            button20.TabIndex = 15;
            button20.UseVisualStyleBackColor = false;
            button20.Click += Color_Click;
            // 
            // button21
            // 
            button21.BackColor = Color.Black;
            button21.FlatStyle = FlatStyle.Flat;
            button21.ForeColor = Color.Black;
            button21.Location = new Point(998, 26);
            button21.Name = "button21";
            button21.Size = new Size(25, 25);
            button21.TabIndex = 16;
            button21.UseVisualStyleBackColor = false;
            button21.Click += Color_Click;
            // 
            // button22
            // 
            button22.BackColor = Color.Fuchsia;
            button22.FlatStyle = FlatStyle.Flat;
            button22.ForeColor = Color.Black;
            button22.Location = new Point(905, 26);
            button22.Name = "button22";
            button22.Size = new Size(25, 25);
            button22.TabIndex = 17;
            button22.UseVisualStyleBackColor = false;
            button22.Click += Color_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(255, 255, 128);
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = Color.Black;
            button9.Location = new Point(595, 26);
            button9.Name = "button9";
            button9.Size = new Size(25, 25);
            button9.TabIndex = 13;
            button9.UseVisualStyleBackColor = false;
            button9.Click += Color_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Lime;
            button10.FlatStyle = FlatStyle.Flat;
            button10.ForeColor = Color.Black;
            button10.Location = new Point(657, 26);
            button10.Name = "button10";
            button10.Size = new Size(25, 25);
            button10.TabIndex = 11;
            button10.UseVisualStyleBackColor = false;
            button10.Click += Color_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(255, 255, 192);
            button11.FlatStyle = FlatStyle.Flat;
            button11.ForeColor = Color.Black;
            button11.Location = new Point(626, 26);
            button11.Name = "button11";
            button11.Size = new Size(25, 25);
            button11.TabIndex = 12;
            button11.UseVisualStyleBackColor = false;
            button11.Click += Color_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(192, 255, 192);
            button12.FlatStyle = FlatStyle.Flat;
            button12.ForeColor = Color.Black;
            button12.Location = new Point(719, 26);
            button12.Name = "button12";
            button12.Size = new Size(25, 25);
            button12.TabIndex = 7;
            button12.UseVisualStyleBackColor = false;
            button12.Click += Color_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.Cyan;
            button13.FlatStyle = FlatStyle.Flat;
            button13.ForeColor = Color.Black;
            button13.Location = new Point(750, 26);
            button13.Name = "button13";
            button13.Size = new Size(25, 25);
            button13.TabIndex = 8;
            button13.UseVisualStyleBackColor = false;
            button13.Click += Color_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(128, 255, 255);
            button14.FlatStyle = FlatStyle.Flat;
            button14.ForeColor = Color.Black;
            button14.Location = new Point(781, 26);
            button14.Name = "button14";
            button14.Size = new Size(25, 25);
            button14.TabIndex = 9;
            button14.UseVisualStyleBackColor = false;
            button14.Click += Color_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.FromArgb(128, 255, 128);
            button15.FlatStyle = FlatStyle.Flat;
            button15.ForeColor = Color.Black;
            button15.Location = new Point(688, 26);
            button15.Name = "button15";
            button15.Size = new Size(25, 25);
            button15.TabIndex = 10;
            button15.UseVisualStyleBackColor = false;
            button15.Click += Color_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Red;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.Black;
            button8.Location = new Point(378, 26);
            button8.Name = "button8";
            button8.Size = new Size(25, 25);
            button8.TabIndex = 6;
            button8.UseVisualStyleBackColor = false;
            button8.Click += Color_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(255, 192, 192);
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.Black;
            button6.Location = new Point(440, 26);
            button6.Name = "button6";
            button6.Size = new Size(25, 25);
            button6.TabIndex = 4;
            button6.UseVisualStyleBackColor = false;
            button6.Click += Color_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(255, 128, 128);
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.Black;
            button7.Location = new Point(409, 26);
            button7.Name = "button7";
            button7.Size = new Size(25, 25);
            button7.TabIndex = 5;
            button7.UseVisualStyleBackColor = false;
            button7.Click += Color_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(502, 26);
            button2.Name = "button2";
            button2.Size = new Size(25, 25);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = false;
            button2.Click += Color_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 224, 192);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(533, 26);
            button3.Name = "button3";
            button3.Size = new Size(25, 25);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = false;
            button3.Click += Color_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Yellow;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Black;
            button4.Location = new Point(564, 26);
            button4.Name = "button4";
            button4.Size = new Size(25, 25);
            button4.TabIndex = 2;
            button4.UseVisualStyleBackColor = false;
            button4.Click += Color_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 128, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.Black;
            button5.Location = new Point(471, 26);
            button5.Name = "button5";
            button5.Size = new Size(25, 25);
            button5.TabIndex = 3;
            button5.UseVisualStyleBackColor = false;
            button5.Click += Color_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(192, 255, 255);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, видToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1381, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьToolStripMenuItem, открытьToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.Size = new Size(180, 22);
            создатьToolStripMenuItem.Text = "Создать";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(180, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(180, 22);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // видToolStripMenuItem
            // 
            видToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { увеличитьМасштабToolStripMenuItem, уменьшитьМасштабToolStripMenuItem });
            видToolStripMenuItem.Name = "видToolStripMenuItem";
            видToolStripMenuItem.Size = new Size(39, 20);
            видToolStripMenuItem.Text = "Вид";
            // 
            // увеличитьМасштабToolStripMenuItem
            // 
            увеличитьМасштабToolStripMenuItem.Name = "увеличитьМасштабToolStripMenuItem";
            увеличитьМасштабToolStripMenuItem.Size = new Size(191, 22);
            увеличитьМасштабToolStripMenuItem.Text = "Увеличить масштаб";
            // 
            // уменьшитьМасштабToolStripMenuItem
            // 
            уменьшитьМасштабToolStripMenuItem.Name = "уменьшитьМасштабToolStripMenuItem";
            уменьшитьМасштабToolStripMenuItem.Size = new Size(191, 22);
            уменьшитьМасштабToolStripMenuItem.Text = "Уменьшить масштаб";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1381, 668);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "pain_interface";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel3.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Panel panel3;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private TrackBar trackBar1;
        private Button button28;
        private Button button27;
        private Button button23;
        private Button button24;
        private Button button25;
        private Button button26;
        private Button button29;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button30;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem видToolStripMenuItem;
        private ToolStripMenuItem увеличитьМасштабToolStripMenuItem;
        private ToolStripMenuItem уменьшитьМасштабToolStripMenuItem;
    }
}