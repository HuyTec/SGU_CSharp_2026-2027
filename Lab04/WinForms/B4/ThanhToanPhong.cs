namespace WinForms.B4;

public enum LoaiPhong
{
    PhongDon,
    PhongDoi,
    PhongBa
}

public sealed class ThanhToanPhong
{
    public const decimal GiaPhongDon = 300_000m;
    public const decimal GiaPhongDoi = 350_000m;
    public const decimal GiaPhongBa = 400_000m;
    public const decimal GiaTienNghi = 10_000m;
    public const decimal GiaKaraoke = 50_000m;
    public const decimal GiaAnSangMoiNgay = 15_000m;

    public string TenKhachHang { get; }
    public string DiaChi { get; }
    public int SoNgayO { get; }
    public LoaiPhong LoaiPhong { get; }
    public int SoTienNghi { get; }
    public bool SuDungKaraoke { get; }
    public bool SuDungAnSang { get; }

    public ThanhToanPhong(
        string tenKhachHang,
        string diaChi,
        int soNgayO,
        LoaiPhong loaiPhong,
        int soTienNghi,
        bool suDungKaraoke,
        bool suDungAnSang)
    {
        TenKhachHang = tenKhachHang;
        DiaChi = diaChi;
        SoNgayO = soNgayO;
        LoaiPhong = loaiPhong;
        SoTienNghi = soTienNghi;
        SuDungKaraoke = suDungKaraoke;
        SuDungAnSang = suDungAnSang;
    }

    public decimal TinhTien()
    {
        decimal giaPhongMoiNgay = LoaiPhong switch
        {
            LoaiPhong.PhongDon => GiaPhongDon,
            LoaiPhong.PhongDoi => GiaPhongDoi,
            LoaiPhong.PhongBa => GiaPhongBa,
            _ => 0m
        };

        decimal tienPhong = giaPhongMoiNgay * SoNgayO;
        decimal tienTienNghi = SoTienNghi * GiaTienNghi;
        decimal tienDichVu = (SuDungKaraoke ? GiaKaraoke : 0m)
            + (SuDungAnSang ? GiaAnSangMoiNgay * SoNgayO : 0m);

        return tienPhong + tienTienNghi + tienDichVu;
    }
}
