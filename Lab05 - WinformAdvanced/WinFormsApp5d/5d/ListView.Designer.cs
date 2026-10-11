namespace WinFormsApp1._5d
{
    partial class ListView
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
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            lblMaSV = new Label();
            lblHoTen = new Label();
            tbMaSV = new TextBox();
            tbHoTen = new TextBox();
            lstv1 = new System.Windows.Forms.ListView();
            MaSV = new ColumnHeader();
            HoTen = new ColumnHeader();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.Location = new Point(249, 12);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.Location = new Point(349, 12);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.Location = new Point(449, 12);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // lblMaSV
            // 
            lblMaSV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(132, 68);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(51, 20);
            lblMaSV.TabIndex = 3;
            lblMaSV.Text = "Mã SV";
            // 
            // lblHoTen
            // 
            lblHoTen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(132, 132);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(56, 20);
            lblHoTen.TabIndex = 4;
            lblHoTen.Text = "Họ Tên";
            // 
            // tbMaSV
            // 
            tbMaSV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbMaSV.Location = new Point(188, 65);
            tbMaSV.Name = "tbMaSV";
            tbMaSV.Size = new Size(465, 27);
            tbMaSV.TabIndex = 5;
            // 
            // tbHoTen
            // 
            tbHoTen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbHoTen.Location = new Point(188, 129);
            tbHoTen.Name = "tbHoTen";
            tbHoTen.Size = new Size(465, 27);
            tbHoTen.TabIndex = 6;
            // 
            // lstv1
            // 
            lstv1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstv1.Columns.AddRange(new ColumnHeader[] { MaSV, HoTen });
            lstv1.Location = new Point(33, 181);
            lstv1.Name = "lstv1";
            lstv1.Size = new Size(730, 337);
            lstv1.TabIndex = 7;
            lstv1.UseCompatibleStateImageBehavior = false;
            lstv1.View = View.Details;
            lstv1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // MaSV
            // 
            MaSV.Text = "Mã số SV";
            MaSV.Width = 90;
            // 
            // HoTen
            // 
            HoTen.Text = "Họ và Tên";
            HoTen.TextAlign = HorizontalAlignment.Center;
            HoTen.Width = 150;
            // 
            // ListView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 554);
            Controls.Add(lstv1);
            Controls.Add(tbHoTen);
            Controls.Add(tbMaSV);
            Controls.Add(lblHoTen);
            Controls.Add(lblMaSV);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Name = "ListView";
            Text = "ListView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Label lblMaSV;
        private Label lblHoTen;
        private TextBox tbMaSV;
        private TextBox tbHoTen;
        private System.Windows.Forms.ListView lstv1;
        private ColumnHeader MaSV;
        private ColumnHeader HoTen;
    }
}