namespace Lab03.R2.Ex2;

// Bài 2 sử dụng BookList và các IComparer đã viết trong Bài 1.
public static class Exercise
{
    public static void Run()
    {
        Lab03.R2.Ex1.BookList list = new(); list.Input();
        Console.Write("Sắp xếp: 1-Tác giả, 2-Tên sách, 3-Năm: ");
        int choice = int.Parse(Console.ReadLine()!);
        if (choice == 1) list.SortByAuthor();
        else if (choice == 2) list.SortByTitle();
        else list.SortByYear();
        list.Output();
    }
}
