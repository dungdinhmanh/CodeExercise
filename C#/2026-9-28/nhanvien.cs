using System.Text;

class Program
{
    static void Main(string[] args)
    {
        NhanVien nv1 = new NhanVien("001","Nguyễn Văn A", 9000000);
        nv1.Output();
        nv1.RealSalary(700000);
        NhanVien nv2 = new NhanVien("002","Nguyễn Văn B", 5000000);
        nv2.Output();
        nv2.RealSalary(500000);
    }
}