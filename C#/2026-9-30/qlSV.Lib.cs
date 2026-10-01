class SinhVien
{
    private string maSV;
    private string tenSV;
    private string tenMH;
    private double diemMH;
    private string ranking;

    public string MaSV {get => maSV; set => maSV = value;}
    public string TenSV {get => tenSV; set => tenSV = value;}
    public string TenMH {get => tenMH;}
    public double DiemMH {get => diemMH; set => diemMH = value;}
    public string Ranking {get => ranking; set => ranking = value;}
    public SinhVien(string maSV, string tenSV, double diemMH)
    {
        this.MaSV = maSV;
        this.TenSV = tenSV;
        this.DiemMH = diemMH;
    }
    public SinhVien() { }
    public void Input()
    {
        Console.Write("Nhập mã sinh viên: ");
        maSV = Console.ReadLine();
        Console.Write("Nhập tên sinh viên: ");
        tenSV = Console.ReadLine();
        do
        {
            Console.Write("Nhập điểm sinh viên: ");
            DiemMH = double.Parse(Console.ReadLine());
            if (DiemMH < 0 || DiemMH > 10) Console.WriteLine("Điểm vừa nhập không chính xác, vui lòng nhập lại.");
        } while (DiemMH < 0 || DiemMH > 10);
    }
    public void Output()
    {
        Console.WriteLine($"{MaSV,-10}{TenSV,-30}{TenMH,-30}{DiemMH,-5} {Xeploai(),-20}");
    }
    public string Xeploai()
    {
        if (DiemMH >= 9) ranking = "Xuất sắc";
        else if (DiemMH >= 8) ranking = "Giỏi";
        else if (DiemMH >= 7) ranking = "Khá";
        else if (DiemMH >= 5) ranking = "Trung bình";
        else ranking = "Yếu";
        return ranking;
    }
}