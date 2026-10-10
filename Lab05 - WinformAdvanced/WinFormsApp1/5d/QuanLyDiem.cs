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
    public partial class QuanLyDiem : Form
    {
        private readonly string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLDiem;Integrated Security=True;TrustServerCertificate=True";

        public QuanLyDiem()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSv = txtMaSV.Text.Trim();
            string maMh = txtMaMH.Text.Trim();
            string diem = txtDiem.Text.Trim();

            if (maSv == "" || maMh == "" || diem == "")
            {
                MessageBox.Show("Mã sinh viên, Mã môn học và Điểm không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidScore(diem))
            {
                return;
            }

            try
            {
                using SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                const string sql = "INSERT INTO Diem(MaSV, MaMh, Diem) VALUES(@MaSV, @MaMh, @Diem)";
                using SqlCommand cmd = new SqlCommand(sql, conn);
                AddParameters(cmd, maSv, maMh, diem);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string maMh = txtMaMH.Text.Trim();

            if (maSv == "" || maMh == "")
            {
                MessageBox.Show("Mã sinh viên và Mã môn học không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtDiem.Text.Trim() != "")
            {
                MessageBox.Show("Khi xóa, không được nhập Điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                const string sql = "DELETE FROM Diem WHERE MaSV = @MaSV AND MaMh = @MaMh";
                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", maSv);
                cmd.Parameters.AddWithValue("@MaMh", maMh);
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show(rows > 0 ? "Xóa điểm thành công!" : "Không tìm thấy điểm cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string maMh = txtMaMH.Text.Trim();
            string diem = txtDiem.Text.Trim();

            if (maSv == "" || maMh == "" || diem == "")
            {
                MessageBox.Show("Mã sinh viên, Mã môn học và Điểm không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidScore(diem))
            {
                return;
            }

            try
            {
                using SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                const string sql = "UPDATE Diem SET Diem = @Diem WHERE MaSV = @MaSV AND MaMh = @MaMh";
                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Diem", diem);
                cmd.Parameters.AddWithValue("@MaSV", maSv);
                cmd.Parameters.AddWithValue("@MaMh", maMh);
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show(rows > 0 ? "Sửa điểm thành công!" : "Không tìm thấy điểm cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInput();
            }
            catch (SqlException ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private static bool IsValidScore(string score)
        {
            if (!decimal.TryParse(score, out decimal value))
            {
                MessageBox.Show("Điểm chỉ được nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (value < 0 || value > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private static void AddParameters(SqlCommand cmd, string maSv, string maMh, string diem)
        {
            cmd.Parameters.AddWithValue("@MaSV", maSv);
            cmd.Parameters.AddWithValue("@MaMh", maMh);
            cmd.Parameters.AddWithValue("@Diem", diem);
        }

        private void ClearInput()
        {
            txtMaSV.Clear();
            txtMaMH.Clear();
            txtDiem.Clear();
            txtMaSV.Focus();
        }

        private static void ShowDatabaseError(SqlException ex)
        {
            if (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show("Mã môn học đã tồn tại trong bảng Diem!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
