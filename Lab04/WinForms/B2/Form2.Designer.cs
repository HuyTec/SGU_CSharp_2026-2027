namespace WinForms.B21
{
    partial class Form2
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
            lblName = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblconfirmPassword = new Label();
            tName = new TextBox();
            tEmail = new TextBox();
            tPassword = new TextBox();
            tConfimPassword = new TextBox();
            btnSubmit = new Button();
            valid = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top;
            title.AutoSize = true;
            title.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = Color.FromArgb(0, 192, 192);
            title.Location = new Point(207, 9);
            title.Name = "title";
            title.Size = new Size(284, 36);
            title.TabIndex = 0;
            title.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top;
            lblName.AutoSize = true;
            lblName.Location = new Point(67, 61);
            lblName.Name = "lblName";
            lblName.Size = new Size(107, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Tên đăng nhập";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(67, 112);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(96, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Địa chỉ email";
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top;
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(67, 165);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Mật khẩu";
            // 
            // lblconfirmPassword
            // 
            lblconfirmPassword.Anchor = AnchorStyles.Top;
            lblconfirmPassword.AutoSize = true;
            lblconfirmPassword.Location = new Point(67, 218);
            lblconfirmPassword.Name = "lblconfirmPassword";
            lblconfirmPassword.Size = new Size(134, 20);
            lblconfirmPassword.TabIndex = 4;
            lblconfirmPassword.Text = "Xác nhận mật khẩu";
            // 
            // tName
            // 
            tName.Anchor = AnchorStyles.Top;
            tName.Location = new Point(207, 58);
            tName.Name = "tName";
            tName.Size = new Size(388, 27);
            tName.TabIndex = 5;
            // 
            // tEmail
            // 
            tEmail.Anchor = AnchorStyles.Top;
            tEmail.Location = new Point(207, 109);
            tEmail.Name = "tEmail";
            tEmail.Size = new Size(388, 27);
            tEmail.TabIndex = 6;
            tEmail.Validating += tEmail_Validating;
            // 
            // tPassword
            // 
            tPassword.Anchor = AnchorStyles.Top;
            tPassword.Location = new Point(207, 162);
            tPassword.Name = "tPassword";
            tPassword.Size = new Size(388, 27);
            tPassword.TabIndex = 7;
            // 
            // tConfimPassword
            // 
            tConfimPassword.Anchor = AnchorStyles.Top;
            tConfimPassword.Location = new Point(207, 215);
            tConfimPassword.Name = "tConfimPassword";
            tConfimPassword.Size = new Size(388, 27);
            tConfimPassword.TabIndex = 8;
            tConfimPassword.KeyDown += tConfimPassword_KeyDown;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Top;
            btnSubmit.BackColor = SystemColors.Control;
            btnSubmit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.FromArgb(0, 0, 192);
            btnSubmit.Location = new Point(270, 280);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(133, 57);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Đăng ký";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // valid
            // 
            valid.Anchor = AnchorStyles.Top;
            valid.AutoSize = true;
            valid.ForeColor = Color.FromArgb(192, 0, 0);
            valid.Location = new Point(601, 61);
            valid.Name = "valid";
            valid.Size = new Size(25, 20);
            valid.TabIndex = 10;
            valid.Text = "(*)";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(601, 116);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 11;
            label1.Text = "(*)";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(601, 165);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 12;
            label2.Text = "(*)";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 372);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(valid);
            Controls.Add(btnSubmit);
            Controls.Add(tConfimPassword);
            Controls.Add(tPassword);
            Controls.Add(tEmail);
            Controls.Add(tName);
            Controls.Add(lblconfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(title);
            Name = "Form2";
            Text = "Form1";
            FormClosing += Form2_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label lblName;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblconfirmPassword;
        private TextBox tName;
        private TextBox tEmail;
        private TextBox tPassword;
        private TextBox tConfimPassword;
        private Button btnSubmit;
        private Label valid;
        private Label label1;
        private Label label2;
    }
}