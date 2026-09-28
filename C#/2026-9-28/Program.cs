using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        SinhVien sv1;
        sv1 = new SinhVien();
        sv1.maSV = "Sv001";
        sv1.tenSV = "Nguyễn Văn Nam";
        sv1.diemSV = 10;
        sv1.Output();
        //constructor with parameter
        SinhVien sv2 = new SinhVien("Sv002", "Nguyễn Văn A", 10);
        sv2.Output();

        SinhVien sv3 = new SinhVien("Sv003");
        sv3.tenSV = "Nguyễn Văn B";
        sv3.diemSV = 9.5;
        sv3.Output();
    }
}