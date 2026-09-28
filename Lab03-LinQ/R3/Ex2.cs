namespace Lab03.R3.Ex2;

public abstract class NhanVien
{
    public string HoTen = "";
    public abstract decimal TinhLuong();
    public void Output() => Console.WriteLine($"{HoTen}: {TinhLuong():N0} VNĐ");
}
public class VanPhong : NhanVien
{
    public decimal LuongThang; public int NgayVang;
    public override decimal TinhLuong() => NgayVang > 3 ? LuongThang - (NgayVang - 3) * 100_000 : LuongThang;
}
public class SanXuat : NhanVien
{
    public int SoSanPham; public decimal DonGia;
    public override decimal TinhLuong() { decimal total = SoSanPham * DonGia; return SoSanPham > 1200 ? total * 1.05m : total; }
}
public static class Exercise
{
    public static void Run()
    {
        List<NhanVien> list = new(); Console.Write("Số nhân viên: "); int n = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < n; i++)
        {
            Console.Write("1-Văn phòng, 2-Sản xuất: "); int type = int.Parse(Console.ReadLine()!);
            Console.Write("Họ tên: "); string name = Console.ReadLine()!;
            if (type == 1)
            {
                Console.Write("Lương tháng: "); decimal salary = decimal.Parse(Console.ReadLine()!);
                Console.Write("Ngày vắng: "); int absent = int.Parse(Console.ReadLine()!);
                list.Add(new VanPhong { HoTen = name, LuongThang = salary, NgayVang = absent });
            }
            else
            {
                Console.Write("Số sản phẩm: "); int product = int.Parse(Console.ReadLine()!);
                Console.Write("Đơn giá: "); decimal price = decimal.Parse(Console.ReadLine()!);
                list.Add(new SanXuat { HoTen = name, SoSanPham = product, DonGia = price });
            }
        }
        foreach (NhanVien nv in list) nv.Output();
    }
}
