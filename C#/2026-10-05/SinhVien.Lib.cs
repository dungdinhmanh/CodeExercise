class SinhVien : Person
{
    public string MaSV {get;set;}
    public string TenMH {get;set;}= "Lập trình C#.NET 1";
    public double DiemMH {get;set;}
    public SinhVien(string name,string maSV, string tenMH, double diemMH):base(name)
    {
        Name = name;
        MaSV = maSV;
        TenMH = tenMH;
        DiemMH = diemMH;
    }
    public SinhVien (){ }
    public void Output()
    {
        base.Output();
        Console.WriteLine($"{MaSV,-10}{TenMH,-30}{DiemMH,-20:F1}");
    }
}