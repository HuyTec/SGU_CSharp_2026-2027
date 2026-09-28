# Thực hành LINQ với LINQPad

Mục tiêu: làm quen với LINQ bằng các truy vấn ngắn trên LINQPad trước khi viết lại trong VSCode.

## Cách làm trên LINQPad

1. Mở [LINQPad](https://www.linqpad.net) và tạo **New Query**.
2. Chọn ngôn ngữ **C# Program**.
3. Dán dữ liệu mẫu và lời giải của từng bài vào cửa sổ code.
4. Nhấn `F5` để chạy, dùng `Dump()` để xem kết quả.
5. Chụp màn hình kết quả và ghi chú câu lệnh LINQ đã dùng.

---

## Dữ liệu mẫu dùng chung

```csharp
void Main()
{
    var students = new[]
    {
        new Student("SV01", "An", "CNTT", 8.5),
        new Student("SV02", "Bình", "Kế toán", 6.8),
        new Student("SV03", "Châu", "CNTT", 9.2),
        new Student("SV04", "Dũng", "Marketing", 7.4),
        new Student("SV05", "Hà", "CNTT", 5.9),
        new Student("SV06", "Lan", "Kế toán", 8.0)
    };

    // Viết truy vấn của từng bài ở đây.
}

public record Student(string Id, string Name, string Faculty, double AverageScore);
```

---

## Bài 1: Lọc dữ liệu với `Where`

In ra sinh viên có điểm trung bình từ 8.0 trở lên.

- Phương thức cần dùng: `Where()`
- Kết quả mong đợi: An, Châu, Lan.

---

## Bài 2: Chọn dữ liệu với `Select`

Tạo danh sách chỉ gồm mã số sinh viên và họ tên.

- Phương thức cần dùng: `Select()`
- Gợi ý: tạo anonymous object: `new { student.Id, student.Name }`.

---

## Bài 3: Sắp xếp với `OrderBy` và `ThenBy`

Sắp xếp danh sách sinh viên theo điểm trung bình giảm dần. Nếu điểm bằng nhau thì sắp xếp tên tăng dần.

- Phương thức cần dùng: `OrderByDescending()`, `ThenBy()`

---

## Bài 4: Đếm và kiểm tra dữ liệu

1. Đếm số sinh viên thuộc khoa CNTT.
2. Kiểm tra có sinh viên nào có điểm dưới 5.0 không.
3. Tìm sinh viên có điểm trung bình cao nhất.

- Phương thức cần dùng: `Count()`, `Any()`, `Max()` hoặc `MaxBy()`.

---

## Bài 5: Gom nhóm với `GroupBy`

Gom sinh viên theo khoa. Với mỗi khoa, in tên khoa, số sinh viên và điểm trung bình của khoa đó.

- Phương thức cần dùng: `GroupBy()`, `Count()`, `Average()`

Ví dụ kết quả cần có:

```text
CNTT: 3 sinh viên, điểm trung bình: 7.87
Kế toán: 2 sinh viên, điểm trung bình: 7.40
Marketing: 1 sinh viên, điểm trung bình: 7.40
```

---

## Bài 6: Nối hai danh sách với `Join`

Thêm dữ liệu khoa sau vào `Main()`:

```csharp
var faculties = new[]
{
    new Faculty("CNTT", "Công nghệ thông tin"),
    new Faculty("Kế toán", "Kế toán"),
    new Faculty("Marketing", "Marketing")
};
```

Tạo danh sách hiển thị: mã sinh viên, họ tên, tên khoa đầy đủ và điểm trung bình.

- Phương thức cần dùng: `Join()`

Thêm khai báo này bên dưới lớp `Student`:

```csharp
public record Faculty(string Code, string FullName);
```

---

## Bài 7: Tổng hợp dữ liệu

Tính các thông tin sau cho toàn bộ danh sách:

1. Điểm trung bình cao nhất.
2. Điểm trung bình thấp nhất.
3. Điểm trung bình của tất cả sinh viên.
4. Tổng số sinh viên.

- Phương thức cần dùng: `Max()`, `Min()`, `Average()`, `Count()`.

---

## Bài 8: Cú pháp query syntax

Làm lại Bài 1 bằng cú pháp truy vấn LINQ:

```csharp
var result =
    from student in students
    where student.AverageScore >= 8.0
    select student;
```

So sánh với method syntax:

```csharp
var result = students.Where(student => student.AverageScore >= 8.0);
```

Ghi chú: hai cách cho kết quả tương đương; trong C# thực tế, method syntax thường linh hoạt hơn khi cần gọi nhiều hàm như `GroupBy`, `OrderBy`, `Select`.

---

## Checklist nộp phần LINQPad

- [ ] Chạy ít nhất Bài 1 đến Bài 7 trên LINQPad.
- [ ] Mỗi bài có ảnh chụp code và kết quả.
- [ ] Ghi 1-2 câu giải thích phương thức LINQ chính đã sử dụng.
- [ ] Viết lại tối thiểu Bài 1, 3, 5 và 6 vào project VSCode.
