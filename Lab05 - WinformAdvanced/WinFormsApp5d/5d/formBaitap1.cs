using System;
using System.Windows.Forms;

namespace WinFormsApp1._5d
{
    public partial class formBaitap1 : Form
    {
        public formBaitap1()
        {
            InitializeComponent();
        }

        private void formBaitap1_Load(object sender, EventArgs e)
        {
            comboBoxEth.Items.AddRange(new object[] { "Kinh", "Tày", "Thái", "Hoa", "Khmer", "Chăm" });
            comboBoxEth.SelectedIndex = 0;
            radioButtonMale.Checked = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            if (FindStudent(textBoxId.Text.Trim()) != null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxId.Focus();
                return;
            }

            ListViewItem item = new ListViewItem(textBoxName.Text.Trim());
            item.SubItems.Add(textBoxId.Text.Trim());
            item.SubItems.Add(radioButtonMale.Checked ? "Nam" : "Nữ");
            item.SubItems.Add(GetLanguages());
            item.SubItems.Add(comboBoxEth.Text);
            lstv1.Items.Add(item);
            ClearInputs();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstv1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput())
            {
                return;
            }

            ListViewItem item = lstv1.SelectedItems[0];
            item.SubItems[0].Text = textBoxName.Text.Trim();
            item.SubItems[2].Text = radioButtonMale.Checked ? "Nam" : "Nữ";
            item.SubItems[3].Text = GetLanguages();
            item.SubItems[4].Text = comboBoxEth.Text;
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedItem();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedItem();
        }

        private void lstv1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem? item = lstv1.GetItemAt(e.X, e.Y);
                lstv1.SelectedItems.Clear();
                if (item != null)
                {
                    item.Selected = true;
                }
            }
        }

        private void lstv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstv1.SelectedItems.Count == 0)
            {
                textBoxId.ReadOnly = false;
                return;
            }

            ListViewItem item = lstv1.SelectedItems[0];
            textBoxName.Text = item.SubItems[0].Text;
            textBoxId.Text = item.SubItems[1].Text;
            textBoxId.ReadOnly = true;
            radioButtonMale.Checked = item.SubItems[2].Text == "Nam";
            radioButtonFemale.Checked = !radioButtonMale.Checked;
            checkBoxEng.Checked = item.SubItems[3].Text.Contains("Anh");
            checkBoxFra.Checked = item.SubItems[3].Text.Contains("Pháp");
            checkBoxChi.Checked = item.SubItems[3].Text.Contains("Hoa");
            comboBoxEth.SelectedItem = item.SubItems[4].Text;
        }

        private ListViewItem? FindStudent(string id)
        {
            foreach (ListViewItem item in lstv1.Items)
            {
                if (string.Equals(item.SubItems[1].Text, id, StringComparison.OrdinalIgnoreCase))
                {
                    return item;
                }
            }

            return null;
        }

        private string GetLanguages()
        {
            List<string> languages = new List<string>();
            if (checkBoxEng.Checked) languages.Add("Anh");
            if (checkBoxFra.Checked) languages.Add("Pháp");
            if (checkBoxChi.Checked) languages.Add("Hoa");
            return string.Join(", ", languages);
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ tên và mã sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!radioButtonMale.Checked && !radioButtonFemale.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void DeleteSelectedItem()
        {
            if (lstv1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên đã chọn không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lstv1.Items.Remove(lstv1.SelectedItems[0]);
                ClearInputs();
            }
        }

        private void ClearInputs()
        {
            textBoxName.Clear();
            textBoxId.Clear();
            textBoxId.ReadOnly = false;
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            checkBoxEng.Checked = false;
            checkBoxFra.Checked = false;
            checkBoxChi.Checked = false;
            if (comboBoxEth.Items.Count > 0) comboBoxEth.SelectedIndex = 0;
            lstv1.SelectedItems.Clear();
        }

        private void formBaitap1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đóng form không?", "Xác nhận đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxFra_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
