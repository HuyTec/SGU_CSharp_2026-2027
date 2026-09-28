namespace Lab03.R2.Ex1;

public interface IBook
{
    string Title { get; set; }
    string Author { get; set; }
    string Publisher { get; set; }
    int Year { get; set; }
    string Isbn { get; set; }
    List<string> Chapters { get; set; }
    void Input();
    void Output();
}

public class Book : IBook, IComparable<Book>
{
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public string Publisher { get; set; } = "";
    public int Year { get; set; }
    public string Isbn { get; set; } = "";
    public List<string> Chapters { get; set; } = new();

    public void Input()
    {
        Console.Write("Tên sách: "); Title = Console.ReadLine()!;
        Console.Write("Tác giả: "); Author = Console.ReadLine()!;
        Console.Write("Nhà xuất bản: "); Publisher = Console.ReadLine()!;
        Console.Write("Năm xuất bản: "); Year = int.Parse(Console.ReadLine()!);
        Console.Write("ISBN: "); Isbn = Console.ReadLine()!;
        Console.Write("Số chương: "); int n = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < n; i++) { Console.Write($"Chương {i + 1}: "); Chapters.Add(Console.ReadLine()!); }
    }

    public void Output() => Console.WriteLine($"{Title} | {Author} | {Publisher} | {Year} | {Isbn} | {string.Join(", ", Chapters)}");
    public int CompareTo(Book? other) => other is null ? 1 : Author.CompareTo(other.Author);
}

public class TitleComparer : IComparer<Book>
{
    public int Compare(Book? x, Book? y) => string.Compare(x?.Title, y?.Title, StringComparison.Ordinal);
}

public class YearComparer : IComparer<Book>
{
    public int Compare(Book? x, Book? y) => (x?.Year ?? 0).CompareTo(y?.Year ?? 0);
}

public class BookList
{
    public List<Book> Books = new();
    public void Input()
    {
        Console.Write("Số sách: "); int n = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < n; i++) { Book book = new(); book.Input(); Books.Add(book); }
    }
    public void Output() { foreach (Book book in Books) book.Output(); }
    public void SortByAuthor() => Books.Sort();
    public void SortByTitle() => Books.Sort(new TitleComparer());
    public void SortByYear() => Books.Sort(new YearComparer());
}

public static class Exercise
{
    public static void Run()
    {
        BookList list = new(); list.Input();
        list.SortByAuthor(); Console.WriteLine("\nTheo tác giả:"); list.Output();
        list.SortByTitle(); Console.WriteLine("\nTheo tên sách:"); list.Output();
        list.SortByYear(); Console.WriteLine("\nTheo năm:"); list.Output();
    }
}
