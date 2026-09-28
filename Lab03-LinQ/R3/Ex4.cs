namespace Lab03.R3.Ex4;

public abstract class DichVu
{
    public string TenKhach = "";
    public abstract decimal TinhTien();
    public void Output() => Console.WriteLine($"{TenKhach} phải trả: {TinhTien():N0} VNĐ");
}
public class ThueXe : DichVu
{
    public string LoaiXe = "";
    public int SoGio; public decimal DonGiaGio;
    public override decimal TinhTien() { decimal total = SoGio * DonGiaGio; return SoGio > 6 ? total * 0.95m : total; }
}
public class DienThoai : DichVu
{
    public string LoaiCuocGoi = "";
    public int SoPhut; public decimal DonGiaPhut;
    public override decimal TinhTien() { decimal total = SoPhut * DonGiaPhut; return total > 500_000 ? total * 0.9m : total; }
}
public static class Exercise
{
    public static void Run()
    {
        Console.Write("Tên khách: "); string name = Console.ReadLine()!;
        Console.Write("1-Thuê xe, 2-Điện thoại: "); int type = int.Parse(Console.ReadLine()!);
        DichVu service;
        if (type == 1)
        {
            Console.Write("Loại xe: "); string vehicle = Console.ReadLine()!;
            Console.Write("Số giờ: "); int hours = int.Parse(Console.ReadLine()!);
            Console.Write("Đơn giá/giờ: "); decimal price = decimal.Parse(Console.ReadLine()!);
            service = new ThueXe { TenKhach = name, LoaiXe = vehicle, SoGio = hours, DonGiaGio = price };
        }
        else
        {
            Console.Write("Loại cuộc gọi: "); string callType = Console.ReadLine()!;
            Console.Write("Số phút: "); int minutes = int.Parse(Console.ReadLine()!);
            Console.Write("Đơn giá/phút: "); decimal price = decimal.Parse(Console.ReadLine()!);
            service = new DienThoai { TenKhach = name, LoaiCuocGoi = callType, SoPhut = minutes, DonGiaPhut = price };
        }
        service.Output();
    }
}
