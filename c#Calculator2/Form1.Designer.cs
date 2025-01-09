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
            textDisplay.BackColor = Color.FromArgb(58, 63, 119);
            textDisplay.BorderStyle = BorderStyle.None;
            textDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textDisplay.ForeColor = Color.White;
            textDisplay.Location = new Point(9, 30);
            textDisplay.Name = "textDisplay";
            textDisplay.Size = new Size(352, 40);
            textDisplay.TabIndex = 0;
            textDisplay.UseWaitCursor = true;
            // 
            // b1
            // 
            b1.BackColor = Color.FromArgb(64, 66, 88);
            b1.FlatStyle = FlatStyle.Popup;
            b1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            b1.ForeColor = SystemColors.ButtonHighlight;
            b1.Location = new Point(12, 111);
            b1.Name = "b1";
            b1.Size = new Size(63, 57);
            b1.TabIndex = 1;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = false;
            b1.Click += button1_Click;
            // 
            // b2
            // 
            b2.BackColor = Color.FromArgb(64, 66, 88);
            b2.FlatStyle = FlatStyle.Popup;
            b2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            b2.ForeColor = SystemColors.ButtonHighlight;
            b2.Location = new Point(83, 111);
            b2.Name = "b2";
            b2.Size = new Size(63, 57);
            b2.TabIndex = 2;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = false;
            b2.Click += button2_Click;
            // 
            // b3
            // 
            b3.BackColor = Color.FromArgb(64, 66, 88);
            b3.FlatStyle = FlatStyle.Popup;
            b3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            b3.ForeColor = SystemColors.ButtonHighlight;
            b3.Location = new Point(154, 111);
            b3.Name = "b3";
            b3.Size = new Size(63, 57);
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
            bPlus.Location = new Point(225, 111);
            bPlus.Name = "bPlus";
            bPlus.Size = new Size(63, 57);
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
            bMinus.Location = new Point(296, 111);
            bMinus.Name = "bMinus";
            bMinus.Size = new Size(63, 57);
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
            bDivide.Location = new Point(296, 197);
            bDivide.Name = "bDivide";
            bDivide.Size = new Size(63, 57);
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
            bTimes.Location = new Point(223, 197);
            bTimes.Name = "bTimes";
            bTimes.Size = new Size(65, 57);
            bTimes.TabIndex = 9;
            bTimes.Text = "X";
            bTimes.UseVisualStyleBackColor = false;
            bTimes.Click += button7_Click;
            // 
            // b6
            // 
            b6.BackColor = Color.FromArgb(64, 66, 88);
            b6.FlatStyle = FlatStyle.Popup;
            b6.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            b6.ForeColor = SystemColors.ButtonHighlight;
            b6.Location = new Point(152, 197);
            b6.Name = "b6";
            b6.Size = new Size(65, 57);
            b6.TabIndex = 8;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = false;
            b6.Click += b6_Click;
            // 
            // b5
            // 
            b5.BackColor = Color.FromArgb(64, 66, 88);
            b5.FlatStyle = FlatStyle.Popup;
            b5.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            b5.ForeColor = SystemColors.ButtonHighlight;
            b5.Location = new Point(83, 197);
            b5.Name = "b5";
            b5.Size = new Size(63, 57);
            b5.TabIndex = 7;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = false;
            b5.Click += b5_Click;
            // 
            // b4
            // 
            b4.BackColor = Color.FromArgb(64, 66, 88);
            b4.FlatStyle = FlatStyle.Popup;
            b4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            b4.ForeColor = SystemColors.ButtonHighlight;
            b4.Location = new Point(12, 197);
            b4.Name = "b4";
            b4.Size = new Size(63, 57);
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
            bPower.Location = new Point(296, 283);
            bPower.Name = "bPower";
            bPower.Size = new Size(63, 57);
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
            bModulo.Location = new Point(223, 283);
            bModulo.Name = "bModulo";
            bModulo.Size = new Size(65, 57);
            bModulo.TabIndex = 14;
            bModulo.Text = "%";
            bModulo.UseVisualStyleBackColor = false;
            bModulo.Click += bModulo_Click;
            // 
            // b9
            // 
            b9.BackColor = Color.FromArgb(64, 66, 88);
            b9.FlatStyle = FlatStyle.Popup;
            b9.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            b9.ForeColor = SystemColors.ButtonHighlight;
            b9.Location = new Point(154, 283);
            b9.Name = "b9";
            b9.Size = new Size(63, 57);
            b9.TabIndex = 13;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = false;
            b9.Click += b9_Click;
            // 
            // b8
            // 
            b8.BackColor = Color.FromArgb(64, 66, 88);
            b8.FlatStyle = FlatStyle.Popup;
            b8.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            b8.ForeColor = SystemColors.ButtonHighlight;
            b8.Location = new Point(83, 283);
            b8.Name = "b8";
            b8.Size = new Size(63, 57);
            b8.TabIndex = 12;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = false;
            b8.Click += button14_Click;
            // 
            // b7
            // 
            b7.BackColor = Color.FromArgb(64, 66, 88);
            b7.FlatStyle = FlatStyle.Popup;
            b7.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            b7.ForeColor = SystemColors.ButtonHighlight;
            b7.Location = new Point(12, 283);
            b7.Name = "b7";
            b7.Size = new Size(63, 57);
            b7.TabIndex = 11;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = false;
            b7.Click += b7_Click;
            // 
            // bEqual
            // 
            bEqual.BackColor = Color.FromArgb(178, 178, 178);
            bEqual.FlatStyle = FlatStyle.Popup;
            bEqual.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            bEqual.Location = new Point(223, 368);
            bEqual.Name = "bEqual";
            bEqual.Size = new Size(138, 57);
            bEqual.TabIndex = 19;
            bEqual.Text = "=";
            bEqual.UseVisualStyleBackColor = false;
            bEqual.Click += bEqual_Click;
            // 
            // bClear
            // 
            bClear.BackColor = Color.FromArgb(64, 66, 88);
            bClear.FlatStyle = FlatStyle.Popup;
            bClear.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            bClear.ForeColor = SystemColors.ButtonHighlight;
            bClear.Location = new Point(154, 368);
            bClear.Name = "bClear";
            bClear.Size = new Size(63, 57);
            bClear.TabIndex = 18;
            bClear.Text = "C";
            bClear.UseVisualStyleBackColor = false;
            bClear.Click += bClear_Click;
            // 
            // bDecimal
            // 
            bDecimal.BackColor = Color.FromArgb(64, 66, 88);
            bDecimal.FlatStyle = FlatStyle.Popup;
            bDecimal.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            bDecimal.ForeColor = SystemColors.ButtonHighlight;
            bDecimal.Location = new Point(85, 368);
            bDecimal.Name = "bDecimal";
            bDecimal.Size = new Size(63, 57);
            bDecimal.TabIndex = 17;
            bDecimal.Text = ".";
            bDecimal.UseVisualStyleBackColor = false;
            bDecimal.Click += bDecimal_Click;
            // 
            // b10
            // 
            b10.BackColor = Color.FromArgb(64, 66, 88);
            b10.FlatStyle = FlatStyle.Popup;
            b10.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            b10.ForeColor = SystemColors.ButtonHighlight;
            b10.Location = new Point(13, 368);
            b10.Name = "b10";
            b10.Size = new Size(62, 57);
            b10.TabIndex = 16;
            b10.Text = "0";
            b10.UseVisualStyleBackColor = false;
            b10.Click += b10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 37, 48);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(371, 450);
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
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
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
