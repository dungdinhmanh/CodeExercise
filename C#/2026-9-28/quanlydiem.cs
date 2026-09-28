using System.Text;

class Program
{
    static void Main(string[] args)
    {
        PM sv1 = new PM("001", "Nguyễn Văn A", "Tin học", 9);
        PM sv2 = new PM("002", "Nguyễn Văn B", "Toán", 7);
        sv1.Output();
        sv2.Output();
    }
}