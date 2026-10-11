using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1._5d
{
    public partial class QLSinhVien : Form
    {
        private readonly string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True;TrustServerCertificate=True";

        public QLSinhVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();
            string maSv = txtMaSV.Text.Trim();
            string hoTen = tbHoTen.Text.Trim();

            if (maLop == "" || maSv == "" || hoTen == "" || !dateTimePicker1.Checked)
            {
                MessageBox.Show("Mã lớp, Mã sinh viên, Tên sinh viên và Ngày sinh không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                const string sql = "INSERT INTO QLSinhVien.SinhVien(MaLop, MaSV, HoTen, NgaySinh) VALUES(@MaLop, @MaSV, @HoTen, @NgaySinh)";
                using SqlCommand cmd = new SqlCommand(sql, conn);
                AddCommonParameters(cmd, maLop, maSv, hoTen);
                cmd.Parameters.Add("@NgaySinh", System.Data.SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInput();
            }
            catch (SqlException ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSv = txtMaSV.Text.Trim();
            string hoTen = tbHoTen.Text.Trim();

            if (maSv == "" || hoTen == "")
            {
                MessageBox.Show("Mã sinh viên và Tên sinh viên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtMaLop.Text.Trim() != "" || dateTimePicker1.Checked)
            {
                MessageBox.Show("Khi xóa, Mã lớp và Ngày sinh phải để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                const string sql = "DELETE FROM QLSinhVien.SinhVien WHERE MaSV = @MaSV AND HoTen = @HoTen";
                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", maSv);
                cmd.Parameters.AddWithValue("@HoTen", hoTen);
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show(rows > 0 ? "Xóa sinh viên thành công!" : "Không tìm thấy sinh viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInput();
            }
            catch (SqlException ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSv = txtMaSV.Text.Trim();
            string maLop = txtMaLop.Text.Trim();
            string hoTen = tbHoTen.Text.Trim();

            if (maSv == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (maLop == "" && hoTen == "" && !dateTimePicker1.Checked)
            {
                MessageBox.Show("Phải nhập ít nhất Mã lớp, Tên sinh viên hoặc Ngày sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                const string sql = "UPDATE QLSinhVien.SinhVien SET " +
                                   "MaLop = CASE WHEN @MaLop = '' THEN MaLop ELSE @MaLop END, " +
                                   "HoTen = CASE WHEN @HoTen = '' THEN HoTen ELSE @HoTen END, " +
                                   "NgaySinh = CASE WHEN @HasNgaySinh = 1 THEN @NgaySinh ELSE NgaySinh END " +
                                   "WHERE MaSV = @MaSV";
                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaLop", maLop);
                cmd.Parameters.AddWithValue("@HoTen", hoTen);
                cmd.Parameters.AddWithValue("@HasNgaySinh", dateTimePicker1.Checked ? 1 : 0);
                cmd.Parameters.Add("@NgaySinh", System.Data.SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                cmd.Parameters.AddWithValue("@MaSV", maSv);
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show(rows > 0 ? "Sửa sinh viên thành công!" : "Không tìm thấy sinh viên cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInput();
            }
            catch (SqlException ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private static void AddCommonParameters(SqlCommand cmd, string maLop, string maSv, string hoTen)
        {
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            cmd.Parameters.AddWithValue("@MaSV", maSv);
            cmd.Parameters.AddWithValue("@HoTen", hoTen);
        }

        private void ClearInput()
        {
            txtMaLop.Clear();
            txtMaSV.Clear();
            tbHoTen.Clear();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.Checked = false;
            txtMaLop.Focus();
        }

        private static void ShowDatabaseError(SqlException ex)
        {
            if (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblMaSV_Click(object sender, EventArgs e)
        {

        }

        private void txtMaLop_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
