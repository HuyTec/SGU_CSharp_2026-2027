namespace WinFormsApp1._5d
{
    partial class formBaitap2
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
            labelTitle = new Label();
            labelAccount = new Label();
            labelCustomer = new Label();
            labelAddress = new Label();
            labelAmount = new Label();
            textBoxAccount = new TextBox();
            textBoxCustomer = new TextBox();
            textBoxAddress = new TextBox();
            textBoxAmount = new TextBox();
            buttonAdd = new Button();
            buttonSave = new Button();
            buttonDelete = new Button();
            buttonExit = new Button();
            listViewAccounts = new System.Windows.Forms.ListView();
            columnSTT = new ColumnHeader();
            columnAccount = new ColumnHeader();
            columnCustomer = new ColumnHeader();
            columnAddress = new ColumnHeader();
            columnAmount = new ColumnHeader();
            labelTotal = new Label();
            textBoxTotal = new TextBox();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.Blue;
            labelTitle.Location = new Point(83, 25);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(445, 37);
            labelTitle.TabIndex = 15;
            labelTitle.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            // 
            // labelAccount
            // 
            labelAccount.AutoSize = true;
            labelAccount.Location = new Point(104, 77);
            labelAccount.Name = "labelAccount";
            labelAccount.Size = new Size(91, 20);
            labelAccount.TabIndex = 14;
            labelAccount.Text = "Số tài khoản";
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Location = new Point(83, 107);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(111, 20);
            labelCustomer.TabIndex = 13;
            labelCustomer.Text = "Tên khách hàng";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(77, 137);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(134, 20);
            labelAddress.TabIndex = 12;
            labelAddress.Text = "Địa chỉ khách hàng";
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Location = new Point(48, 167);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(160, 20);
            labelAmount.TabIndex = 11;
            labelAmount.Text = "Số tiền trong tài khoản";
            // 
            // textBoxAccount
            // 
            textBoxAccount.Location = new Point(217, 74);
            textBoxAccount.Name = "textBoxAccount";
            textBoxAccount.Size = new Size(260, 27);
            textBoxAccount.TabIndex = 10;
            textBoxAccount.TextChanged += textBoxAccount_TextChanged;
            // 
            // textBoxCustomer
            // 
            textBoxCustomer.Location = new Point(217, 104);
            textBoxCustomer.Name = "textBoxCustomer";
            textBoxCustomer.Size = new Size(260, 27);
            textBoxCustomer.TabIndex = 9;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(217, 134);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(260, 27);
            textBoxAddress.TabIndex = 8;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(217, 164);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(260, 27);
            textBoxAmount.TabIndex = 7;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(187, 195);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(59, 29);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Thêm";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSave
            // 
            buttonSave.Enabled = false;
            buttonSave.Location = new Point(251, 195);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(59, 29);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Lưu";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Enabled = false;
            buttonDelete.Location = new Point(315, 195);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(59, 29);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Xóa";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(379, 195);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(59, 29);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // listViewAccounts
            // 
            listViewAccounts.Columns.AddRange(new ColumnHeader[] { columnSTT, columnAccount, columnCustomer, columnAddress, columnAmount });
            listViewAccounts.FullRowSelect = true;
            listViewAccounts.GridLines = true;
            listViewAccounts.Location = new Point(54, 230);
            listViewAccounts.Name = "listViewAccounts";
            listViewAccounts.Size = new Size(503, 138);
            listViewAccounts.TabIndex = 2;
            listViewAccounts.UseCompatibleStateImageBehavior = false;
            listViewAccounts.View = View.Details;
            listViewAccounts.SelectedIndexChanged += listViewAccounts_SelectedIndexChanged;
            // 
            // columnSTT
            // 
            columnSTT.Text = "STT";
            columnSTT.Width = 48;
            // 
            // columnAccount
            // 
            columnAccount.Text = "Số tài khoản";
            columnAccount.Width = 95;
            // 
            // columnCustomer
            // 
            columnCustomer.Text = "Tên khách hàng";
            columnCustomer.Width = 105;
            // 
            // columnAddress
            // 
            columnAddress.Text = "Địa chỉ";
            columnAddress.Width = 95;
            // 
            // columnAmount
            // 
            columnAmount.Text = "Số tiền";
            columnAmount.Width = 90;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(285, 377);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(72, 20);
            labelTotal.TabIndex = 1;
            labelTotal.Text = "Tổng tiền";
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(363, 374);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(194, 27);
            textBoxTotal.TabIndex = 0;
            // 
            // formBaitap2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 465);
            Controls.Add(textBoxTotal);
            Controls.Add(labelTotal);
            Controls.Add(listViewAccounts);
            Controls.Add(buttonExit);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSave);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxAmount);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxCustomer);
            Controls.Add(textBoxAccount);
            Controls.Add(labelAmount);
            Controls.Add(labelAddress);
            Controls.Add(labelCustomer);
            Controls.Add(labelAccount);
            Controls.Add(labelTitle);
            Name = "formBaitap2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBaiTap2";
            FormClosing += formBaitap2_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelAccount;
        private Label labelCustomer;
        private Label labelAddress;
        private Label labelAmount;
        private TextBox textBoxAccount;
        private TextBox textBoxCustomer;
        private TextBox textBoxAddress;
        private TextBox textBoxAmount;
        private Button buttonAdd;
        private Button buttonSave;
        private Button buttonDelete;
        private Button buttonExit;
        private System.Windows.Forms.ListView listViewAccounts;
        private ColumnHeader columnSTT;
        private ColumnHeader columnAccount;
        private ColumnHeader columnCustomer;
        private ColumnHeader columnAddress;
        private ColumnHeader columnAmount;
        private Label labelTotal;
        private TextBox textBoxTotal;
    }
}