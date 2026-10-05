class DanhSachNhanVien
{
    private List<NhanVien> DS = new List<NhanVien>();
    public void Add()
    {
        Console.Write("Nhập số lượng nhân viên: ");
        int n = int.TryParse(Console.ReadLine(), out int result) ? result : 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập thông tin nhân viên thứ {i + 1}:");
            NhanVien nv = new NhanVien();
            nv.Input();
            DS.Add(nv);
        }
    }
    public void AddSingle()
    {
        NhanVien nv = new NhanVien();
        nv.Input();
        DS.Add(nv);
    }
    public void Modify()
    {
        Console.Write("Nhập mã nhân viên cần sửa: ");
        string maNV = Console.ReadLine() ?? string.Empty;

        foreach (NhanVien nv in DS)
        {
            if (nv.MaNV == maNV)
            {
                Console.WriteLine("Nhập thông tin mới cho nhân viên:");
                nv.Input();
                return;
            }
        }

        Console.WriteLine("Không tìm thấy nhân viên với mã nhân viên đó.");
    }
    public void RemoveNV()
    {
        Console.Write("Nhập mã nhân viên cần xóa: ");
        string maNV = Console.ReadLine();
        for (int i = 0; i < DS.Count; i++)
        {
            if (DS[i].MaNV == maNV)
            {
                DS.RemoveAt(i);
                Console.WriteLine("Xóa nhân viên thành công.");
                return;
            }
        }
        Console.WriteLine("Không tìm thấy nhân viên với mã nhân viên đó.");
    }
    public void Search()
    {
        Console.Write("Nhập mã nhân viên cần tìm: ");
        string maNV = Console.ReadLine();
        foreach (NhanVien nv in DS)
        {
            if (nv.MaNV == maNV)
            {
                Console.WriteLine($"Mã nhân viên: {nv.MaNV}");
                Console.WriteLine($"Họ tên: {nv.HoTen}");
                Console.WriteLine($"Giới tính: {nv.GioiTinh}");
                Console.WriteLine($"Chức vụ: {nv.ChucVu}");
                Console.WriteLine($"Lương cơ bản: {nv.LuongCoBan}");
                Console.WriteLine($"Số ngày công: {nv.SoNgayCong}");
                Console.WriteLine($"Phụ cấp: {nv.PhuCap}");
                Console.WriteLine($"Lương tổng: {nv.LuongTong}");
                return;
            }
        }
        Console.WriteLine("Không tìm thấy nhân viên với mã nhân viên đó.");
    }
    public void Sort()
    {
        for (int i = 0; i < DS.Count - 1; i++)
        {
            for (int j = i + 1; j < DS.Count; j++)
            {
                if (DS[i].LuongTong < DS[j].LuongTong)
                {
                    NhanVien temp = DS[i];
                    DS[i] = DS[j];
                    DS[j] = temp;
                }
            }
        }
    }
    public void Output()
    {
        Console.WriteLine("Danh sách nhân viên:");
        foreach (NhanVien nv in DS)
        {
            Console.WriteLine($"Mã nhân viên: {nv.MaNV}");
            Console.WriteLine($"Họ tên: {nv.HoTen}");
            Console.WriteLine($"Giới tính: {nv.GioiTinh}");
            Console.WriteLine($"Chức vụ: {nv.ChucVu}");
            Console.WriteLine($"Lương cơ bản: {nv.LuongCoBan}");
            Console.WriteLine($"Số ngày công: {nv.SoNgayCong}");
            Console.WriteLine($"Phụ cấp: {nv.PhuCap}");
            Console.WriteLine($"Lương tổng: {nv.LuongTong}");
        }
    }
}