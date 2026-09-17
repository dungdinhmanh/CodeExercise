using System.Text;

class Program
{
    static int input()
    {
        int n;
        do
        {
            Console.Write("Nhập số nguyên dương n: ");
            n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Vui lòng nhập một số nguyên dương lớn hơn 0");
            }
        } while (n <= 0);
        return n;
    }
    static void so_chinh_phuong(int n)
    {
        int num = Convert.ToInt32(Math.Sqrt(n));
        if (num * num == n)
        {
            Console.WriteLine($"{n} là số chính phương");
        }
        else
        {
            Console.WriteLine($"{n} không phải là số chính phương");
        }

    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int choice,n ;
        n = input();
        Console.WriteLine("***** MENU *****");
        Console.WriteLine("1. Kiểm tra số chính phương");
        Console.WriteLine("0. Thoát");
        Console.Write("Nhập lựa chọn của bạn: ");
        switch (choice = int.Parse(Console.ReadLine()))
        {
            case 1:
                so_chinh_phuong(n);
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