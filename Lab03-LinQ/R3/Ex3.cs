namespace Lab03.R3.Ex3;

public class HoaDon
{
    public string HoTen = "", MatHang = ""; public int SoLuong;
    public void Input()
    {
        Console.Write("Họ tên khách: "); HoTen = Console.ReadLine()!;
        Console.Write("Mặt hàng X/Y/Z/T: "); MatHang = Console.ReadLine()!;
        Console.Write("Số lượng: "); SoLuong = int.Parse(Console.ReadLine()!);
    }
    public decimal TinhTien()
    {
        decimal price = MatHang.ToUpper() == "X" ? 1_200_000 : MatHang.ToUpper() == "Y" ? 2_500_000 : MatHang.ToUpper() == "Z" ? 570_000 : 1_870_000;
        decimal total = SoLuong * price; return SoLuong > 5 ? total * 0.92m : total;
    }
    public void Output() => Console.WriteLine($"{HoTen} phải trả: {TinhTien():N0} VNĐ");
}
public static class Exercise { public static void Run() { HoaDon h = new(); h.Input(); h.Output(); } }
