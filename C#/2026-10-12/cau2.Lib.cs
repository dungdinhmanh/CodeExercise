using System.ComponentModel;

abstract class SinhVien
{

    private string masv = string.Empty;
    private string tensv = string.Empty;
    private string lop = string.Empty;
    private string monhoc = "Lập trình C#.NET 1";
    private double diemhs1;
    private double diemhs2;
    private double diemhs2_2;
    private double average;
    private double diemthi;
    private double diemtk;

    public SinhVien() { }

    public SinhVien(string masv, string tensv, string lop, string monhoc, double diemhs1, double diemhs2, double average, double diemthi, double diemtk)
    {
        this.Masv = masv;
        this.Tensv = tensv;
        this.Lop = lop;
        this.Monhoc = monhoc;
        this.Diemhs1 = diemhs1;
        this.Diemhs2 = diemhs2;
        this.Diemhs2_2 = diemhs2;
        this.Average = average;
        this.Diemthi = diemthi;
        this.Diemtk = diemtk;
    }

    public string Masv { get => masv; set => masv = value; }
    public string Tensv { get => tensv; set => tensv = value; }
    public string Lop { get => lop; set => lop = value; }
    public string Monhoc { get => monhoc; set => monhoc = value; }
    public double Diemhs1 { get => diemhs1; set => diemhs1 = value; }
    public double Diemhs2 { get => diemhs2; set => diemhs2 = value; }
    public double Diemhs2_2 { get => diemhs2_2; set => diemhs2_2 = value; }
    public double Average { get => average; set => average = value; }
    public double Diemthi { get => diemthi; set => diemthi = value; }
    public double Diemtk { get => diemtk; set => diemtk = value; }

    public string XepLoaiSV()
    {
        if (Diemtk < 5) return "Yếu";
        if (Diemtk < 6.5) return "Trung bình";
        if (Diemtk < 7.5) return "Khá";
        if (Diemtk < 9) return "Giỏi";
        return "Xuất sắc";
    }
    public abstract void Input();
    public abstract void Output();
}