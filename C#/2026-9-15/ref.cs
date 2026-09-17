using System.Text;

class Program
{
    static void change_ref(ref int a)
    {
        a = 10;
        Console.WriteLine("Giá trị của a trong hàm change_ref: " + a);
    }

    static void change_out(out int a)
    {
        a = 20;
        Console.WriteLine("Giá trị của a trong hàm change_out: " + a);
    }

    static void change_pos(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine("Giá trị của a trong hàm change_pos: " + a);
        Console.WriteLine("Giá trị của b trong hàm change_pos: " + b);
    }
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int a = 100;
        int b = 200;
        Console.WriteLine("Giá trị của a trong hàm Main trước khi gọi change_ref: " + a);
        change_ref(ref a);
        Console.WriteLine("Giá trị của a sau khi gọi change_ref: " + a);
        change_out(out a);
        Console.WriteLine("Giá trị của a sau khi gọi change_out: " + a);
        change_pos(ref a, ref b);
        Console.WriteLine("Giá trị của a sau khi gọi change_pos: " + a);
        Console.WriteLine("Giá trị của b sau khi gọi change_pos: " + b);
        Console.WriteLine("Nhấn phím bất kỳ để thoát...");
        Console.ReadKey();
    }

}