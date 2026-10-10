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
    public partial class frmLop : Form
    {
        private readonly string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True;TrustServerCertificate=True";

        public frmLop()
        {
            InitializeComponent();
        }

        private void ClearInput()
        {
            txtMaKhoa.Clear();
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtMaKhoa.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();
            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();

            if (maKhoa == "" || maLop == "" || tenLop == "")
            {
                MessageBox.Show("Mã khoa, Mã lớp, Tên lớp không được để trống!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "INSERT INTO Lop(MaKhoa, MaLop, TenLop) VALUES(@MaKhoa, @MaLop, @TenLop)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaKhoa", maKhoa);
                        cmd.Parameters.AddWithValue("@MaLop", maLop);
                        cmd.Parameters.AddWithValue("@TenLop", tenLop);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Thêm lớp thành công!");
                ClearInput();
            }
            catch (SqlException ex)
            {
                // 2627: trùng khóa chính
                if (ex.Number == 2627)
                    MessageBox.Show("Mã lớp đã tồn tại!");
                else
                    MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();
            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();

            if (maLop == "")
            {
                MessageBox.Show("Mã lớp không được để trống!");
                return;
            }
            if (maKhoa != "" || tenLop != "")
            {
                MessageBox.Show("Khi xóa chỉ nhập Mã lớp, Mã khoa và Tên lớp phải để trống!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "DELETE FROM Lop WHERE MaLop = @MaLop";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaLop", maLop);
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                            MessageBox.Show("Xóa thành công!");
                        else
                            MessageBox.Show("Không tìm thấy lớp có mã " + maLop);
                    }
                }
                ClearInput();
            }
            catch (SqlException ex)
            {
                // 547: vướng khóa ngoại (còn sinh viên thuộc lớp này)
                if (ex.Number == 547)
                    MessageBox.Show("Không thể xóa vì lớp đang được tham chiếu ở bảng khác!");
                else
                    MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();
            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();

            if (maLop == "")
            {
                MessageBox.Show("Mã lớp không được để trống!");
                return;
            }
            if (maKhoa == "" && tenLop == "")
            {
                MessageBox.Show("Phải nhập ít nhất Mã khoa hoặc Tên lớp!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    // Chỉ cập nhật cột nào có dữ liệu
                    string sql = "UPDATE Lop SET " +
                                 "MaKhoa = CASE WHEN @MaKhoa = '' THEN MaKhoa ELSE @MaKhoa END, " +
                                 "TenLop = CASE WHEN @TenLop = '' THEN TenLop ELSE @TenLop END " +
                                 "WHERE MaLop = @MaLop";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaKhoa", maKhoa);
                        cmd.Parameters.AddWithValue("@TenLop", tenLop);
                        cmd.Parameters.AddWithValue("@MaLop", maLop);
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                            MessageBox.Show("Sửa thành công!");
                        else
                            MessageBox.Show("Không tìm thấy lớp có mã " + maLop);
                    }
                }
                ClearInput();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSua_Click_2(object sender, EventArgs e)
        {

        }
    }
}
