namespace WinForms.B21
{
    partial class Form4
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
            lblLength = new Label();
            lblArray = new Label();
            lblSum = new Label();
            lblSumEven = new Label();
            textBox1 = new TextBox();
            tbxSum = new TextBox();
            tbxSumEven = new TextBox();
            btnExe = new Button();
            btnSum = new Button();
            btnSumEven = new Button();
            btnSumOdd = new Button();
            btnCont = new Button();
            button3 = new Button();
            lblSumOdd = new Label();
            tbxSumOdd = new TextBox();
            tbxArray = new TextBox();
            SuspendLayout();
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top;
            title.AutoSize = true;
            title.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = Color.FromArgb(192, 0, 0);
            title.Location = new Point(149, 24);
            title.Name = "title";
            title.Size = new Size(360, 37);
            title.TabIndex = 0;
            title.Text = "Nhập dãy số và Tính tổng";
            // 
            // lblLength
            // 
            lblLength.Anchor = AnchorStyles.Top;
            lblLength.AutoSize = true;
            lblLength.Location = new Point(149, 81);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(71, 20);
            lblLength.TabIndex = 1;
            lblLength.Text = "Nhập số: ";
            // 
            // lblArray
            // 
            lblArray.Anchor = AnchorStyles.Top;
            lblArray.AutoSize = true;
            lblArray.Location = new Point(149, 132);
            lblArray.Name = "lblArray";
            lblArray.Size = new Size(103, 20);
            lblArray.TabIndex = 2;
            lblArray.Text = "Dãy vừa nhập:";
            // 
            // lblSum
            // 
            lblSum.Anchor = AnchorStyles.Top;
            lblSum.AutoSize = true;
            lblSum.Location = new Point(149, 182);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(155, 20);
            lblSum.TabIndex = 3;
            lblSum.Text = "Tổng các phần tử dãy:";
            // 
            // lblSumEven
            // 
            lblSumEven.Anchor = AnchorStyles.Top;
            lblSumEven.AutoSize = true;
            lblSumEven.Location = new Point(149, 232);
            lblSumEven.Name = "lblSumEven";
            lblSumEven.Size = new Size(81, 20);
            lblSumEven.TabIndex = 4;
            lblSumEven.Text = "Tổng chẵn:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.Location = new Point(248, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 27);
            textBox1.TabIndex = 5;
            // 
            // tbxSum
            // 
            tbxSum.Anchor = AnchorStyles.Top;
            tbxSum.Location = new Point(310, 179);
            tbxSum.Name = "tbxSum";
            tbxSum.ReadOnly = true;
            tbxSum.Size = new Size(199, 27);
            tbxSum.TabIndex = 7;
            // 
            // tbxSumEven
            // 
            tbxSumEven.Anchor = AnchorStyles.Top;
            tbxSumEven.Location = new Point(236, 229);
            tbxSumEven.Name = "tbxSumEven";
            tbxSumEven.ReadOnly = true;
            tbxSumEven.Size = new Size(89, 27);
            tbxSumEven.TabIndex = 8;
            // 
            // btnExe
            // 
            btnExe.Anchor = AnchorStyles.Top;
            btnExe.Location = new Point(405, 78);
            btnExe.Name = "btnExe";
            btnExe.Size = new Size(104, 27);
            btnExe.TabIndex = 9;
            btnExe.Text = "Nhập";
            btnExe.UseVisualStyleBackColor = true;
            btnExe.Click += btnExe_Click;
            // 
            // btnSum
            // 
            btnSum.Anchor = AnchorStyles.Top;
            btnSum.Location = new Point(165, 265);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(104, 27);
            btnSum.TabIndex = 15;
            btnSum.Text = "Tính tổng";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // btnSumEven
            // 
            btnSumEven.Anchor = AnchorStyles.Top;
            btnSumEven.Location = new Point(275, 265);
            btnSumEven.Name = "btnSumEven";
            btnSumEven.Size = new Size(106, 27);
            btnSumEven.TabIndex = 16;
            btnSumEven.Text = "Tổng chẵn";
            btnSumEven.UseVisualStyleBackColor = true;
            btnSumEven.Click += btnSumEven_Click;
            // 
            // btnSumOdd
            // 
            btnSumOdd.Anchor = AnchorStyles.Top;
            btnSumOdd.Location = new Point(387, 265);
            btnSumOdd.Name = "btnSumOdd";
            btnSumOdd.Size = new Size(111, 27);
            btnSumOdd.TabIndex = 17;
            btnSumOdd.Text = "Tổng lẻ";
            btnSumOdd.UseVisualStyleBackColor = true;
            btnSumOdd.Click += btnSumOdd_Click;
            // 
            // btnCont
            // 
            btnCont.Anchor = AnchorStyles.Top;
            btnCont.Location = new Point(182, 298);
            btnCont.Name = "btnCont";
            btnCont.Size = new Size(107, 45);
            btnCont.TabIndex = 10;
            btnCont.Text = "Tiếp tục";
            btnCont.UseVisualStyleBackColor = true;
            btnCont.Click += btnCont_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.Location = new Point(355, 298);
            button3.Name = "button3";
            button3.Size = new Size(105, 45);
            button3.TabIndex = 11;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lblSumOdd
            // 
            lblSumOdd.Anchor = AnchorStyles.Top;
            lblSumOdd.AutoSize = true;
            lblSumOdd.Location = new Point(338, 232);
            lblSumOdd.Name = "lblSumOdd";
            lblSumOdd.Size = new Size(62, 20);
            lblSumOdd.TabIndex = 12;
            lblSumOdd.Text = "Tổng lẻ:";
            // 
            // tbxSumOdd
            // 
            tbxSumOdd.Anchor = AnchorStyles.Top;
            tbxSumOdd.Location = new Point(405, 229);
            tbxSumOdd.Name = "tbxSumOdd";
            tbxSumOdd.ReadOnly = true;
            tbxSumOdd.Size = new Size(104, 27);
            tbxSumOdd.TabIndex = 13;
            // 
            // tbxArray
            // 
            tbxArray.Anchor = AnchorStyles.Top;
            tbxArray.Location = new Point(258, 129);
            tbxArray.Name = "tbxArray";
            tbxArray.ReadOnly = true;
            tbxArray.Size = new Size(251, 27);
            tbxArray.TabIndex = 14;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 377);
            Controls.Add(tbxArray);
            Controls.Add(tbxSumOdd);
            Controls.Add(lblSumOdd);
            Controls.Add(btnSumOdd);
            Controls.Add(btnSumEven);
            Controls.Add(btnSum);
            Controls.Add(button3);
            Controls.Add(btnCont);
            Controls.Add(btnExe);
            Controls.Add(tbxSumEven);
            Controls.Add(tbxSum);
            Controls.Add(textBox1);
            Controls.Add(lblSumEven);
            Controls.Add(lblSum);
            Controls.Add(lblArray);
            Controls.Add(lblLength);
            Controls.Add(title);
            Name = "Form4";
            Text = "Nhập dãy số và tính tổng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label lblLength;
        private Label lblArray;
        private Label lblSum;
        private Label lblSumEven;
        private TextBox textBox1;
        private TextBox tbxSum;
        private TextBox tbxSumEven;
        private Button btnExe;
        private Button btnSum;
        private Button btnSumEven;
        private Button btnSumOdd;
        private Button btnCont;
        private Button button3;
        private Label lblSumOdd;
        private TextBox tbxSumOdd;
        private TextBox tbxArray;
    }
}