using System.Globalization;

namespace Lab03.R3.Ex1;

public class PhieuThuePhong
{
    public string HoTen = "", LoaiPhong = "";
    public DateTime NgayBatDau, NgayKetThuc;
    public void Input()
    {
        Console.Write("Họ tên: "); HoTen = Console.ReadLine()!;
        Console.Write("Ngày bắt đầu (dd/MM/yyyy): "); NgayBatDau = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        Console.Write("Ngày kết thúc (dd/MM/yyyy): "); NgayKetThuc = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        Console.Write("Phòng A/B/C: "); LoaiPhong = Console.ReadLine()!;
    }
    public decimal TinhTien()
    {
        int days = Math.Max(1, (NgayKetThuc - NgayBatDau).Days);
        decimal price = LoaiPhong.ToUpper() == "A" ? 220_000 : LoaiPhong.ToUpper() == "B" ? 200_000 : 170_000;
        decimal total = days * price; return days > 6 ? total * 0.9m : total;
    }
    public void Output() => Console.WriteLine($"{HoTen} phải trả: {TinhTien():N0} VNĐ");
}

public static class Exercise { public static void Run() { PhieuThuePhong p = new(); p.Input(); p.Output(); } }
