namespace WinForms.B21
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            title = new Label();
            tbxTotal = new TextBox();
            buttonDIV = new Button();
            panel1 = new Panel();
            buttonMUL = new Button();
            buttonSUB = new Button();
            buttonPLUS = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonSQRT = new Button();
            buttonEXP = new Button();
            buttonOBracket = new Button();
            buttonCBracket = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top;
            title.AutoSize = true;
            title.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = Color.FromArgb(192, 0, 0);
            title.Location = new Point(175, 9);
            title.Name = "title";
            title.Size = new Size(195, 37);
            title.TabIndex = 0;
            title.Text = "CALCULATOR";
            // 
            // tbxTotal
            // 
            tbxTotal.Anchor = AnchorStyles.Top;
            tbxTotal.Location = new Point(44, 62);
            tbxTotal.Multiline = true;
            tbxTotal.Name = "tbxTotal";
            tbxTotal.ReadOnly = false;
            tbxTotal.Size = new Size(461, 64);
            tbxTotal.TabIndex = 7;
            // 
            // buttonDIV
            // 
            buttonDIV.Anchor = AnchorStyles.Top;
            buttonDIV.Location = new Point(275, 262);
            buttonDIV.Name = "buttonDIV";
            buttonDIV.Size = new Size(75, 75);
            buttonDIV.TabIndex = 9;
            buttonDIV.Text = "/";
            buttonDIV.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(buttonCBracket);
            panel1.Controls.Add(buttonOBracket);
            panel1.Controls.Add(buttonEXP);
            panel1.Controls.Add(buttonSQRT);
            panel1.Controls.Add(buttonMUL);
            panel1.Controls.Add(buttonDIV);
            panel1.Controls.Add(buttonSUB);
            panel1.Controls.Add(buttonPLUS);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(44, 145);
            panel1.Name = "panel1";
            panel1.Size = new Size(461, 354);
            panel1.TabIndex = 12;
            // 
            // buttonMUL
            // 
            buttonMUL.Anchor = AnchorStyles.Top;
            buttonMUL.Location = new Point(275, 180);
            buttonMUL.Name = "buttonMUL";
            buttonMUL.Size = new Size(75, 76);
            buttonMUL.TabIndex = 14;
            buttonMUL.Text = "x";
            buttonMUL.UseVisualStyleBackColor = true;
            // 
            // buttonSUB
            // 
            buttonSUB.Anchor = AnchorStyles.Top;
            buttonSUB.Location = new Point(275, 98);
            buttonSUB.Name = "buttonSUB";
            buttonSUB.Size = new Size(75, 76);
            buttonSUB.TabIndex = 13;
            buttonSUB.Text = "-";
            buttonSUB.UseVisualStyleBackColor = true;
            // 
            // buttonPLUS
            // 
            buttonPLUS.Anchor = AnchorStyles.Top;
            buttonPLUS.Location = new Point(275, 16);
            buttonPLUS.Name = "buttonPLUS";
            buttonPLUS.Size = new Size(75, 76);
            buttonPLUS.TabIndex = 12;
            buttonPLUS.Text = "+";
            buttonPLUS.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Anchor = AnchorStyles.Top;
            button12.Location = new Point(191, 262);
            button12.Name = "button12";
            button12.Size = new Size(78, 76);
            button12.TabIndex = 11;
            button12.Text = "C";
            button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.Top;
            button11.Location = new Point(29, 261);
            button11.Name = "button11";
            button11.Size = new Size(74, 76);
            button11.TabIndex = 10;
            button11.Text = "=";
            button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Top;
            button10.Location = new Point(110, 262);
            button10.Name = "button10";
            button10.Size = new Size(75, 76);
            button10.TabIndex = 9;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Top;
            button9.Location = new Point(191, 180);
            button9.Name = "button9";
            button9.Size = new Size(78, 76);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top;
            button8.Location = new Point(109, 180);
            button8.Name = "button8";
            button8.Size = new Size(76, 76);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top;
            button7.Location = new Point(28, 180);
            button7.Name = "button7";
            button7.Size = new Size(75, 76);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top;
            button6.Location = new Point(191, 98);
            button6.Name = "button6";
            button6.Size = new Size(78, 76);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top;
            button5.Location = new Point(109, 98);
            button5.Name = "button5";
            button5.Size = new Size(76, 76);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top;
            button4.Location = new Point(28, 98);
            button4.Name = "button4";
            button4.Size = new Size(75, 76);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.Location = new Point(191, 16);
            button3.Name = "button3";
            button3.Size = new Size(78, 76);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Location = new Point(108, 16);
            button2.Name = "button2";
            button2.Size = new Size(77, 76);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Location = new Point(28, 16);
            button1.Name = "button1";
            button1.Size = new Size(74, 76);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonSQRT
            // 
            buttonSQRT.Anchor = AnchorStyles.Top;
            buttonSQRT.Location = new Point(356, 16);
            buttonSQRT.Name = "buttonSQRT";
            buttonSQRT.Size = new Size(75, 76);
            buttonSQRT.TabIndex = 15;
            buttonSQRT.Text = "√";
            buttonSQRT.UseVisualStyleBackColor = true;
            // 
            // buttonEXP
            // 
            buttonEXP.Anchor = AnchorStyles.Top;
            buttonEXP.Location = new Point(356, 98);
            buttonEXP.Name = "buttonEXP";
            buttonEXP.Size = new Size(75, 76);
            buttonEXP.TabIndex = 16;
            buttonEXP.Text = "^";
            buttonEXP.UseVisualStyleBackColor = true;
            // 
            // buttonOBracket
            // 
            buttonOBracket.Anchor = AnchorStyles.Top;
            buttonOBracket.Location = new Point(356, 180);
            buttonOBracket.Name = "buttonOBracket";
            buttonOBracket.Size = new Size(75, 76);
            buttonOBracket.TabIndex = 17;
            buttonOBracket.Text = "(";
            buttonOBracket.UseVisualStyleBackColor = true;
            // 
            // buttonCBracket
            // 
            buttonCBracket.Anchor = AnchorStyles.Top;
            buttonCBracket.Location = new Point(356, 261);
            buttonCBracket.Name = "buttonCBracket";
            buttonCBracket.Size = new Size(75, 76);
            buttonCBracket.TabIndex = 18;
            buttonCBracket.Text = ")";
            buttonCBracket.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 533);
            Controls.Add(panel1);
            Controls.Add(tbxTotal);
            Controls.Add(title);
            Name = "Form7";
            Text = "Máy tính bỏ túi";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label lblArray;
        private Label lblSum;
        private Label lblSumEven;
        private TextBox tbxTotal;
        private TextBox tbxSumEven;
        private Button buttonDIV;
        private Button btnSum;
        private Button btnSumEven;
        private Button btnSumOdd;
        private Label lblSumOdd;
        private TextBox tbxSumOdd;
        private TextBox tbxArray;
        private Panel panel1;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button buttonMUL;
        private Button buttonSUB;
        private Button buttonPLUS;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button buttonCBracket;
        private Button buttonOBracket;
        private Button buttonEXP;
        private Button buttonSQRT;
    }
}