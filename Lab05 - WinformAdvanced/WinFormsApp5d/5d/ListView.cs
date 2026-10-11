using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1._5d
{
    public partial class ListView : Form
    {
        public ListView()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy mã sinh viên từ TextBox
            string mssv = tbMaSV.Text;

            // Lấy họ tên từ TextBox
            string hoten = tbHoTen.Text;

            // Tạo dòng mới trong ListView
            ListViewItem item = new ListViewItem(mssv);

            // Thêm họ tên vào cột thứ hai
            item.SubItems.Add(hoten);

            // Thêm dòng vào ListView
            lstv1.Items.Add(item);

            // Xóa nội dung TextBox sau khi thêm
            tbMaSV.Clear();
            tbHoTen.Clear();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstv1.SelectedItems.Count > 0)
            {
                ListViewItem item = lstv1.SelectedItems[0];

                item.Text = tbMaSV.Text;
                item.SubItems[1].Text = tbHoTen.Text;

                MessageBox.Show("Sửa sinh viên thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!");
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã chọn sinh viên chưa
            if (lstv1.SelectedItems.Count > 0)
            {
                // Xác nhận trước khi xóa
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn xóa sinh viên này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    // Xóa dòng đang chọn
                    lstv1.Items.Remove(lstv1.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
            }
        }

        private void lstv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstv1.SelectedItems.Count > 0)
            {
                ListViewItem item = lstv1.SelectedItems[0];

                tbMaSV.Text = item.Text;
                tbHoTen.Text = item.SubItems[1].Text;
            }
        }

    }
}
