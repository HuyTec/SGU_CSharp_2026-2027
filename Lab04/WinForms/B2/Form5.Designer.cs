namespace WinForms.B21
{
    partial class Form5
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
            lblNum = new Label();
            textBox1 = new TextBox();
            tbxResult = new TextBox();
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
            title.Location = new Point(136, 21);
            title.Name = "title";
            title.Size = new Size(250, 37);
            title.TabIndex = 0;
            title.Text = "Đọc số thành chữ";
            // 
            // lblNum
            // 
            lblNum.Anchor = AnchorStyles.Top;
            lblNum.AutoSize = true;
            lblNum.Location = new Point(83, 81);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(160, 20);
            lblNum.TabIndex = 1;
            lblNum.Text = "Nhập số (từ 1 đến 999): ";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.Location = new Point(244, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(89, 27);
            textBox1.TabIndex = 5;
            // 
            // tbxResult
            // 
            tbxResult.Anchor = AnchorStyles.Top;
            tbxResult.Location = new Point(144, 122);
            tbxResult.Name = "tbxResult";
            tbxResult.ReadOnly = true;
            tbxResult.Size = new Size(199, 27);
            tbxResult.TabIndex = 7;
            // 
            // btnExe
            // 
            btnExe.Anchor = AnchorStyles.Top;
            btnExe.Location = new Point(339, 78);
            btnExe.Name = "btnExe";
            btnExe.Size = new Size(104, 27);
            btnExe.TabIndex = 9;
            btnExe.Text = "Thực hiện";
            btnExe.UseVisualStyleBackColor = true;
            btnExe.Click += btnExe_Click;
            // 
            // btnCont
            // 
            btnCont.Anchor = AnchorStyles.Top;
            btnCont.Location = new Point(136, 167);
            btnCont.Name = "btnCont";
            btnCont.Size = new Size(107, 45);
            btnCont.TabIndex = 10;
            btnCont.Text = "Xóa";
            btnCont.UseVisualStyleBackColor = true;
            btnCont.Click += btnCont_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.Location = new Point(289, 167);
            button3.Name = "button3";
            button3.Size = new Size(105, 45);
            button3.TabIndex = 11;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 274);
            Controls.Add(button3);
            Controls.Add(btnCont);
            Controls.Add(btnExe);
            Controls.Add(tbxResult);
            Controls.Add(textBox1);
            Controls.Add(lblNum);
            Controls.Add(title);
            Name = "Form5";
            Text = "Nhập dãy số và tính tổng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label lblNum;
        private Label lblArray;
        private Label lblSum;
        private Label lblSumEven;
        private TextBox textBox1;
        private TextBox tbxResult;
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