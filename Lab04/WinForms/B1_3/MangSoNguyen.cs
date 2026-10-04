namespace WinForms.B3;

public sealed class MangSoNguyen
{
    private readonly List<int> _giaTri;

    public MangSoNguyen(IEnumerable<int> giaTri)
    {
        ArgumentNullException.ThrowIfNull(giaTri);
        _giaTri = giaTri.ToList();
    }

    public int SoLuong => _giaTri.Count;

    public IReadOnlyList<int> GiaTri => _giaTri.AsReadOnly();

    public void SapXepTang()
    {
        _giaTri.Sort();
    }

    public void SapXepGiam()
    {
        _giaTri.Sort((a, b) => b.CompareTo(a));
    }

    public IReadOnlyList<int> TimViTri(int giaTri)
    {
        var viTri = new List<int>();

        for (var i = 0; i < _giaTri.Count; i++)
        {
            if (_giaTri[i] == giaTri)
                viTri.Add(i);
        }

        return viTri;
    }

    public void Them(int viTri, int giaTri)
    {
        if (viTri < 0 || viTri > _giaTri.Count)
            throw new ArgumentOutOfRangeException(nameof(viTri), "Vị trí thêm phải từ 0 đến số lượng phần tử.");

        _giaTri.Insert(viTri, giaTri);
    }

    public int Tong() => _giaTri.Sum();

    public int TongChan() => _giaTri.Where(giaTri => giaTri % 2 == 0).Sum();

    public int TongLe() => _giaTri.Where(giaTri => giaTri % 2 != 0).Sum();

    public int LonNhat()
    {
        KiemTraKhongRong();
        return _giaTri.Max();
    }

    public int NhoNhat()
    {
        KiemTraKhongRong();
        return _giaTri.Min();
    }

    public void ThayThe(int viTri, int giaTriMoi)
    {
        KiemTraViTri(viTri);
        _giaTri[viTri] = giaTriMoi;
    }

    private void KiemTraKhongRong()
    {
        if (_giaTri.Count == 0)
            throw new InvalidOperationException("Mảng không được rỗng.");
    }

    private void KiemTraViTri(int viTri)
    {
        if (viTri < 0 || viTri >= _giaTri.Count)
            throw new ArgumentOutOfRangeException(nameof(viTri), "Vị trí phải nằm trong mảng.");
    }
}
