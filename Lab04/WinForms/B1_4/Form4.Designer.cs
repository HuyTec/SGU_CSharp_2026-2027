namespace WinForms.B4;

partial class Form4
{
    private readonly TextBox txtTenKhachHang = new();
    private readonly TextBox txtDiaChi = new();
    private readonly NumericUpDown nudSoNgayO = new();
    private readonly RadioButton rdoPhongDon = new();
    private readonly RadioButton rdoPhongDoi = new();
    private readonly RadioButton rdoPhongBa = new();
    private readonly CheckBox chkWifi = new();
    private readonly CheckBox chkTivi = new();
    private readonly CheckBox chkTuLanh = new();
    private readonly CheckBox chkKaraoke = new();
    private readonly CheckBox chkAnSang = new();
    private readonly Label lblThanhTien = new();
    private readonly Label lblTongSoKhach = new();
    private readonly Label lblTongTien = new();
    private readonly Button btnThanhToan = new();
    private readonly Button btnNhapMoi = new();
    private readonly Button btnTongKet = new();
    private readonly Button btnThoat = new();

    private void InitializeComponent()
    {
        SuspendLayout();

        Text = "Quản lý thanh toán tiền phòng - Khách sạn Thanh Thanh";
        StartPosition = FormStartPosition.CenterScreen;
        ClientSize = new Size(900, 650);
        MinimumSize = new Size(760, 560);
        AutoScaleMode = AutoScaleMode.Font;

        var title = new Label
        {
            AutoSize = false,
            Dock = DockStyle.Top,
            Height = 55,
            Text = "QUẢN LÝ THANH TOÁN TIỀN PHÒNG",
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font(Font, FontStyle.Bold)
        };
        Controls.Add(title);

        var inputGroup = new GroupBox
        {
            Text = "Thông tin khách hàng",
            Location = new Point(25, 75),
            Size = new Size(410, 220)
        };
        Controls.Add(inputGroup);

        AddLabel(inputGroup, "Tên khách hàng:", 20, 32);
        txtTenKhachHang.Location = new Point(145, 28);
        txtTenKhachHang.Size = new Size(235, 27);
        txtTenKhachHang.TextChanged += InputChanged;
        inputGroup.Controls.Add(txtTenKhachHang);

        AddLabel(inputGroup, "Địa chỉ:", 20, 75);
        txtDiaChi.Location = new Point(145, 71);
        txtDiaChi.Size = new Size(235, 27);
        txtDiaChi.TextChanged += InputChanged;
        inputGroup.Controls.Add(txtDiaChi);

        AddLabel(inputGroup, "Số ngày ở:", 20, 118);
        nudSoNgayO.Location = new Point(145, 114);
        nudSoNgayO.Size = new Size(120, 27);
        nudSoNgayO.Minimum = 1;
        nudSoNgayO.Maximum = 365;
        nudSoNgayO.ValueChanged += InputChanged;
        inputGroup.Controls.Add(nudSoNgayO);

        var roomGroup = new GroupBox
        {
            Text = "Loại phòng",
            Location = new Point(460, 75),
            Size = new Size(410, 220)
        };
        Controls.Add(roomGroup);

        ConfigureRadio(rdoPhongDon, "Phòng đơn - 300.000đ/ngày", 20, 35);
        ConfigureRadio(rdoPhongDoi, "Phòng đôi - 350.000đ/ngày", 20, 80);
        ConfigureRadio(rdoPhongBa, "Phòng ba - 400.000đ/ngày", 20, 125);
        roomGroup.Controls.AddRange([rdoPhongDon, rdoPhongDoi, rdoPhongBa]);
        rdoPhongDon.CheckedChanged += InputChanged;
        rdoPhongDoi.CheckedChanged += InputChanged;
        rdoPhongBa.CheckedChanged += InputChanged;

        var amenityGroup = new GroupBox
        {
            Text = "Tiện nghi (10.000đ mỗi loại)",
            Location = new Point(25, 315),
            Size = new Size(410, 150)
        };
        Controls.Add(amenityGroup);
        ConfigureCheckBox(chkWifi, "Wifi", 20, 35);
        ConfigureCheckBox(chkTivi, "Tivi", 20, 70);
        ConfigureCheckBox(chkTuLanh, "Tủ lạnh", 200, 35);
        amenityGroup.Controls.AddRange([chkWifi, chkTivi, chkTuLanh]);

        var serviceGroup = new GroupBox
        {
            Text = "Dịch vụ",
            Location = new Point(460, 315),
            Size = new Size(410, 150)
        };
        Controls.Add(serviceGroup);
        ConfigureCheckBox(chkKaraoke, "Karaoke - 50.000đ", 20, 35);
        ConfigureCheckBox(chkAnSang, "Ăn sáng - 15.000đ/ngày", 20, 75);
        serviceGroup.Controls.AddRange([chkKaraoke, chkAnSang]);

        AddLabel(this, "Thành tiền:", 35, 485);
        lblThanhTien.Location = new Point(150, 480);
        lblThanhTien.Size = new Size(285, 30);
        lblThanhTien.BorderStyle = BorderStyle.Fixed3D;
        lblThanhTien.TextAlign = ContentAlignment.MiddleRight;
        Controls.Add(lblThanhTien);

        AddLabel(this, "Tổng số khách:", 480, 485);
        lblTongSoKhach.Location = new Point(635, 480);
        lblTongSoKhach.Size = new Size(235, 30);
        lblTongSoKhach.BorderStyle = BorderStyle.Fixed3D;
        lblTongSoKhach.TextAlign = ContentAlignment.MiddleRight;
        Controls.Add(lblTongSoKhach);

        AddLabel(this, "Tổng tiền:", 480, 525);
        lblTongTien.Location = new Point(635, 520);
        lblTongTien.Size = new Size(235, 30);
        lblTongTien.BorderStyle = BorderStyle.Fixed3D;
        lblTongTien.TextAlign = ContentAlignment.MiddleRight;
        Controls.Add(lblTongTien);

        ConfigureButton(btnThanhToan, "Thanh toán", 35, 570, ThanhToan_Click);
        ConfigureButton(btnNhapMoi, "Nhập mới", 205, 570, NhapMoi_Click);
        ConfigureButton(btnTongKet, "Tổng kết", 375, 570, TongKet_Click);
        ConfigureButton(btnThoat, "Thoát", 545, 570, Thoat_Click);
        Controls.AddRange([
        btnThanhToan,
        btnNhapMoi,
        btnTongKet,
        btnThoat
    ]);
        ResumeLayout(false);
        PerformLayout();
    }

    private static void AddLabel(Control parent, string text, int x, int y)
    {
        parent.Controls.Add(new Label
        {
            AutoSize = true,
            Location = new Point(x, y + 4),
            Text = text
        });
    }

    private static void ConfigureRadio(RadioButton radioButton, string text, int x, int y)
    {
        radioButton.AutoSize = true;
        radioButton.Location = new Point(x, y);
        radioButton.Text = text;
    }

    private static void ConfigureCheckBox(CheckBox checkBox, string text, int x, int y)
    {
        checkBox.AutoSize = true;
        checkBox.Location = new Point(x, y);
        checkBox.Text = text;
    }

    private static void ConfigureButton(Button button, string text, int x, int y, EventHandler handler)
    {
        button.Location = new Point(x, y);
        button.Size = new Size(145, 38);
        button.Text = text;
        button.Click += handler;
    }
}
