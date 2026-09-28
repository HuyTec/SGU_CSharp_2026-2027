using System.Collections;
using System.Text.Json;

namespace Lab03.R2.Ex4;

public class Account
{
    public string Id { get; set; } = "";
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public decimal Balance { get; set; }
    public void Input()
    {
        Console.Write("Mã: "); Id = Console.ReadLine()!;
        Console.Write("First name: "); FirstName = Console.ReadLine()!;
        Console.Write("Last name: "); LastName = Console.ReadLine()!;
        Console.Write("Số dư: "); Balance = decimal.Parse(Console.ReadLine()!);
    }
    public void Output() => Console.WriteLine($"{Id} | {FirstName} {LastName} | {Balance:N0} VNĐ");
}

public class IdComparer : IComparer { public int Compare(object? x, object? y) => string.Compare(((Account)x!).Id, ((Account)y!).Id, StringComparison.Ordinal); }
public class NameComparer : IComparer { public int Compare(object? x, object? y) => string.Compare(((Account)x!).FirstName, ((Account)y!).FirstName, StringComparison.Ordinal); }
public class BalanceComparer : IComparer { public int Compare(object? x, object? y) => ((Account)x!).Balance.CompareTo(((Account)y!).Balance); }

public class AccountList
{
    private readonly ArrayList accounts = new();
    public void Add() { Account account = new(); account.Input(); accounts.Add(account); }
    public void Sort(int choice) => accounts.Sort(choice == 1 ? new IdComparer() : choice == 2 ? new NameComparer() : new BalanceComparer());
    public void Remove(string id)
    {
        IdComparer comparer = new(); accounts.Sort(comparer);
        int index = accounts.BinarySearch(new Account { Id = id }, comparer);
        if (index >= 0) accounts.RemoveAt(index); else Console.WriteLine("Không tìm thấy mã tài khoản.");
    }
    public void Report() { foreach (Account account in accounts) account.Output(); }
    public void SaveJson()
    {
        List<Account> data = new(); foreach (Account account in accounts) data.Add(account);
        File.WriteAllText("accounts.json", JsonSerializer.Serialize(data));
    }
    public void LoadJson()
    {
        if (!File.Exists("accounts.json")) return;
        List<Account>? data = JsonSerializer.Deserialize<List<Account>>(File.ReadAllText("accounts.json"));
        accounts.Clear();
        if (data is not null) foreach (Account account in data) accounts.Add(account);
    }
}

public static class Exercise
{
    public static void Run()
    {
        AccountList list = new(); Console.Write("Số tài khoản: "); int n = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < n; i++) list.Add();
        Console.Write("Sắp xếp: 1-Mã, 2-First name, 3-Số dư: "); list.Sort(int.Parse(Console.ReadLine()!)); list.Report();
        Console.Write("Mã cần xóa: "); list.Remove(Console.ReadLine()!); list.Report();
        list.SaveJson(); Console.WriteLine("Đã lưu accounts.json");
    }
}
