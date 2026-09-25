using System.Globalization;

namespace Lab03.R1.Ex1;

public class Student
{
    //Properties
    public string SID { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Faculty { get; set; } = string.Empty;
    public double AverageScore { get; set; }

    public Student(string sid, string name, string faculty, double averageScore)
    {
        SID = sid;
        Name = name;
        Faculty = faculty;
        AverageScore = averageScore;
    }

    public void DisplayInformation()
    {
        Console.WriteLine($"MSSV: {SID}");
        Console.WriteLine($"Ho ten: {Name}");
        Console.WriteLine($"Khoa: {Faculty}");
        Console.WriteLine($"Diem trung binh: {AverageScore:F2}");
    }
}

public class Tester
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhap so luong sinh vien: ");
        int studentCount;
        while (!int.TryParse(Console.ReadLine(), out studentCount) || studentCount <= 0)
        {
            Console.Write("Vui long nhap mot so nguyen duong: ");
        }

        List<Student> students = new();

        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine($"\nNhap thong tin sinh vien thu {i + 1}:");
            Console.Write("MSSV: ");
            string sid = Console.ReadLine() ?? string.Empty;
            Console.Write("Ho ten: ");
            string name = Console.ReadLine() ?? string.Empty;
            Console.Write("Khoa: ");
            string faculty = Console.ReadLine() ?? string.Empty;

            Console.Write("Diem trung binh: ");
            double averageScore;
            while (!double.TryParse(Console.ReadLine(), CultureInfo.CurrentCulture, out averageScore))
            {
                Console.Write("Diem khong hop le. Nhap lai: ");
            }

            students.Add(new Student(sid, name, faculty, averageScore));
        }

        Console.WriteLine("\nDANH SACH SINH VIEN");
        foreach (Student student in students)
        {
            student.DisplayInformation();
            Console.WriteLine("--------------------");
        }
    }
}
 
