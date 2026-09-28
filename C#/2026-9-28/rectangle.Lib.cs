using System.Text;

class Rtgl
{
    public double width;
    public double length;
    public Rtgl(double length, double width)
    {
        this.width = width;
        this.length = length;
    }
    public double Area(double length, double width)
    {
        return width*length;
    }
    public double Perimeter(double length, double width)
    {
        return (width+length)*2;
    }
    public void Output()
    {
        Console.WriteLine($"Chu vi hình chữ nhật là: {Area(length,width)}");
        Console.WriteLine($"Diện tích hình chữ nhật là: {Perimeter(length, width)}");
    }
}