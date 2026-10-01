class ListStudent
{
    List<SinhVien> lst = new List<SinhVien>()
    {
        new SinhVien("SV01","Nguyễn Văn A", 9.3),
        new SinhVien("SV02","Nguyễn Văn B", 9),
        new SinhVien("SV03","Nguyễn Hà Nam", 7),
        new SinhVien("SV04","Chu Tử Đăng", 5),
        new SinhVien("SV05","Nguyễn Gia Huy", 6),
    };
    public void AddSV()
    {
        SinhVien sv = new SinhVien();
        sv.Input();
        lst.Add(sv);
    }
    public void OutputList()
    {
        Console.WriteLine($"{"Mã SV",-10}{"Tên SV",-30}{"Tên MH",-30}{"Điểm",-5} {"Xếp loại",-20}");
        foreach (SinhVien sv in lst)
        {
            sv.Output();
        }
    }
}



