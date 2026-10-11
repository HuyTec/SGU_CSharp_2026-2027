namespace WinFormsApp1._5d
{
    partial class frmLop
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
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtMaLop = new TextBox();
            txtMaKhoa = new TextBox();
            lblMaLop = new Label();
            lblMaKhoa = new Label();
            txtTenLop = new TextBox();
            lblTenLop = new Label();
            SuspendLayout();
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.Location = new Point(335, 179);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 63);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.Location = new Point(235, 179);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 63);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.Location = new Point(135, 179);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 63);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtMaLop
            // 
            txtMaLop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMaLop.Location = new Point(201, 79);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(230, 27);
            txtMaLop.TabIndex = 14;
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMaKhoa.Location = new Point(201, 34);
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(230, 27);
            txtMaKhoa.TabIndex = 13;
            // 
            // lblMaLop
            // 
            lblMaLop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMaLop.AutoSize = true;
            lblMaLop.Location = new Point(129, 82);
            lblMaLop.Name = "lblMaLop";
            lblMaLop.Size = new Size(59, 20);
            lblMaLop.TabIndex = 12;
            lblMaLop.Text = "Mã Lớp";
            // 
            // lblMaKhoa
            // 
            lblMaKhoa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMaKhoa.AutoSize = true;
            lblMaKhoa.Location = new Point(129, 37);
            lblMaKhoa.Name = "lblMaKhoa";
            lblMaKhoa.Size = new Size(66, 20);
            lblMaKhoa.TabIndex = 11;
            lblMaKhoa.Text = "Mã khoa";
            // 
            // txtTenLop
            // 
            txtTenLop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTenLop.Location = new Point(201, 122);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(230, 27);
            txtTenLop.TabIndex = 17;
            // 
            // lblTenLop
            // 
            lblTenLop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTenLop.AutoSize = true;
            lblTenLop.Location = new Point(129, 125);
            lblTenLop.Name = "lblTenLop";
            lblTenLop.Size = new Size(61, 20);
            lblTenLop.TabIndex = 16;
            lblTenLop.Text = "Tên Lớp";
            // 
            // frmLop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 259);
            Controls.Add(txtTenLop);
            Controls.Add(lblTenLop);
            Controls.Add(txtMaLop);
            Controls.Add(txtMaKhoa);
            Controls.Add(lblMaLop);
            Controls.Add(lblMaKhoa);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Name = "frmLop";
            Text = "frmLop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtMaLop;
        private TextBox txtMaKhoa;
        private Label lblMaLop;
        private Label lblMaKhoa;
        private TextBox txtTenLop;
        private Label lblTenLop;
    }
}