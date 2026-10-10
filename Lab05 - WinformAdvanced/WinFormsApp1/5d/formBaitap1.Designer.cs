namespace WinFormsApp1._5d
{
    partial class formBaitap1
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
            labelName = new Label();
            labelID = new Label();
            labelSex = new Label();
            labelForeignLang = new Label();
            labelEthnic = new Label();
            lstv1 = new System.Windows.Forms.ListView();
            columnHeaderName = new ColumnHeader();
            columnHeaderId = new ColumnHeader();
            columnHeaderSex = new ColumnHeader();
            columnHeaderLang = new ColumnHeader();
            columnHeaderEth = new ColumnHeader();
            textBoxName = new TextBox();
            textBoxId = new TextBox();
            radioButtonMale = new RadioButton();
            radioButtonFemale = new RadioButton();
            checkBoxEng = new CheckBox();
            checkBoxFra = new CheckBox();
            checkBoxChi = new CheckBox();
            comboBoxEth = new ComboBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(105, 32);
            labelName.Name = "labelName";
            labelName.Size = new Size(73, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Họ và tên";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(105, 82);
            labelID.Name = "labelID";
            labelID.Size = new Size(51, 20);
            labelID.TabIndex = 1;
            labelID.Text = "Mã SV";
            // 
            // labelSex
            // 
            labelSex.AutoSize = true;
            labelSex.Location = new Point(105, 132);
            labelSex.Name = "labelSex";
            labelSex.Size = new Size(65, 20);
            labelSex.TabIndex = 2;
            labelSex.Text = "Giới tính";
            // 
            // labelForeignLang
            // 
            labelForeignLang.AutoSize = true;
            labelForeignLang.Location = new Point(105, 187);
            labelForeignLang.Name = "labelForeignLang";
            labelForeignLang.Size = new Size(80, 20);
            labelForeignLang.TabIndex = 3;
            labelForeignLang.Text = "Ngoại ngữ";
            // 
            // labelEthnic
            // 
            labelEthnic.AutoSize = true;
            labelEthnic.Location = new Point(105, 242);
            labelEthnic.Name = "labelEthnic";
            labelEthnic.Size = new Size(61, 20);
            labelEthnic.TabIndex = 4;
            labelEthnic.Text = "Dân tộc";
            labelEthnic.Click += label5_Click;
            // 
            // lstv1
            // 
            lstv1.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderId, columnHeaderSex, columnHeaderLang, columnHeaderEth });
            lstv1.Location = new Point(76, 287);
            lstv1.Name = "lstv1";
            lstv1.Size = new Size(485, 291);
            lstv1.TabIndex = 5;
            lstv1.UseCompatibleStateImageBehavior = false;
            lstv1.View = View.Details;
            lstv1.SelectedIndexChanged += lstv1_SelectedIndexChanged;
            lstv1.MouseDown += lstv1_MouseDown;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Họ và tên";
            columnHeaderName.Width = 100;
            // 
            // columnHeaderId
            // 
            columnHeaderId.Text = "Mã sinh viên";
            columnHeaderId.Width = 100;
            // 
            // columnHeaderSex
            // 
            columnHeaderSex.Text = "Giới tính";
            columnHeaderSex.Width = 80;
            // 
            // columnHeaderLang
            // 
            columnHeaderLang.Text = "Ngoại ngữ";
            columnHeaderLang.Width = 100;
            // 
            // columnHeaderEth
            // 
            columnHeaderEth.Text = "Dân tộc";
            columnHeaderEth.Width = 100;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(184, 29);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(330, 27);
            textBoxName.TabIndex = 6;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(184, 79);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(330, 27);
            textBoxId.TabIndex = 7;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(240, 132);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(62, 24);
            radioButtonMale.TabIndex = 8;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Nam";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(376, 132);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(50, 24);
            radioButtonFemale.TabIndex = 9;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Nữ";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // checkBoxEng
            // 
            checkBoxEng.AutoSize = true;
            checkBoxEng.Location = new Point(204, 186);
            checkBoxEng.Name = "checkBoxEng";
            checkBoxEng.Size = new Size(57, 24);
            checkBoxEng.TabIndex = 10;
            checkBoxEng.Text = "Anh";
            checkBoxEng.UseVisualStyleBackColor = true;
            // 
            // checkBoxFra
            // 
            checkBoxFra.AutoSize = true;
            checkBoxFra.Location = new Point(298, 186);
            checkBoxFra.Name = "checkBoxFra";
            checkBoxFra.Size = new Size(64, 24);
            checkBoxFra.TabIndex = 11;
            checkBoxFra.Text = "Pháp";
            checkBoxFra.UseVisualStyleBackColor = true;
            checkBoxFra.CheckedChanged += checkBoxFra_CheckedChanged;
            // 
            // checkBoxChi
            // 
            checkBoxChi.AutoSize = true;
            checkBoxChi.Location = new Point(405, 186);
            checkBoxChi.Name = "checkBoxChi";
            checkBoxChi.Size = new Size(59, 24);
            checkBoxChi.TabIndex = 12;
            checkBoxChi.Text = "Hoa";
            checkBoxChi.UseVisualStyleBackColor = true;
            // 
            // comboBoxEth
            // 
            comboBoxEth.FormattingEnabled = true;
            comboBoxEth.Location = new Point(184, 239);
            comboBoxEth.Name = "comboBoxEth";
            comboBoxEth.Size = new Size(330, 28);
            comboBoxEth.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(164, 589);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(270, 589);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(376, 589);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(94, 22);
            deleteToolStripMenuItem.Text = "Xóa";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // formBaitap1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 686);
            Controls.Add(comboBoxEth);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(checkBoxChi);
            Controls.Add(checkBoxFra);
            Controls.Add(checkBoxEng);
            Controls.Add(radioButtonFemale);
            Controls.Add(radioButtonMale);
            Controls.Add(textBoxId);
            Controls.Add(textBoxName);
            Controls.Add(lstv1);
            Controls.Add(labelEthnic);
            Controls.Add(labelForeignLang);
            Controls.Add(labelSex);
            Controls.Add(labelID);
            Controls.Add(labelName);
            Name = "formBaitap1";
            Text = "formBaitap1";
            FormClosing += formBaitap1_FormClosing;
            Load += formBaitap1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelID;
        private Label labelSex;
        private Label labelForeignLang;
        private Label labelEthnic;
        private System.Windows.Forms.ListView lstv1;
        private TextBox textBoxName;
        private TextBox textBoxId;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
        private CheckBox checkBoxEng;
        private CheckBox checkBoxFra;
        private CheckBox checkBoxChi;
        private ComboBox comboBoxEth;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderId;
        private ColumnHeader columnHeaderSex;
        private ColumnHeader columnHeaderLang;
        private ColumnHeader columnHeaderEth;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}