using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập chiều dài: ");
        double l = double.Parse(Console.ReadLine());
        Console.Write("Nhập chiều rộng: ");
        double w = double.Parse(Console.ReadLine());
        Rtgl rtgl = new Rtgl(l, w);
        rtgl.Output();
    }
}