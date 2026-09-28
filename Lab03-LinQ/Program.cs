namespace Lab03;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("1-R2 B1 | 2-R2 B2 | 3-R2 B3 | 4-R2 B4");
        Console.WriteLine("5-R3 B1 | 6-R3 B2 | 7-R3 B3 | 8-R3 B4");
        Console.Write("Chọn bài chạy: ");
        switch (int.Parse(Console.ReadLine()!))
        {
            case 1: R2.Ex1.Exercise.Run(); break;
            case 2: R2.Ex2.Exercise.Run(); break;
            case 3: R2.Ex3.Exercise.Run(); break;
            case 4: R2.Ex4.Exercise.Run(); break;
            case 5: R3.Ex1.Exercise.Run(); break;
            case 6: R3.Ex2.Exercise.Run(); break;
            case 7: R3.Ex3.Exercise.Run(); break;
            case 8: R3.Ex4.Exercise.Run(); break;
        }
    }
}
