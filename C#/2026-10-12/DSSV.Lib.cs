class DSSV
{
    private List<SinhVien> ds = new List<SinhVien>();

    private SinhVien? FindByMaSV(string masv)
    {
        foreach (SinhVien sv in ds)
        {
            if (sv.Masv == masv) return sv;
        }
        return null;
    }

    public void Add()
    {
        Console.Write("Nhập số lượng sinh viên cần thêm: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập thông tin sinh viên thứ {i + 1}:");
            SinhVien sv = new SinhVienIT();
            sv.Input();
            ds.Add(sv);
        }

        Console.WriteLine($"Đã thêm {n} sinh viên.");
    }

    public void Modify()
    {
        Console.Write("Nhập mã sinh viên cần sửa: ");
        string masv = Console.ReadLine();

        SinhVien? sv = FindByMaSV(masv);
        if (sv == null)
        {
            Console.WriteLine("Không tìm thấy sinh viên với mã đã nhập.");
            return;
        }

        Console.WriteLine("Nhập thông tin mới cho sinh viên:");
        sv.Input();
        Console.WriteLine("Đã cập nhật thông tin sinh viên.");
    }

    public void Delete()
    {
        Console.Write("Nhập mã sinh viên cần xóa: ");
        string masv = Console.ReadLine();

        SinhVien? sv = FindByMaSV(masv);
        if (sv == null)
        {
            Console.WriteLine("Không tìm thấy sinh viên với mã đã nhập.");
            return;
        }

        ds.Remove(sv);
        Console.WriteLine("Đã xóa sinh viên.");
    }

    public void Search()
    {
        Console.Write("Nhập mã sinh viên cần tìm: ");
        string masv = Console.ReadLine();

        SinhVien? sv = FindByMaSV(masv);
        if (sv == null)
        {
            Console.WriteLine("Không tìm thấy sinh viên với mã đã nhập.");
            return;
        }

        InTieuDe();
        sv.Output();
    }

    public void SortByDiemTK()
    {
        ds.Sort(new SinhVienComparer());
        Console.WriteLine("Đã sắp xếp danh sách theo điểm tổng kết tăng dần.");
    }

    public void Output()
    {
        if (ds.Count == 0)
        {
            Console.WriteLine("Danh sách sinh viên rỗng.");
            return;
        }

        Console.WriteLine("Danh sách sinh viên:");
        InTieuDe();
        foreach (SinhVien sv in ds)
        {
            sv.Output();
        }
    }

    private void InTieuDe()
    {
        Console.WriteLine($"{"Mã SV",-12}{"Tên SV",-25}{"Lớp",-15}{"Môn học",-25}{"HS1",-10}{"HS2",-10}{"HS2.2",-10}{"ĐTB",-10}{"Thi",-10}{"ĐTK",-10}{"Xếp loại",-12}");
    }
}
