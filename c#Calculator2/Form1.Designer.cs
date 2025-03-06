namespace c_Calculator2
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
            textDisplay = new TextBox();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            bPlus = new Button();
            bMinus = new Button();
            bDivide = new Button();
            bTimes = new Button();
            b6 = new Button();
            b5 = new Button();
            b4 = new Button();
            bPower = new Button();
            bModulo = new Button();
            b9 = new Button();
            b8 = new Button();
            b7 = new Button();
            bEqual = new Button();
            bClear = new Button();
            bDecimal = new Button();
            b10 = new Button();
            SuspendLayout();
            // 
            // textDisplay
            // 
            textDisplay.BackColor = Color.FromArgb(82, 56, 116);
            textDisplay.BorderStyle = BorderStyle.None;
            textDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textDisplay.ForeColor = Color.White;
            textDisplay.Location = new Point(8, 22);
            textDisplay.Margin = new Padding(3, 2, 3, 2);
            textDisplay.Name = "textDisplay";
            textDisplay.Size = new Size(308, 32);
            textDisplay.TabIndex = 0;
            textDisplay.UseWaitCursor = true;
            // 
            // b1
            // 
            b1.BackColor = Color.FromArgb(199, 251, 165);
            b1.FlatStyle = FlatStyle.Popup;
            b1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            b1.ForeColor = SystemColors.ActiveCaptionText;
            b1.Location = new Point(10, 83);
            b1.Margin = new Padding(3, 2, 3, 2);
            b1.Name = "b1";
            b1.Size = new Size(55, 43);
            b1.TabIndex = 1;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = false;
            b1.Click += button1_Click;
            // 
            // b2
            // 
            b2.BackColor = Color.FromArgb(199, 251, 165);
            b2.FlatStyle = FlatStyle.Popup;
            b2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            b2.ForeColor = SystemColors.ActiveCaptionText;
            b2.Location = new Point(73, 83);
            b2.Margin = new Padding(3, 2, 3, 2);
            b2.Name = "b2";
            b2.Size = new Size(55, 43);
            b2.TabIndex = 2;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = false;
            b2.Click += button2_Click;
            // 
            // b3
            // 
            b3.BackColor = Color.FromArgb(199, 251, 165);
            b3.FlatStyle = FlatStyle.Popup;
            b3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            b3.ForeColor = SystemColors.ActiveCaptionText;
            b3.Location = new Point(135, 83);
            b3.Margin = new Padding(3, 2, 3, 2);
            b3.Name = "b3";
            b3.Size = new Size(55, 43);
            b3.TabIndex = 3;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = false;
            b3.Click += button3_Click;
            // 
            // bPlus
            // 
            bPlus.BackColor = Color.FromArgb(244, 157, 26);
            bPlus.FlatStyle = FlatStyle.Popup;
            bPlus.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            bPlus.Location = new Point(197, 83);
            bPlus.Margin = new Padding(3, 2, 3, 2);
            bPlus.Name = "bPlus";
            bPlus.Size = new Size(55, 43);
            bPlus.TabIndex = 4;
            bPlus.Text = "+";
            bPlus.UseVisualStyleBackColor = false;
            bPlus.Click += button4_Click;
            // 
            // bMinus
            // 
            bMinus.BackColor = Color.FromArgb(244, 157, 26);
            bMinus.FlatStyle = FlatStyle.Popup;
            bMinus.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            bMinus.Location = new Point(259, 83);
            bMinus.Margin = new Padding(3, 2, 3, 2);
            bMinus.Name = "bMinus";
            bMinus.Size = new Size(55, 43);
            bMinus.TabIndex = 5;
            bMinus.Text = "-";
            bMinus.UseVisualStyleBackColor = false;
            bMinus.Click += bMinus_Click;
            // 
            // bDivide
            // 
            bDivide.BackColor = Color.FromArgb(244, 157, 26);
            bDivide.FlatStyle = FlatStyle.Popup;
            bDivide.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            bDivide.Location = new Point(259, 148);
            bDivide.Margin = new Padding(3, 2, 3, 2);
            bDivide.Name = "bDivide";
            bDivide.Size = new Size(55, 43);
            bDivide.TabIndex = 10;
            bDivide.Text = "/";
            bDivide.UseVisualStyleBackColor = false;
            bDivide.Click += bDivide_Click;
            // 
            // bTimes
            // 
            bTimes.BackColor = Color.FromArgb(244, 157, 26);
            bTimes.FlatStyle = FlatStyle.Popup;
            bTimes.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            bTimes.Location = new Point(195, 148);
            bTimes.Margin = new Padding(3, 2, 3, 2);
            bTimes.Name = "bTimes";
            bTimes.Size = new Size(57, 43);
            bTimes.TabIndex = 9;
            bTimes.Text = "X";
            bTimes.UseVisualStyleBackColor = false;
            bTimes.Click += button7_Click;
            // 
            // b6
            // 
            b6.BackColor = Color.FromArgb(199, 251, 165);
            b6.FlatStyle = FlatStyle.Popup;
            b6.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            b6.ForeColor = SystemColors.ActiveCaptionText;
            b6.Location = new Point(133, 148);
            b6.Margin = new Padding(3, 2, 3, 2);
            b6.Name = "b6";
            b6.Size = new Size(57, 43);
            b6.TabIndex = 8;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = false;
            b6.Click += b6_Click;
            // 
            // b5
            // 
            b5.BackColor = Color.FromArgb(199, 251, 165);
            b5.FlatStyle = FlatStyle.Popup;
            b5.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            b5.ForeColor = SystemColors.ActiveCaptionText;
            b5.Location = new Point(73, 148);
            b5.Margin = new Padding(3, 2, 3, 2);
            b5.Name = "b5";
            b5.Size = new Size(55, 43);
            b5.TabIndex = 7;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = false;
            b5.Click += b5_Click;
            // 
            // b4
            // 
            b4.BackColor = Color.FromArgb(199, 251, 165);
            b4.FlatStyle = FlatStyle.Popup;
            b4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            b4.ForeColor = SystemColors.ActiveCaptionText;
            b4.Location = new Point(10, 148);
            b4.Margin = new Padding(3, 2, 3, 2);
            b4.Name = "b4";
            b4.Size = new Size(55, 43);
            b4.TabIndex = 6;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = false;
            b4.Click += button10_Click;
            // 
            // bPower
            // 
            bPower.BackColor = Color.FromArgb(244, 157, 26);
            bPower.FlatStyle = FlatStyle.Popup;
            bPower.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            bPower.Location = new Point(259, 212);
            bPower.Margin = new Padding(3, 2, 3, 2);
            bPower.Name = "bPower";
            bPower.Size = new Size(55, 43);
            bPower.TabIndex = 15;
            bPower.Text = "^";
            bPower.UseVisualStyleBackColor = false;
            bPower.Click += bPower_Click;
            // 
            // bModulo
            // 
            bModulo.BackColor = Color.FromArgb(244, 157, 26);
            bModulo.FlatStyle = FlatStyle.Popup;
            bModulo.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            bModulo.Location = new Point(195, 212);
            bModulo.Margin = new Padding(3, 2, 3, 2);
            bModulo.Name = "bModulo";
            bModulo.Size = new Size(57, 43);
            bModulo.TabIndex = 14;
            bModulo.Text = "%";
            bModulo.UseVisualStyleBackColor = false;
            bModulo.Click += bModulo_Click;
            // 
            // b9
            // 
            b9.BackColor = Color.FromArgb(199, 251, 165);
            b9.FlatStyle = FlatStyle.Popup;
            b9.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            b9.ForeColor = SystemColors.ActiveCaptionText;
            b9.Location = new Point(135, 212);
            b9.Margin = new Padding(3, 2, 3, 2);
            b9.Name = "b9";
            b9.Size = new Size(55, 43);
            b9.TabIndex = 13;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = false;
            b9.Click += b9_Click;
            // 
            // b8
            // 
            b8.BackColor = Color.FromArgb(199, 251, 165);
            b8.FlatStyle = FlatStyle.Popup;
            b8.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            b8.ForeColor = SystemColors.ActiveCaptionText;
            b8.Location = new Point(73, 212);
            b8.Margin = new Padding(3, 2, 3, 2);
            b8.Name = "b8";
            b8.Size = new Size(55, 43);
            b8.TabIndex = 12;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = false;
            b8.Click += button14_Click;
            // 
            // b7
            // 
            b7.BackColor = Color.FromArgb(199, 251, 165);
            b7.FlatStyle = FlatStyle.Popup;
            b7.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            b7.ForeColor = SystemColors.ActiveCaptionText;
            b7.Location = new Point(10, 212);
            b7.Margin = new Padding(3, 2, 3, 2);
            b7.Name = "b7";
            b7.Size = new Size(55, 43);
            b7.TabIndex = 11;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = false;
            b7.Click += b7_Click;
            // 
            // bEqual
            // 
            bEqual.BackColor = Color.FromArgb(173, 241, 130);
            bEqual.FlatStyle = FlatStyle.Popup;
            bEqual.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            bEqual.Location = new Point(195, 276);
            bEqual.Margin = new Padding(3, 2, 3, 2);
            bEqual.Name = "bEqual";
            bEqual.Size = new Size(121, 43);
            bEqual.TabIndex = 19;
            bEqual.Text = "=";
            bEqual.UseVisualStyleBackColor = false;
            bEqual.Click += bEqual_Click;
            // 
            // bClear
            // 
            bClear.BackColor = Color.FromArgb(199, 251, 165);
            bClear.FlatStyle = FlatStyle.Popup;
            bClear.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            bClear.ForeColor = SystemColors.ActiveCaptionText;
            bClear.Location = new Point(135, 276);
            bClear.Margin = new Padding(3, 2, 3, 2);
            bClear.Name = "bClear";
            bClear.Size = new Size(55, 43);
            bClear.TabIndex = 18;
            bClear.Text = "C";
            bClear.UseVisualStyleBackColor = false;
            bClear.Click += bClear_Click;
            // 
            // bDecimal
            // 
            bDecimal.BackColor = Color.FromArgb(199, 251, 165);
            bDecimal.FlatStyle = FlatStyle.Popup;
            bDecimal.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            bDecimal.ForeColor = SystemColors.ActiveCaptionText;
            bDecimal.Location = new Point(74, 276);
            bDecimal.Margin = new Padding(3, 2, 3, 2);
            bDecimal.Name = "bDecimal";
            bDecimal.Size = new Size(55, 43);
            bDecimal.TabIndex = 17;
            bDecimal.Text = ".";
            bDecimal.UseVisualStyleBackColor = false;
            bDecimal.Click += bDecimal_Click;
            // 
            // b10
            // 
            b10.BackColor = Color.FromArgb(199, 251, 165);
            b10.FlatStyle = FlatStyle.Popup;
            b10.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            b10.ForeColor = SystemColors.ActiveCaptionText;
            b10.Location = new Point(11, 276);
            b10.Margin = new Padding(3, 2, 3, 2);
            b10.Name = "b10";
            b10.Size = new Size(54, 43);
            b10.TabIndex = 16;
            b10.Text = "0";
            b10.UseVisualStyleBackColor = false;
            b10.Click += b10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(145, 108, 173);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(325, 338);
            Controls.Add(bEqual);
            Controls.Add(bClear);
            Controls.Add(bDecimal);
            Controls.Add(b10);
            Controls.Add(bPower);
            Controls.Add(bModulo);
            Controls.Add(b9);
            Controls.Add(b8);
            Controls.Add(b7);
            Controls.Add(bDivide);
            Controls.Add(bTimes);
            Controls.Add(b6);
            Controls.Add(b5);
            Controls.Add(b4);
            Controls.Add(bMinus);
            Controls.Add(bPlus);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(textDisplay);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load_1;
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textDisplay;
        private Button b1;
        private Button b2;
        private Button b3;
        private Button bPlus;
        private Button bMinus;
        private Button bDivide;
        private Button bTimes;
        private Button b6;
        private Button b5;
        private Button b4;
        private Button bPower;
        private Button bModulo;
        private Button b9;
        private Button b8;
        private Button b7;
        private Button bEqual;
        private Button bClear;
        private Button bDecimal;
        private Button b10;
    }
}
