namespace Lab03.R1.Ex4;

// Lớp chung cho tất cả nhân viên.
public class NhanVien
{
    public string HoTen;
    public int NamSinh;
    public string BangCap;

    public NhanVien(string hoTen, int namSinh, string bangCap)
    {
        HoTen = hoTen;
        NamSinh = namSinh;
        BangCap = bangCap;
    }

    public virtual decimal TinhLuong() => 0;

    public virtual void Xuat()
    {
        Console.WriteLine($"Họ tên: {HoTen}");
        Console.WriteLine($"Năm sinh: {NamSinh}");
        Console.WriteLine($"Bằng cấp: {BangCap}");
    }
}

public class NhaKhoaHoc : NhanVien
{
    public string ChucVu;
    public int SoBaiBao;
    public int SoNgayCong;
    public decimal BacLuong;

    public NhaKhoaHoc(string hoTen, int namSinh, string bangCap, string chucVu,
        int soBaiBao, int soNgayCong, decimal bacLuong)
        : base(hoTen, namSinh, bangCap)
    {
        ChucVu = chucVu;
        SoBaiBao = soBaiBao;
        SoNgayCong = soNgayCong;
        BacLuong = bacLuong;
    }

    public override decimal TinhLuong() => SoNgayCong * BacLuong;

    public override void Xuat()
    {
        Console.WriteLine("NHÀ KHOA HỌC");
        base.Xuat();
        Console.WriteLine($"Chức vụ: {ChucVu}");
        Console.WriteLine($"Số bài báo: {SoBaiBao}");
        Console.WriteLine($"Lương: {TinhLuong():N0} VNĐ");
    }
}

public class NhaQuanLy : NhanVien
{
    public string ChucVu;
    public int SoNgayCong;
    public decimal BacLuong;

    public NhaQuanLy(string hoTen, int namSinh, string bangCap, string chucVu,
        int soNgayCong, decimal bacLuong)
        : base(hoTen, namSinh, bangCap)
    {
        ChucVu = chucVu;
        SoNgayCong = soNgayCong;
        BacLuong = bacLuong;
    }

    public override decimal TinhLuong() => SoNgayCong * BacLuong;

    public override void Xuat()
    {
        Console.WriteLine("NHÀ QUẢN LÝ");
        base.Xuat();
        Console.WriteLine($"Chức vụ: {ChucVu}");
        Console.WriteLine($"Lương: {TinhLuong():N0} VNĐ");
    }
}

public class NhanVienPhongThiNghiem : NhanVien
{
    public decimal LuongKhoan;

    public NhanVienPhongThiNghiem(string hoTen, int namSinh, string bangCap, decimal luongKhoan)
        : base(hoTen, namSinh, bangCap)
    {
        LuongKhoan = luongKhoan;
    }

    public override decimal TinhLuong() => LuongKhoan;

    public override void Xuat()
    {
        Console.WriteLine("NHÂN VIÊN PHÒNG THÍ NGHIỆM");
        base.Xuat();
        Console.WriteLine($"Lương khoán: {TinhLuong():N0} VNĐ");
    }
}

public class Tester
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<NhanVien> danhSach = new();
        decimal tongKhoaHoc = 0, tongQuanLy = 0, tongPhongThiNghiem = 0;

        Console.Write("Nhập số lượng nhân viên: ");
        int n = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\n1. Nhà khoa học | 2. Nhà quản lý | 3. Nhân viên phòng thí nghiệm");
            Console.Write("Chọn loại: ");
            int loai = int.Parse(Console.ReadLine()!);

            Console.Write("Họ tên: ");
            string hoTen = Console.ReadLine()!;
            Console.Write("Năm sinh: ");
            int namSinh = int.Parse(Console.ReadLine()!);
            Console.Write("Bằng cấp: ");
            string bangCap = Console.ReadLine()!;

            if (loai == 1)
            {
                Console.Write("Chức vụ: ");
                string chucVu = Console.ReadLine()!;
                Console.Write("Số bài báo: ");
                int soBaiBao = int.Parse(Console.ReadLine()!);
                Console.Write("Số ngày công: ");
                int soNgayCong = int.Parse(Console.ReadLine()!);
                Console.Write("Bậc lương: ");
                decimal bacLuong = decimal.Parse(Console.ReadLine()!);

                NhaKhoaHoc nv = new(hoTen, namSinh, bangCap, chucVu, soBaiBao, soNgayCong, bacLuong);
                danhSach.Add(nv);
                tongKhoaHoc += nv.TinhLuong();
            }
            else if (loai == 2)
            {
                Console.Write("Chức vụ: ");
                string chucVu = Console.ReadLine()!;
                Console.Write("Số ngày công: ");
                int soNgayCong = int.Parse(Console.ReadLine()!);
                Console.Write("Bậc lương: ");
                decimal bacLuong = decimal.Parse(Console.ReadLine()!);

                NhaQuanLy nv = new(hoTen, namSinh, bangCap, chucVu, soNgayCong, bacLuong);
                danhSach.Add(nv);
                tongQuanLy += nv.TinhLuong();
            }
            else
            {
                Console.Write("Lương khoán: ");
                decimal luongKhoan = decimal.Parse(Console.ReadLine()!);

                NhanVienPhongThiNghiem nv = new(hoTen, namSinh, bangCap, luongKhoan);
                danhSach.Add(nv);
                tongPhongThiNghiem += nv.TinhLuong();
            }
        }

        Console.WriteLine("\nDANH SÁCH NHÂN VIÊN");
        foreach (NhanVien nv in danhSach)
        

        Console.WriteLine("\nTỔNG LƯƠNG");
        Console.WriteLine($"Nhà khoa học: {tongKhoaHoc:N0} VNĐ");
        Console.WriteLine($"Nhà quản lý: {tongQuanLy:N0} VNĐ");
        Console.WriteLine($"Nhân viên phòng thí nghiệm: {tongPhongThiNghiem:N0} VNĐ");
    }
}
