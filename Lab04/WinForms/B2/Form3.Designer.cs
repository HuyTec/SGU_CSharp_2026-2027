namespace WinForms.B21
{
    partial class Form3
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
            lblA = new Label();
            lblB = new Label();
            lblGcd = new Label();
            lblLcm = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btnExe = new Button();
            btnCont = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top;
            title.AutoSize = true;
            title.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = Color.FromArgb(192, 0, 0);
            title.Location = new Point(132, 20);
            title.Name = "title";
            title.Size = new Size(401, 37);
            title.TabIndex = 0;
            title.Text = "Ước số chung - Bội số chung";
            // 
            // lblA
            // 
            lblA.Anchor = AnchorStyles.Top;
            lblA.AutoSize = true;
            lblA.Location = new Point(149, 81);
            lblA.Name = "lblA";
            lblA.Size = new Size(83, 20);
            lblA.TabIndex = 1;
            lblA.Text = "Nhập số a: ";
            // 
            // lblB
            // 
            lblB.Anchor = AnchorStyles.Top;
            lblB.AutoSize = true;
            lblB.Location = new Point(149, 132);
            lblB.Name = "lblB";
            lblB.Size = new Size(80, 20);
            lblB.TabIndex = 2;
            lblB.Text = "Nhập số b:";
            // 
            // lblGcd
            // 
            lblGcd.Anchor = AnchorStyles.Top;
            lblGcd.AutoSize = true;
            lblGcd.Location = new Point(149, 182);
            lblGcd.Name = "lblGcd";
            lblGcd.Size = new Size(141, 20);
            lblGcd.TabIndex = 3;
            lblGcd.Text = "Ước chung lớn nhất:";
            // 
            // lblLcm
            // 
            lblLcm.Anchor = AnchorStyles.Top;
            lblLcm.AutoSize = true;
            lblLcm.Location = new Point(149, 232);
            lblLcm.Name = "lblLcm";
            lblLcm.Size = new Size(140, 20);
            lblLcm.TabIndex = 4;
            lblLcm.Text = "Bội chung nhỏ nhất:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.Location = new Point(248, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top;
            textBox2.Location = new Point(248, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top;
            textBox3.Location = new Point(298, 179);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top;
            textBox4.Location = new Point(298, 229);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 8;
            // 
            // btnExe
            // 
            btnExe.Anchor = AnchorStyles.Top;
            btnExe.Location = new Point(105, 298);
            btnExe.Name = "btnExe";
            btnExe.Size = new Size(104, 45);
            btnExe.TabIndex = 9;
            btnExe.Text = "Thực hiện";
            btnExe.UseVisualStyleBackColor = true;
            btnExe.Click += btnExe_Click;
            // 
            // btnCont
            // 
            btnCont.Anchor = AnchorStyles.Top;
            btnCont.Location = new Point(274, 298);
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
            button3.Location = new Point(445, 298);
            button3.Name = "button3";
            button3.Size = new Size(105, 45);
            button3.TabIndex = 11;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 377);
            Controls.Add(button3);
            Controls.Add(btnCont);
            Controls.Add(btnExe);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblLcm);
            Controls.Add(lblGcd);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(title);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label lblA;
        private Label lblB;
        private Label lblGcd;
        private Label lblLcm;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btnExe;
        private Button btnCont;
        private Button button3;
    }
}