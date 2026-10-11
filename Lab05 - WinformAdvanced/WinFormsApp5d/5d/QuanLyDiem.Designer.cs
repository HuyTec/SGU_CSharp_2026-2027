namespace WinFormsApp1._5d
{
    partial class QuanLyDiem
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
            txtDiem = new TextBox();
            lblDiem = new Label();
            txtMaMH = new TextBox();
            txtMaSV = new TextBox();
            lblMaMH = new Label();
            lblMaSV = new Label();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            SuspendLayout();
            // 
            // txtDiem
            // 
            txtDiem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDiem.Location = new Point(172, 119);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(208, 27);
            txtDiem.TabIndex = 35;
            // 
            // lblDiem
            // 
            lblDiem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDiem.AutoSize = true;
            lblDiem.Location = new Point(83, 122);
            lblDiem.Name = "lblDiem";
            lblDiem.Size = new Size(45, 20);
            lblDiem.TabIndex = 34;
            lblDiem.Text = "Điểm";
            // 
            // txtMaMH
            // 
            txtMaMH.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMaMH.Location = new Point(172, 76);
            txtMaMH.Name = "txtMaMH";
            txtMaMH.Size = new Size(208, 27);
            txtMaMH.TabIndex = 33;
            // 
            // txtMaSV
            // 
            txtMaSV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMaSV.Location = new Point(172, 31);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(208, 27);
            txtMaSV.TabIndex = 32;
            // 
            // lblMaMH
            // 
            lblMaMH.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMaMH.AutoSize = true;
            lblMaMH.Location = new Point(83, 79);
            lblMaMH.Name = "lblMaMH";
            lblMaMH.Size = new Size(92, 20);
            lblMaMH.TabIndex = 31;
            lblMaMH.Text = "Mã môn học";
            // 
            // lblMaSV
            // 
            lblMaSV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(83, 34);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(51, 20);
            lblMaSV.TabIndex = 30;
            lblMaSV.Text = "Mã SV";
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.Location = new Point(286, 176);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 63);
            btnXoa.TabIndex = 29;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.Location = new Point(186, 176);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 63);
            btnSua.TabIndex = 28;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.Location = new Point(86, 176);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 63);
            btnThem.TabIndex = 27;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // QuanLyDiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 271);
            Controls.Add(txtDiem);
            Controls.Add(lblDiem);
            Controls.Add(txtMaMH);
            Controls.Add(txtMaSV);
            Controls.Add(lblMaMH);
            Controls.Add(lblMaSV);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Name = "QuanLyDiem";
            Text = "Quản lý điểm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenLop;
        private Label lblTenLop;
        private TextBox txtMaLop;
        private TextBox txtMaKhoa;
        private Label lblMaLop;
        private Label lblMaSV;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtDiem;
        private Label lblDiem;
        private TextBox txtMaMH;
        private TextBox txtMaSV;
        private Label lblMaMH;
    }
}