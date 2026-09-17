using System.Text;

class Program
{
    static int input()
    {
        int n;
        do
        {
            Console.WriteLine("Nhập số nguyên dương: ");
            n = int.Parse(Console.ReadLine());
        } while (n <= 0);
        return n;
    }
    static void fibonaci(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write($"");
        }
    }
    static void main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int choice, n;
        n = input();
        Console.WriteLine("***** MENU *****");
        Console.WriteLine("1. In dãy Fibonacci");
        Console.WriteLine("0. Thoát");
        Console.Write("Nhập lựa chọn của bạn: ");
        switch (choice = int.Parse(Console.ReadLine()))
        {
            case 1:
                fibonaci(n);
                break;
            case 0:
                Console.WriteLine("Thoát chương trình");
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ");
                break;
        }
    }
}