using System.Collections;

namespace Lab03.R2.Ex3;

public class Account
{
    public string Id = "", FirstName = "", LastName = "";
    public decimal Balance;
    public void Input()
    {
        Console.Write("Mã: "); Id = Console.ReadLine()!;
        Console.Write("First name: "); FirstName = Console.ReadLine()!;
        Console.Write("Last name: "); LastName = Console.ReadLine()!;
        Console.Write("Số dư: "); Balance = decimal.Parse(Console.ReadLine()!);
    }
    public void Output() => Console.WriteLine($"{Id} | {FirstName} {LastName} | {Balance:N0} VNĐ");
    public string ToLine() => $"{Id}|{FirstName}|{LastName}|{Balance}";
    public static Account FromLine(string line)
    {
        string[] p = line.Split('|');
        return new Account { Id = p[0], FirstName = p[1], LastName = p[2], Balance = decimal.Parse(p[3]) };
    }
}

public class AccountList
{
    private readonly ArrayList accounts = new();
    public void NewAccount() { Account account = new(); account.Input(); accounts.Add(account); }
    public void Report() { foreach (Account account in accounts) account.Output(); }
    public void SaveFile()
    {
        List<string> lines = new(); foreach (Account account in accounts) lines.Add(account.ToLine());
        File.WriteAllLines("accounts.txt", lines);
    }
    public void LoadFile()
    {
        if (!File.Exists("accounts.txt")) return;
        accounts.Clear(); foreach (string line in File.ReadAllLines("accounts.txt")) accounts.Add(Account.FromLine(line));
    }
}

public static class Exercise
{
    public static void Run()
    {
        AccountList list = new(); Console.Write("Số tài khoản: "); int n = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < n; i++) list.NewAccount();
        list.Report(); list.SaveFile(); Console.WriteLine("Đã lưu accounts.txt");
    }
}
