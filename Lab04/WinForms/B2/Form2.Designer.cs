namespace WinForms.B2
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
            lblTruong = new Label();
            rdoRed = new RadioButton();
            rdoGreen = new RadioButton();
            rdoBlue = new RadioButton();
            rdoAutoColor = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            exit = new Button();
            label4 = new Label();
            rdoRegular = new CheckBox();
            rdoBold = new CheckBox();
            rdoItalic = new CheckBox();
            rdoBoldItalic = new CheckBox();
            SuspendLayout();
            // 
            // lblTruong
            // 
            lblTruong.AutoSize = true;
            lblTruong.Location = new Point(177, 45);
            lblTruong.Name = "lblTruong";
            lblTruong.Size = new Size(0, 20);
            lblTruong.TabIndex = 0;
            // 
            // rdoRed
            // 
            rdoRed.Anchor = AnchorStyles.Top;
            rdoRed.AutoSize = true;
            rdoRed.Location = new Point(520, 275);
            rdoRed.Name = "rdoRed";
            rdoRed.Size = new Size(56, 24);
            rdoRed.TabIndex = 9;
            rdoRed.TabStop = true;
            rdoRed.Text = "Red";
            rdoRed.UseVisualStyleBackColor = true;
            rdoRed.CheckedChanged += rdoMau_CheckedChanged;
            // 
            // rdoGreen
            // 
            rdoGreen.Anchor = AnchorStyles.Top;
            rdoGreen.AutoSize = true;
            rdoGreen.Location = new Point(520, 339);
            rdoGreen.Name = "rdoGreen";
            rdoGreen.Size = new Size(69, 24);
            rdoGreen.TabIndex = 10;
            rdoGreen.TabStop = true;
            rdoGreen.Text = "Green";
            rdoGreen.UseVisualStyleBackColor = true;
            rdoGreen.CheckedChanged += rdoMau_CheckedChanged;
            // 
            // rdoBlue
            // 
            rdoBlue.Anchor = AnchorStyles.Top;
            rdoBlue.AutoSize = true;
            rdoBlue.Location = new Point(520, 400);
            rdoBlue.Name = "rdoBlue";
            rdoBlue.Size = new Size(59, 24);
            rdoBlue.TabIndex = 11;
            rdoBlue.TabStop = true;
            rdoBlue.Text = "Blue";
            rdoBlue.UseVisualStyleBackColor = true;
            rdoBlue.CheckedChanged += rdoMau_CheckedChanged;
            // 
            // rdoAutoColor
            // 
            rdoAutoColor.Anchor = AnchorStyles.Top;
            rdoAutoColor.AutoSize = true;
            rdoAutoColor.Location = new Point(520, 211);
            rdoAutoColor.Name = "rdoAutoColor";
            rdoAutoColor.Size = new Size(98, 24);
            rdoAutoColor.TabIndex = 8;
            rdoAutoColor.TabStop = true;
            rdoAutoColor.Text = "AutoColor";
            rdoAutoColor.UseVisualStyleBackColor = true;
            rdoAutoColor.CheckedChanged += rdoMau_CheckedChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(146, 177);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 12;
            label2.Text = "Font Style";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(481, 177);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 13;
            label3.Text = "Color";
            // 
            // exit
            // 
            exit.Anchor = AnchorStyles.Top;
            exit.Location = new Point(361, 476);
            exit.Name = "exit";
            exit.Size = new Size(124, 52);
            exit.TabIndex = 14;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += btnExit_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(119, 45);
            label4.Name = "label4";
            label4.Size = new Size(599, 103);
            label4.TabIndex = 15;
            label4.Text = "Trường Đại học Công nghệ Thực Phẩm         Khoa Công Nghệ Thông tin";
            // 
            // rdoRegular
            // 
            rdoRegular.Anchor = AnchorStyles.Top;
            rdoRegular.AutoSize = true;
            rdoRegular.Location = new Point(211, 212);
            rdoRegular.Name = "rdoRegular";
            rdoRegular.Size = new Size(82, 24);
            rdoRegular.TabIndex = 16;
            rdoRegular.Text = "Regular";
            rdoRegular.UseVisualStyleBackColor = true;
            rdoRegular.CheckedChanged += rdoKieuChu_CheckedChanged;
            // 
            // rdoBold
            // 
            rdoBold.Anchor = AnchorStyles.Top;
            rdoBold.AutoSize = true;
            rdoBold.Location = new Point(211, 275);
            rdoBold.Name = "rdoBold";
            rdoBold.Size = new Size(62, 24);
            rdoBold.TabIndex = 17;
            rdoBold.Text = "Bold";
            rdoBold.UseVisualStyleBackColor = true;
            rdoBold.CheckedChanged += rdoKieuChu_CheckedChanged;
            // 
            // rdoItalic
            // 
            rdoItalic.Anchor = AnchorStyles.Top;
            rdoItalic.AutoSize = true;
            rdoItalic.Location = new Point(211, 340);
            rdoItalic.Name = "rdoItalic";
            rdoItalic.Size = new Size(63, 24);
            rdoItalic.TabIndex = 18;
            rdoItalic.Text = "Italic";
            rdoItalic.UseVisualStyleBackColor = true;
            rdoItalic.CheckedChanged += rdoKieuChu_CheckedChanged;
            // 
            // rdoBoldItalic
            // 
            rdoBoldItalic.Anchor = AnchorStyles.Top;
            rdoBoldItalic.AutoSize = true;
            rdoBoldItalic.Location = new Point(211, 400);
            rdoBoldItalic.Name = "rdoBoldItalic";
            rdoBoldItalic.Size = new Size(127, 24);
            rdoBoldItalic.TabIndex = 19;
            rdoBoldItalic.Text = "Bold and Italic";
            rdoBoldItalic.UseVisualStyleBackColor = true;
            rdoBoldItalic.CheckedChanged += rdoKieuChu_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 607);
            Controls.Add(rdoBoldItalic);
            Controls.Add(rdoItalic);
            Controls.Add(rdoBold);
            Controls.Add(rdoRegular);
            Controls.Add(label4);
            Controls.Add(exit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rdoAutoColor);
            Controls.Add(rdoBlue);
            Controls.Add(rdoGreen);
            Controls.Add(rdoRed);
            Controls.Add(lblTruong);
            Name = "Form2";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTruong;
        private RadioButton rdoRed;
        private RadioButton rdoGreen;
        private RadioButton rdoBlue;
        private RadioButton rdoAutoColor;
        private Label label2;
        private Label label3;
        private Button exit;
        private Label label4;
        private CheckBox rdoRegular;
        private CheckBox rdoBold;
        private CheckBox rdoItalic;
        private CheckBox rdoBoldItalic;
    }
}