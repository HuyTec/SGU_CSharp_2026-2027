using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace WinForms.B21
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DangKyTaiKhoan();
        }

        private void tConfimPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                DangKyTaiKhoan();
            }
        }

        private void tEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!EmailHopLe(tEmail.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập địa chỉ email hợp lệ.",
                    "Email không hợp lệ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void DangKyTaiKhoan()
        {
            if (string.IsNullOrWhiteSpace(tName.Text) ||
                string.IsNullOrWhiteSpace(tEmail.Text) ||
                string.IsNullOrWhiteSpace(tPassword.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ các trường có dấu (*).",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!EmailHopLe(tEmail.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập địa chỉ email hợp lệ.",
                    "Email không hợp lệ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                tEmail.Focus();
                return;
            }

            MessageBox.Show(
                $"Tên đăng nhập: {tName.Text}\n" +
                $"Địa chỉ email: {tEmail.Text}\n" +
                $"Mật khẩu: {tPassword.Text}\n" +
                $"Xác nhận mật khẩu: {tConfimPassword.Text}",
                "Thông tin đăng ký",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private static bool EmailHopLe(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                MailAddress mailAddress = new(email.Trim());
                return mailAddress.Address == email.Trim();
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn đóng form không?",
                "Xác nhận đóng",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.No)
                e.Cancel = true;
        }
    }
}
