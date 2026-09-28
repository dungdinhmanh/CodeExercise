using System.Text;

class NhanVien
{
    public string maNV;
    public string hoTen;
    public double luong;

    public NhanVien(string maNV, string hoTen, double luong)
    {
        this.maNV = maNV;
        this.hoTen = hoTen;
        this.luong = luong;
    }
    public void Output()
    {
        Console.WriteLine($"Thông tin nhân viên:\n - Mã nhân viên: {maNV} \n - Họ tên: {hoTen} \n - Lương cơ bản: {luong}");
    }
    public void RealSalary(double phucap)
    {
        Console.WriteLine($"Lương: {luong}  Phụ cấp: {phucap} \nThực lĩnh:{luong+phucap}");
    }
}