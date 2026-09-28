using System.Text;

class SinhVien
{
    public string maSV;
    public string tenSV;
    public double diemSV;
    public SinhVien(string maSV, string tenSV, double diemSV)
    {
        this.maSV = maSV;
        this.tenSV = tenSV;
        this.diemSV = diemSV;
    }
    //constructor - phương thức khởi tạo không có tham số
    public SinhVien() {}

    public SinhVien(string maSV) {this.maSV = maSV;}

    public void Output()
    {
        Console.WriteLine($"Mã sinh viên: {maSV}; Tên sinh viên: {tenSV}; Điểm sinh viên: {diemSV}");
    }
}