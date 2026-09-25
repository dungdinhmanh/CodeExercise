using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Circle cc = new Circle();
        cc.radius = 6;
        cc.area();
    }
}
class Circle
{
    public double radius;
    public const double pi = 3.14;
    public void area ()
    {
        Console.WriteLine("Diện tích hình tròn là: "+ radius * radius * pi);
    }
}