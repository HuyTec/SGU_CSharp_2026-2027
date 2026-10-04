using System.Globalization;

namespace WinForms.B4;

public partial class Form4 : Form
{
    private int tongSoKhach;
    private decimal tongTien;

    public Form4()
    {
        InitializeComponent();
        Load += Form4_Load;
        FormClosing += Form4_FormClosing;
    }

    private void Form4_Load(object? sender, EventArgs e)
    {
        ResetForm();
        txtTenKhachHang.Focus();
    }

    private void InputChanged(object? sender, EventArgs e)
    {
        btnThanhToan.Enabled = DuLieuHopLe() && lblThanhTien.Text.Length == 0;
    }

    private bool DuLieuHopLe()
    {
        return !string.IsNullOrWhiteSpace(txtTenKhachHang.Text)
            && !string.IsNullOrWhiteSpace(txtDiaChi.Text)
            && nudSoNgayO.Value > 0
            && (rdoPhongDon.Checked || rdoPhongDoi.Checked || rdoPhongBa.Checked);
    }

    private void ThanhToan_Click(object? sender, EventArgs e)
    {
        if (!DuLieuHopLe())
        {
            MessageBox.Show("Vui lòng nhập đầy đủ tên, địa chỉ, số ngày ở và loại phòng.", "Dữ liệu chưa đầy đủ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        ThanhToanPhong hoaDon = TaoHoaDon();
        decimal thanhTien = hoaDon.TinhTien();
        lblThanhTien.Text = DinhDangTien(thanhTien);
        tongSoKhach++;
        tongTien += thanhTien;

        MessageBox.Show($"Khách hàng: {hoaDon.TenKhachHang}\nThành tiền: {DinhDangTien(thanhTien)}", "Thanh toán thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        btnThanhToan.Enabled = false;
        btnNhapMoi.Enabled = true;
        btnTongKet.Enabled = true;
    }

    private void NhapMoi_Click(object? sender, EventArgs e)
    {
        ResetForm();
        txtTenKhachHang.Focus();
    }

    private void TongKet_Click(object? sender, EventArgs e)
    {
        lblTongSoKhach.Text = tongSoKhach.ToString(CultureInfo.InvariantCulture);
        lblTongTien.Text = DinhDangTien(tongTien);
        tongSoKhach = 0;
        tongTien = 0m;
        btnTongKet.Enabled = false;
    }

    private void Thoat_Click(object? sender, EventArgs e)
    {
        Close();
    }

    private void ResetForm()
    {
        txtTenKhachHang.Clear();
        txtDiaChi.Clear();
        nudSoNgayO.Value = 1;
        rdoPhongDon.Checked = false;
        rdoPhongDoi.Checked = false;
        rdoPhongBa.Checked = false;
        chkWifi.Checked = false;
        chkTivi.Checked = false;
        chkTuLanh.Checked = false;
        chkKaraoke.Checked = false;
        chkAnSang.Checked = false;
        lblThanhTien.Text = string.Empty;
        btnThanhToan.Enabled = false;
        btnNhapMoi.Enabled = false;
        btnTongKet.Enabled = tongSoKhach > 0;
    }

    private ThanhToanPhong TaoHoaDon()
    {
        var loaiPhong = rdoPhongDon.Checked ? LoaiPhong.PhongDon
            : rdoPhongDoi.Checked ? LoaiPhong.PhongDoi
            : LoaiPhong.PhongBa;

        int soTienNghi = Convert.ToInt32(chkWifi.Checked) + Convert.ToInt32(chkTivi.Checked) + Convert.ToInt32(chkTuLanh.Checked);
        return new ThanhToanPhong(
            txtTenKhachHang.Text.Trim(),
            txtDiaChi.Text.Trim(),
            Decimal.ToInt32(nudSoNgayO.Value),
            loaiPhong,
            soTienNghi,
            chkKaraoke.Checked,
            chkAnSang.Checked);
    }

    private static string DinhDangTien(decimal soTien)
    {
        return $"{soTien:N0} đ";
    }

    private void Form4_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (e.CloseReason != CloseReason.UserClosing)
            return;

        DialogResult result = MessageBox.Show(
            "Bạn có chắc chắn muốn thoát không?",
            "Xác nhận thoát",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (result == DialogResult.No)
            e.Cancel = true;
    }
}
