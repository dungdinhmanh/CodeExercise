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
    static void perfect_num()
    {
        int n = input();
        int sum = 0;
        for (int i = 1; i < n; i++)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }
        if (sum == n)
        {
            Console.WriteLine($"{n} là số hoàn hảo");
        }
        else
        {
            Console.WriteLine($"{n} không phải số hoàn hảo");
        }
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int choice;
        Console.WriteLine("***** MENU *****");
        Console.WriteLine("1. Kiểm tra số hoàn hảo");
        Console.WriteLine("0. Thoát");
        Console.Write("Nhập lựa chọn của bạn: ");
        switch (choice = int.Parse(Console.ReadLine()))
        {
            case 1:
                perfect_num();
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
