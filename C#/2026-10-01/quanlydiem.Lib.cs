class SVMG
{
    public string MaSV { get; set; } = string.Empty;
    public string TenSV { get; set; } = string.Empty;
    public string TenMH { get; set; } = string.Empty;
    public double DiemHS1 { get; set; }
    public double DiemHS2 { get; set; }
    public double DiemHS2_2 { get; set; }
    public double Diemthi { get; set; }
    public double DiemTB { get; set; }
    public double DiemTK { get; set; }
    public string XepLoai { get; set; } = string.Empty;

    public SVMG(string maSV, string tenSV, string tenMH, double diemHS1, double diemHS2, double diemHS2_2, double diemthi, double diemTB, double diemTK, string xepLoai)
    {
        MaSV = maSV;
        TenSV = tenSV;
        TenMH = tenMH;
        DiemHS1 = diemHS1;
        DiemHS2 = diemHS2;
        DiemHS2_2 = diemHS2_2;
        Diemthi = diemthi;
        DiemTB = diemTB;
        DiemTK = diemTK;
        XepLoai = xepLoai;
    }

    public SVMG() { }

    public void Input()
    {
        Console.Write("Nhập mã sinh viên: ");
        MaSV = Console.ReadLine() ?? string.Empty;

        Console.Write("Nhập tên sinh viên: ");
        TenSV = Console.ReadLine() ?? string.Empty;

        Console.Write("Nhập tên môn học: ");
        TenMH = Console.ReadLine() ?? string.Empty;

        do
        {
            Console.Write("Nhập điểm hệ số 1: ");
            DiemHS1 = double.Parse(Console.ReadLine() ?? "0");
        } while (DiemHS1 < 0 || DiemHS1 > 10);

        do
        {
            Console.Write("Nhập điểm hệ số 2: ");
            DiemHS2 = double.Parse(Console.ReadLine() ?? "0");
        } while (DiemHS2 < 0 || DiemHS2 > 10);

        do
        {
            Console.Write("Nhập điểm hệ số 2 lần 2: ");
            DiemHS2_2 = double.Parse(Console.ReadLine());
        } while (DiemHS2_2 < 0 || DiemHS2_2 > 10);

        do
        {
            Console.Write("Nhập điểm thi: ");
            Diemthi = double.Parse(Console.ReadLine() );
        } while (Diemthi < 0 || Diemthi > 10);
    }

    public double Average()
    {
        DiemTB = (DiemHS1 + DiemHS2 * 2 + DiemHS2_2 * 2) / 5;
        return DiemTB;
    }

    public double Final()
    {
        DiemTK = Average() * 0.4 + Diemthi * 0.6;
        return DiemTK;
    }

    public void OutputInfo()
    {
        Console.WriteLine($"{MaSV,-20}{TenSV,-30}{TenMH,-30}{DiemHS1,-15:F1}{DiemHS2,-15:F1}{DiemHS2_2,-15:F1}{Average(),-15:F2}{Diemthi,-15:F1}{Final(),-15:F2}{XepLoaiSV(),-15}");
    }

    public string XepLoaiSV()
    {
        if (DiemTK < 5) XepLoai = "Yếu";
        else if (DiemTK >= 5 && DiemTK < 6.5) XepLoai = "Trung bình";
        else if (DiemTK >= 6.5 && DiemTK < 7.5) XepLoai = "Khá";
        else if (DiemTK >= 7.5 && DiemTK < 9) XepLoai = "Giỏi";
        else XepLoai = "Xuất sắc";

        return XepLoai;
    }
}