namespace WinForms.B3;

public partial class Form3 : Form
{
    private readonly TextBox txtMang = new();
    private readonly TextBox txtKetQua = new();
    private readonly TextBox txtGiaTriTim = new();
    private readonly TextBox txtViTriThem = new();
    private readonly TextBox txtGiaTriThem = new();
    private readonly TextBox txtViTriThay = new();
    private readonly TextBox txtGiaTriThay = new();

    public Form3()
    {
        InitializeForm();
    }

    private void InitializeForm()
    {
        Text = "Bài 2 - Mảng một chiều số nguyên";
        StartPosition = FormStartPosition.CenterScreen;
        MinimumSize = new Size(900, 600);
        ClientSize = new Size(1000, 680);
        FormClosing += Form3_FormClosing;

        var main = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 5, Padding = new Padding(12) };
        main.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        main.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        main.RowStyles.Add(new RowStyle(SizeType.Percent, 35));
        main.RowStyles.Add(new RowStyle(SizeType.Percent, 65));
        main.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        Controls.Add(main);

        main.Controls.Add(new Label
        {
            Text = "QUẢN LÝ MẢNG MỘT CHIỀU SỐ NGUYÊN",
            Dock = DockStyle.Fill,
            Font = new Font(Font, FontStyle.Bold),
            TextAlign = ContentAlignment.MiddleCenter,
            Padding = new Padding(0, 0, 0, 10)
        }, 0, 0);

