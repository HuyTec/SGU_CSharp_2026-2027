namespace WinFormsApp1._5d
{
    partial class QLSinhVien
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
            txtMaLop = new TextBox();
            lblMaLop = new Label();
            txtMaSV = new TextBox();
            lblMaSV = new Label();
            tbHoTen = new TextBox();
            lblHoTen = new Label();
            lblDate = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            SuspendLayout();
            // 
            // txtMaLop
            // 
            txtMaLop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMaLop.Location = new Point(151, 45);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(282, 27);
            txtMaLop.TabIndex = 16;
            txtMaLop.TextChanged += txtMaLop_TextChanged;
            // 
            // lblMaLop
            // 
            lblMaLop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMaLop.AutoSize = true;
            lblMaLop.Location = new Point(66, 48);
            lblMaLop.Name = "lblMaLop";
            lblMaLop.Size = new Size(59, 20);
            lblMaLop.TabIndex = 15;
            lblMaLop.Text = "Mã Lớp";
            // 
            // txtMaSV
            // 
            txtMaSV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMaSV.Location = new Point(151, 90);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(282, 27);
            txtMaSV.TabIndex = 34;
            // 
            // lblMaSV
            // 
            lblMaSV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(66, 93);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(51, 20);
            lblMaSV.TabIndex = 33;
            lblMaSV.Text = "Mã SV";
            lblMaSV.Click += lblMaSV_Click;
            // 
            // tbHoTen
            // 
            tbHoTen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbHoTen.Location = new Point(151, 137);
            tbHoTen.Name = "tbHoTen";
            tbHoTen.Size = new Size(282, 27);
            tbHoTen.TabIndex = 36;
            // 
            // lblHoTen
            // 
            lblHoTen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(66, 140);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(56, 20);
            lblHoTen.TabIndex = 35;
            lblHoTen.Text = "Họ Tên";
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDate.AutoSize = true;
            lblDate.Location = new Point(66, 188);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(74, 20);
            lblDate.TabIndex = 37;
            lblDate.Text = "Ngày sinh";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(151, 183);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(281, 27);
            dateTimePicker1.TabIndex = 38;
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.Checked = false;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.Location = new Point(304, 229);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 63);
            btnXoa.TabIndex = 41;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.Location = new Point(204, 229);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 63);
            btnSua.TabIndex = 40;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.Location = new Point(104, 229);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 63);
            btnThem.TabIndex = 39;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // QLSinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 325);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblDate);
            Controls.Add(tbHoTen);
            Controls.Add(lblHoTen);
            Controls.Add(txtMaSV);
            Controls.Add(lblMaSV);
            Controls.Add(txtMaLop);
            Controls.Add(lblMaLop);
            Name = "QLSinhVien";
            Text = "QLSinhVien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaLop;
        private Label lblMaLop;
        private TextBox txtMaSV;
        private Label lblMaSV;
        private TextBox tbHoTen;
        private Label lblHoTen;
        private Label lblDate;
        private DateTimePicker dateTimePicker1;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}