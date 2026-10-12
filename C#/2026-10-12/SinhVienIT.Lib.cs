class SinhVienIT : SinhVien
{
    public SinhVienIT() : base()
    {
        Lop = "CNTT1-K16";
        Monhoc = "Lập trình C#.NET 1";
    }

    public SinhVienIT(string masv, string tensv, string lop, string monhoc,
        double diemhs1, double diemhs2, double average, double diemthi, double diemtk)
        : base(masv, tensv, lop, monhoc, diemhs1, diemhs2, average, diemthi, diemtk) { }

    public override void Input()
    {
        Console.Write("Nhập mã sinh viên: ");
        Masv = Console.ReadLine();

        Console.Write("Nhập tên sinh viên: ");
        Tensv = Console.ReadLine();

        Console.Write("Nhập lớp: ");
        Lop = Console.ReadLine();

        Console.Write("Nhập môn học: ");
        Monhoc = Console.ReadLine();

        Console.Write("Nhập điểm hệ số 1: ");
        Diemhs1 = double.Parse(Console.ReadLine());

        Console.Write("Nhập điểm hệ số 2: ");
        Diemhs2 = double.Parse(Console.ReadLine());

        Console.Write("Nhập điểm hệ số 2 (lần 2): ");
        Diemhs2_2 = double.Parse(Console.ReadLine());

        Console.Write("Nhập điểm thi: ");
        Diemthi = double.Parse(Console.ReadLine());

        Average = (Diemhs1 + Diemhs2 + Diemhs2_2) / 3;
        Diemtk = Average * 0.3 + Diemthi * 0.7;
    }

    public override void Output()
    {
        Console.WriteLine($"{Masv,-12}{Tensv,-25}{Lop,-15}{Monhoc,-25}{Diemhs1,-10}{Diemhs2,-10}{Diemhs2_2,-10}{Average,-10}{Diemthi,-10}{Diemtk,-10}{XepLoaiSV()}");
    }
}