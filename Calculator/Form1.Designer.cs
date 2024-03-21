namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(20, 22);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(325, 60);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(20, 355);
            button1.Name = "button1";
            button1.Size = new Size(77, 42);
            button1.TabIndex = 2;
            button1.Text = "+/_";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Islemler;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(103, 355);
            button2.Name = "button2";
            button2.Size = new Size(77, 42);
            button2.TabIndex = 3;
            button2.Text = "0";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Sayilar;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(186, 355);
            button3.Name = "button3";
            button3.Size = new Size(77, 42);
            button3.TabIndex = 4;
            button3.Text = ",";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Islemler;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(268, 355);
            button4.Name = "button4";
            button4.Size = new Size(77, 42);
            button4.TabIndex = 5;
            button4.Text = "=";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Islemler;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(268, 307);
            button5.Name = "button5";
            button5.Size = new Size(77, 42);
            button5.TabIndex = 9;
            button5.Text = "+";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Islemler;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Location = new Point(186, 307);
            button6.Name = "button6";
            button6.Size = new Size(77, 42);
            button6.TabIndex = 8;
            button6.Text = "3";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Sayilar;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(103, 307);
            button7.Name = "button7";
            button7.Size = new Size(77, 42);
            button7.TabIndex = 7;
            button7.Text = "2";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Sayilar;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ActiveCaptionText;
            button8.Location = new Point(20, 307);
            button8.Name = "button8";
            button8.Size = new Size(77, 42);
            button8.TabIndex = 6;
            button8.Text = "1";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Sayilar;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.ActiveCaptionText;
            button9.Location = new Point(268, 259);
            button9.Name = "button9";
            button9.Size = new Size(77, 42);
            button9.TabIndex = 13;
            button9.Text = "-";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Islemler;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button10.ForeColor = SystemColors.ActiveCaptionText;
            button10.Location = new Point(186, 259);
            button10.Name = "button10";
            button10.Size = new Size(77, 42);
            button10.TabIndex = 12;
            button10.Text = "6";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Sayilar;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button11.ForeColor = SystemColors.ActiveCaptionText;
            button11.Location = new Point(103, 259);
            button11.Name = "button11";
            button11.Size = new Size(77, 42);
            button11.TabIndex = 11;
            button11.Text = "5";
            button11.UseVisualStyleBackColor = true;
            button11.Click += Sayilar;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button12.ForeColor = SystemColors.ActiveCaptionText;
            button12.Location = new Point(20, 259);
            button12.Name = "button12";
            button12.Size = new Size(77, 42);
            button12.TabIndex = 10;
            button12.Text = "4";
            button12.UseVisualStyleBackColor = true;
            button12.Click += Sayilar;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button13.ForeColor = SystemColors.ActiveCaptionText;
            button13.Location = new Point(268, 211);
            button13.Name = "button13";
            button13.Size = new Size(77, 42);
            button13.TabIndex = 17;
            button13.Text = "x";
            button13.UseVisualStyleBackColor = true;
            button13.Click += Islemler;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button14.ForeColor = SystemColors.ActiveCaptionText;
            button14.Location = new Point(186, 211);
            button14.Name = "button14";
            button14.Size = new Size(77, 42);
            button14.TabIndex = 16;
            button14.Text = "9";
            button14.UseVisualStyleBackColor = true;
            button14.Click += Sayilar;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button15.ForeColor = SystemColors.ActiveCaptionText;
            button15.Location = new Point(103, 211);
            button15.Name = "button15";
            button15.Size = new Size(77, 42);
            button15.TabIndex = 15;
            button15.Text = "8";
            button15.UseVisualStyleBackColor = true;
            button15.Click += Sayilar;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button16.ForeColor = SystemColors.ActiveCaptionText;
            button16.Location = new Point(20, 211);
            button16.Name = "button16";
            button16.Size = new Size(77, 42);
            button16.TabIndex = 14;
            button16.Text = "7";
            button16.UseVisualStyleBackColor = true;
            button16.Click += Sayilar;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button17.ForeColor = SystemColors.ActiveCaptionText;
            button17.Location = new Point(268, 115);
            button17.Name = "button17";
            button17.Size = new Size(77, 42);
            button17.TabIndex = 25;
            button17.Text = "⌫";
            button17.UseVisualStyleBackColor = true;
            button17.Click += Back;
            // 
            // button18
            // 
            button18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button18.ForeColor = SystemColors.ActiveCaptionText;
            button18.Location = new Point(186, 115);
            button18.Name = "button18";
            button18.Size = new Size(77, 42);
            button18.TabIndex = 24;
            button18.Text = "C";
            button18.UseVisualStyleBackColor = true;
            button18.Click += Clear;
            // 
            // button19
            // 
            button19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button19.ForeColor = SystemColors.ActiveCaptionText;
            button19.Location = new Point(103, 115);
            button19.Name = "button19";
            button19.Size = new Size(77, 42);
            button19.TabIndex = 23;
            button19.Text = "CE";
            button19.UseVisualStyleBackColor = true;
            button19.Click += Clear;
            // 
            // button20
            // 
            button20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button20.ForeColor = SystemColors.ActiveCaptionText;
            button20.Location = new Point(20, 115);
            button20.Name = "button20";
            button20.Size = new Size(77, 42);
            button20.TabIndex = 22;
            button20.Text = "%";
            button20.UseVisualStyleBackColor = true;
            button20.Click += Yuzdelik;
            // 
            // button21
            // 
            button21.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button21.ForeColor = SystemColors.ActiveCaptionText;
            button21.Location = new Point(268, 163);
            button21.Name = "button21";
            button21.Size = new Size(77, 42);
            button21.TabIndex = 21;
            button21.Text = "÷";
            button21.UseVisualStyleBackColor = true;
            button21.Click += Islemler;
            // 
            // button22
            // 
            button22.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button22.ForeColor = SystemColors.ActiveCaptionText;
            button22.Location = new Point(186, 163);
            button22.Name = "button22";
            button22.Size = new Size(77, 42);
            button22.TabIndex = 20;
            button22.Text = "²√ₓ";
            button22.UseVisualStyleBackColor = true;
            button22.Click += Karekok;
            // 
            // button23
            // 
            button23.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button23.ForeColor = SystemColors.ActiveCaptionText;
            button23.Location = new Point(103, 163);
            button23.Name = "button23";
            button23.Size = new Size(77, 42);
            button23.TabIndex = 19;
            button23.Text = "𝑥²";
            button23.UseVisualStyleBackColor = true;
            button23.Click += Karesi;
            // 
            // button24
            // 
            button24.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button24.ForeColor = SystemColors.ActiveCaptionText;
            button24.Location = new Point(20, 163);
            button24.Name = "button24";
            button24.Size = new Size(77, 42);
            button24.TabIndex = 18;
            button24.Text = "¹/𝑥";
            button24.UseVisualStyleBackColor = true;
            button24.Click += xBolme;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(182, 199, 181);
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(28, 30);
            label1.Name = "label1";
            label1.Size = new Size(308, 45);
            label1.TabIndex = 30;
            label1.Text = "0";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(43, 91);
            label4.Name = "label4";
            label4.Size = new Size(28, 17);
            label4.TabIndex = 33;
            label4.Text = "MC";
            label4.Click += Memory;
            label4.MouseHover += ToolTipX;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(101, 91);
            label5.Name = "label5";
            label5.Size = new Size(28, 17);
            label5.TabIndex = 34;
            label5.Text = "MR";
            label5.Click += Memory;
            label5.MouseHover += ToolTipX;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(167, 91);
            label6.Name = "label6";
            label6.Size = new Size(29, 17);
            label6.TabIndex = 35;
            label6.Text = "M+";
            label6.Click += Memory;
            label6.MouseHover += ToolTipX;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(227, 91);
            label7.Name = "label7";
            label7.Size = new Size(25, 17);
            label7.TabIndex = 36;
            label7.Text = "M-";
            label7.Click += Memory;
            label7.MouseHover += ToolTipX;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(295, 91);
            label8.Name = "label8";
            label8.Size = new Size(27, 17);
            label8.TabIndex = 37;
            label8.Text = "MS";
            label8.Click += Memory;
            label8.MouseHover += ToolTipX;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(286, 396);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 38;
            label2.Text = "Enis Ingec";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(358, 414);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(button21);
            Controls.Add(button22);
            Controls.Add(button23);
            Controls.Add(button24);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Hesap Makinesi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label2;
    }
}