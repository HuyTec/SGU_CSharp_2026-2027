using System;
using System.Windows.Forms;

namespace WinFormsApp1._5d
{
    public partial class formBaitap2 : Form
    {
        private bool isAdding;

        public formBaitap2()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            isAdding = !isAdding;
            buttonAdd.Text = isAdding ? "Hủy" : "Thêm";
            buttonSave.Enabled = isAdding;

            if (isAdding)
            {
                ClearInputs();
                textBoxAccount.Focus();
            }
            else
            {
                LoadSelectedItem();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAccount.Text) ||
                string.IsNullOrWhiteSpace(textBoxCustomer.Text) ||
                string.IsNullOrWhiteSpace(textBoxAmount.Text))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản, tên khách hàng và số tiền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textBoxAmount.Text.Trim(), out decimal amount) || amount < 0)
            {
                MessageBox.Show("Số tiền không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxAmount.Focus();
                return;
            }

            ListViewItem item = new ListViewItem();
            item.SubItems.Add(textBoxAccount.Text.Trim());
            item.SubItems.Add(textBoxCustomer.Text.Trim());
            item.SubItems.Add(textBoxAddress.Text.Trim());
            item.SubItems.Add(amount.ToString("N0"));
            listViewAccounts.Items.Add(item);
            RefreshSummary();
            buttonAdd_Click(buttonAdd, EventArgs.Empty);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewAccounts.SelectedItems.Count == 0)
            {
                return;
            }

            listViewAccounts.Items.Remove(listViewAccounts.SelectedItems[0]);
            ClearInputs();
            RefreshSummary();
        }

        private void listViewAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDelete.Enabled = listViewAccounts.SelectedItems.Count > 0;
            if (!isAdding)
            {
                LoadSelectedItem();
            }
        }

        private void LoadSelectedItem()
        {
            if (listViewAccounts.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem item = listViewAccounts.SelectedItems[0];
            textBoxAccount.Text = item.SubItems[1].Text;
            textBoxCustomer.Text = item.SubItems[2].Text;
            textBoxAddress.Text = item.SubItems[3].Text;
            textBoxAmount.Text = item.SubItems[4].Text;
        }

        private void ClearInputs()
        {
            textBoxAccount.Clear();
            textBoxCustomer.Clear();
            textBoxAddress.Clear();
            textBoxAmount.Clear();
            listViewAccounts.SelectedItems.Clear();
        }

        private void RefreshSummary()
        {
            decimal total = 0;
            for (int index = 0; index < listViewAccounts.Items.Count; index++)
            {
                ListViewItem item = listViewAccounts.Items[index];
                item.Text = (index + 1).ToString();
                if (decimal.TryParse(item.SubItems[4].Text, out decimal amount))
                {
                    total += amount;
                }
            }

            textBoxTotal.Text = total.ToString("N0");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formBaitap2_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void textBoxAccount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