        var inputPanel = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, AutoSize = true };
        inputPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        inputPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        inputPanel.Controls.Add(new Label { Text = "Mảng (phân cách bằng dấu phẩy, chấm phẩy hoặc khoảng trắng):", AutoSize = true, Anchor = AnchorStyles.Left }, 0, 0);
        txtMang.Dock = DockStyle.Fill;
        txtMang.PlaceholderText = "Ví dụ: 5, 2, 8, 1, 6";
        inputPanel.Controls.Add(txtMang, 1, 0);
        main.Controls.Add(inputPanel, 0, 1);

        var operations = new FlowLayoutPanel { Dock = DockStyle.Fill, AutoScroll = true, WrapContents = true, Padding = new Padding(0, 8, 0, 8) };
        operations.Controls.Add(CreateButton("Hiển thị mảng", HienThiMang));
        operations.Controls.Add(CreateButton("Sắp xếp tăng", SapXepTang));
        operations.Controls.Add(CreateButton("Sắp xếp giảm", SapXepGiam));
        operations.Controls.Add(CreateButton("Tính tổng", TinhTong));
        operations.Controls.Add(CreateButton("Tổng chẵn", TinhTongChan));
        operations.Controls.Add(CreateButton("Tổng lẻ", TinhTongLe));
        operations.Controls.Add(CreateButton("Tìm lớn nhất", TimLonNhat));
        operations.Controls.Add(CreateButton("Tìm nhỏ nhất", TimNhoNhat));
        main.Controls.Add(operations, 0, 2);

        var detail = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 2, AutoScroll = true, Padding = new Padding(0, 8, 0, 8) };
        detail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
        detail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
        detail.Controls.Add(CreateSearchPanel(), 0, 0);
        detail.Controls.Add(CreateInsertPanel(), 1, 0);
        detail.Controls.Add(CreateReplacePanel(), 0, 1);
        main.Controls.Add(detail, 0, 3);

        txtKetQua.Multiline = true;
        txtKetQua.ReadOnly = true;
        txtKetQua.ScrollBars = ScrollBars.Vertical;
        txtKetQua.Dock = DockStyle.Fill;
        txtKetQua.BackColor = SystemColors.Window;
        main.Controls.Add(txtKetQua, 0, 4);
    }

    private GroupBox CreateSearchPanel()
    {
        var group = new GroupBox { Text = "Tìm kiếm giá trị và vị trí", Dock = DockStyle.Fill, Padding = new Padding(8), AutoSize = true };
        var panel = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 2, AutoSize = true };
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        panel.Controls.Add(new Label { Text = "Giá trị:", AutoSize = true, Anchor = AnchorStyles.Left }, 0, 0);
        panel.Controls.Add(txtGiaTriTim, 1, 0);
        panel.Controls.Add(CreateButton("Tìm", TimKiem), 1, 1);
        group.Controls.Add(panel);
        return group;
    }

    private GroupBox CreateInsertPanel()
    {
        var group = new GroupBox { Text = "Thêm giá trị tại vị trí", Dock = DockStyle.Fill, Padding = new Padding(8), AutoSize = true };
        var panel = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 3, AutoSize = true };
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        panel.Controls.Add(new Label { Text = "Vị trí:", AutoSize = true, Anchor = AnchorStyles.Left }, 0, 0);
        panel.Controls.Add(txtViTriThem, 1, 0);
        panel.Controls.Add(new Label { Text = "Giá trị:", AutoSize = true, Anchor = AnchorStyles.Left }, 0, 1);
        panel.Controls.Add(txtGiaTriThem, 1, 1);
        panel.Controls.Add(CreateButton("Thêm", ThemGiaTri), 1, 2);
        group.Controls.Add(panel);
        return group;
    }

    private GroupBox CreateReplacePanel()
    {
        var group = new GroupBox { Text = "Thay thế giá trị tại vị trí", Dock = DockStyle.Fill, Padding = new Padding(8), AutoSize = true };
        var panel = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 3, AutoSize = true };
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        panel.Controls.Add(new Label { Text = "Vị trí:", AutoSize = true, Anchor = AnchorStyles.Left }, 0, 0);
        panel.Controls.Add(txtViTriThay, 1, 0);
        panel.Controls.Add(new Label { Text = "Giá trị mới:", AutoSize = true, Anchor = AnchorStyles.Left }, 0, 1);
        panel.Controls.Add(txtGiaTriThay, 1, 1);
        panel.Controls.Add(CreateButton("Thay thế", ThayTheGiaTri), 1, 2);
        group.Controls.Add(panel);
        return group;
    }

    private static Button CreateButton(string text, EventHandler handler)
    {
        var button = new Button { Text = text, AutoSize = true, Padding = new Padding(6, 3, 6, 3), Margin = new Padding(4) };
        button.Click += handler;
        return button;
    }

    private MangSoNguyen DocMang()
    {
        var tokens = txtMang.Text.Split(new[] { ',', ';', ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        if (tokens.Length == 0)
            throw new FormatException("Vui lòng nhập ít nhất một phần tử cho mảng.");

        var giaTri = new List<int>(tokens.Length);
        foreach (var token in tokens)
        {
            if (!int.TryParse(token, out var so))
                throw new FormatException($"'{token}' không phải là số nguyên hợp lệ.");
            giaTri.Add(so);
        }

        return new MangSoNguyen(giaTri);
    }

    private void CapNhatMang(MangSoNguyen mang, string? thongBao = null)
    {
        txtMang.Text = string.Join(", ", mang.GiaTri);
        txtKetQua.Text = (thongBao is null ? "Mảng hiện tại: " : thongBao + Environment.NewLine) + txtMang.Text;
    }

    private void HienThiMang(object? sender, EventArgs e) => ThucHien(mang => CapNhatMang(mang));

    private void SapXepTang(object? sender, EventArgs e) => ThucHien(mang => { mang.SapXepTang(); CapNhatMang(mang, "Mảng sau khi sắp xếp tăng:"); });

    private void SapXepGiam(object? sender, EventArgs e) => ThucHien(mang => { mang.SapXepGiam(); CapNhatMang(mang, "Mảng sau khi sắp xếp giảm:"); });

    private void TimKiem(object? sender, EventArgs e) => ThucHien(mang =>
    {
        var giaTri = DocSo(txtGiaTriTim, "giá trị cần tìm");
        var viTri = mang.TimViTri(giaTri);
        txtKetQua.Text = viTri.Count == 0 ? $"Không tìm thấy {giaTri} trong mảng." : $"Tìm thấy {giaTri} tại vị trí: {string.Join(", ", viTri)}.";
    });

    private void ThemGiaTri(object? sender, EventArgs e) => ThucHien(mang =>
    {
        var viTri = DocSo(txtViTriThem, "vị trí thêm");
        var giaTri = DocSo(txtGiaTriThem, "giá trị thêm");
        mang.Them(viTri, giaTri);
        CapNhatMang(mang, "Đã thêm giá trị:");
    });

    private void ThayTheGiaTri(object? sender, EventArgs e) => ThucHien(mang =>
    {
        var viTri = DocSo(txtViTriThay, "vị trí thay thế");
        var giaTri = DocSo(txtGiaTriThay, "giá trị mới");
        mang.ThayThe(viTri, giaTri);
        CapNhatMang(mang, "Đã thay thế giá trị:");
    });

    private void TinhTong(object? sender, EventArgs e) => ThucHien(mang => txtKetQua.Text = $"Tổng mảng = {mang.Tong()}");
    private void TinhTongChan(object? sender, EventArgs e) => ThucHien(mang => txtKetQua.Text = $"Tổng các số chẵn = {mang.TongChan()}");
    private void TinhTongLe(object? sender, EventArgs e) => ThucHien(mang => txtKetQua.Text = $"Tổng các số lẻ = {mang.TongLe()}");
    private void TimLonNhat(object? sender, EventArgs e) => ThucHien(mang => txtKetQua.Text = $"Giá trị lớn nhất = {mang.LonNhat()}");
    private void TimNhoNhat(object? sender, EventArgs e) => ThucHien(mang => txtKetQua.Text = $"Giá trị nhỏ nhất = {mang.NhoNhat()}");

    private static int DocSo(TextBox textBox, string tenDuLieu)
    {
        if (!int.TryParse(textBox.Text, out var giaTri))
            throw new FormatException($"Vui lòng nhập {tenDuLieu} là số nguyên.");
        return giaTri;
    }

    private void ThucHien(Action<MangSoNguyen> thaoTac)
    {
        try
        {
            thaoTac(DocMang());
        }
        catch (Exception ex) when (ex is FormatException or ArgumentOutOfRangeException or InvalidOperationException)
        {
            MessageBox.Show(ex.Message, "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void Form3_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (e.CloseReason != CloseReason.UserClosing)
            return;

        var result = MessageBox.Show("Bạn có chắc muốn đóng form không?", "Xác nhận đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.No)
            e.Cancel = true;
    }
}
