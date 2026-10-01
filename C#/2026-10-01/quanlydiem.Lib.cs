class SVMG
{
    public string MaSV { get; set; }
    public string TenSV { get; set; }
    public string DiemHS1 { get; set; }
    public string DiemHS2 { get; set; }
    public string DiemHS2_2 { get; set; }
    public double Diemthi { get; set; }
    public double DiemTB { get; set; }
    public double DiemTK { get; set; }
    public string XepLoai { get; set; }

    public SVMG(string maSV, string tenSV, string diemHS1, string diemHS2, string diemHS2_2, double diemthi, double diemTB, double diemTK, string xepLoai)
    {
        MaSV = maSV;
        TenSV = tenSV;
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
        MaSV = Console.ReadLine();
        Console.Write("Nhập tên sinh viên: ");
        TenSV = Console.ReadLine();
        Console.Write("Nhập điểm hệ số 1: ");
        DiemHS1 = double.Parse(Console.ReadLine());
        Console.Write("Nhập điểm hệ số 2: ");
        DiemHS2 = double.Parse(Console.ReadLine());
        Console.Write("Nhập điểm hệ số 2 lần 2: ");
        DiemHS2_2 = double.Parse(Console.ReadLine());
        Console.Write("Nhập điểm thi: ");
        Diemthi = double.Parse(Console.ReadLine());
    }
    public void 
}