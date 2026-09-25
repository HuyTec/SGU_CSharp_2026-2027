using System.Globalization;

namespace Lab03.R1.Ex3;

public class People
{
    private string name = string.Empty;
    private string faculty = string.Empty;

    public string GetName() => name;
    public void SetName(string value) => name = value;

    public string GetFaculty() => faculty;
    public void SetFaculty(string value) => faculty = value;
}

public class Student : People
{
    private string sid = string.Empty;
    private double averageScore;

    public string GetSID() => sid;
    public void SetSID(string value) => sid = value;

    public double GetAverageScore() => averageScore;
    public void SetAverageScore(double value) => averageScore = value;

    public void Show()
    {
        Console.WriteLine($"MSSV: {GetSID()}");
        Console.WriteLine($"Ho ten: {GetName()}");
        Console.WriteLine($"Khoa: {GetFaculty()}");
        Console.WriteLine($"Diem trung binh: {GetAverageScore():F2}");
    }
}

public class Tester
{
    public static Student Nhap1SV()
    {
        Student student = new Student();

        Console.Write("MSSV: ");
        student.SetSID(Console.ReadLine() ?? string.Empty);
        Console.Write("Ho ten: ");
        student.SetName(Console.ReadLine() ?? string.Empty);
        Console.Write("Khoa: ");
        student.SetFaculty(Console.ReadLine() ?? string.Empty);

        Console.Write("Diem trung binh: ");
        double averageScore;
        while (!double.TryParse(Console.ReadLine(), CultureInfo.CurrentCulture, out averageScore))
        {
            Console.Write("Diem khong hop le. Nhap lai: ");
        }
        student.SetAverageScore(averageScore);

        return student;
    }

    public static List<Student> NhapDS()
    {
        Console.Write("Nhap so luong sinh vien: ");
        int studentCount;
        while (!int.TryParse(Console.ReadLine(), out studentCount) || studentCount <= 0)
        {
            Console.Write("Vui long nhap mot so nguyen duong: ");
        }

        List<Student> students = new List<Student>();
        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine($"\nNhap thong tin sinh vien thu {i + 1}:");
            students.Add(Nhap1SV());
        }
        return students;
    }

    public static void XuatDS(List<Student> students)
    {
        Console.WriteLine("\nDANH SACH SINH VIEN");
        foreach (Student student in students)
        {
            student.Show();
            Console.WriteLine("--------------------");
        }
    }

    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<Student> students = NhapDS();
        XuatDS(students);
    }
}