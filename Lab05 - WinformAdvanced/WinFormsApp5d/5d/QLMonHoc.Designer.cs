namespace WinFormsApp1._5d
{
    partial class QLMonHoc
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
            lblMaMh = new Label();
            lblTenMh = new Label();
            txtMaMh = new TextBox();
            txtTenMh = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            SuspendLayout();
            // 
            // lblMaMh
            // 
            lblMaMh.AutoSize = true;
            lblMaMh.Location = new Point(34, 36);
            lblMaMh.Name = "lblMaMh";
            lblMaMh.Size = new Size(55, 20);
            lblMaMh.TabIndex = 4;
            lblMaMh.Text = "Mã mh";
            // 
            // lblTenMh
            // 
            lblTenMh.AutoSize = true;
            lblTenMh.Location = new Point(34, 83);
            lblTenMh.Name = "lblTenMh";
            lblTenMh.Size = new Size(57, 20);
            lblTenMh.TabIndex = 3;
            lblTenMh.Text = "Tên mh";
            // 
            // txtMaMh
            // 
            txtMaMh.Location = new Point(111, 33);
            txtMaMh.Name = "txtMaMh";
            txtMaMh.Size = new Size(235, 27);
            txtMaMh.TabIndex = 0;
            // 
            // txtTenMh
            // 
            txtTenMh.Location = new Point(111, 80);
            txtTenMh.Name = "txtTenMh";
            txtTenMh.Size = new Size(235, 27);
            txtTenMh.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(53, 126);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 35);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(145, 126);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 35);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(237, 126);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 35);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // QLMonHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 195);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtTenMh);
            Controls.Add(txtMaMh);
            Controls.Add(lblTenMh);
            Controls.Add(lblMaMh);
            Name = "QLMonHoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Môn Học";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaMh;
        private Label lblTenMh;
        private TextBox txtMaMh;
        private TextBox txtTenMh;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
    }
}