using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1._5d
{
    public partial class QLMonHoc : Form
    {
        private readonly string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True;TrustServerCertificate=True";

        public QLMonHoc()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maMh = txtMaMh.Text.Trim();
            string tenMh = txtTenMh.Text.Trim();

            if (!ValidateRequiredFields(maMh, tenMh))
            {
                return;
            }

            try
            {
                using SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                const string sql = "INSERT INTO QLSinhVien.MonHoc(MaMh, TenMh) VALUES(@MaMh, @TenMh)";
                using SqlCommand cmd = new SqlCommand(sql, conn);
                AddParameters(cmd, maMh, tenMh);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInput();
            }
            catch (SqlException ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maMh = txtMaMh.Text.Trim();
            string tenMh = txtTenMh.Text.Trim();

            if (maMh == "")
            {
                MessageBox.Show("Mã môn học không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tenMh != "")
            {
                MessageBox.Show("Khi xóa, Tên môn học phải để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                const string sql = "DELETE FROM QLSinhVien.MonHoc WHERE MaMh = @MaMh";
                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaMh", maMh);
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show(rows > 0 ? "Xóa môn học thành công!" : "Không tìm thấy môn học cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInput();
            }
            catch (SqlException ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maMh = txtMaMh.Text.Trim();
            string tenMh = txtTenMh.Text.Trim();

            if (maMh == "" || tenMh == "")
            {
                MessageBox.Show("Mã môn học và Tên môn học không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                const string sql = "UPDATE QLSinhVien.MonHoc SET TenMh = @TenMh WHERE MaMh = @MaMh";
                using SqlCommand cmd = new SqlCommand(sql, conn);
                AddParameters(cmd, maMh, tenMh);
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show(rows > 0 ? "Sửa môn học thành công!" : "Không tìm thấy môn học cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInput();
            }
            catch (SqlException ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private static bool ValidateRequiredFields(string maMh, string tenMh)
        {
            if (maMh == "" || tenMh == "")
            {
                MessageBox.Show("Mã môn học và Tên môn học không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private static void AddParameters(SqlCommand cmd, string maMh, string tenMh)
        {
            cmd.Parameters.AddWithValue("@MaMh", maMh);
            cmd.Parameters.AddWithValue("@TenMh", tenMh);
        }

        private void ClearInput()
        {
            txtMaMh.Clear();
            txtTenMh.Clear();
            txtMaMh.Focus();
        }

        private static void ShowDatabaseError(SqlException ex)
        {
            if (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show("Mã môn học đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ex.Number == 547)
            {
                MessageBox.Show("Không thể xóa môn học vì đang được sử dụng ở bảng điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
