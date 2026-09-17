using System.Text;

class Program
{
    static int Input()
    {
        int n;
        do
        {
            Console.Write("Nhập n trong khoảng 1-12: ");
            n = int.Parse(Console.ReadLine());
        } while (n < 1 || n > 12);
        return n;
    }
    static void daymonth(int n)
    {
        switch (n)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("Tháng {0} có 31 ngày", n);
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine("Tháng {0} có 30 ngày", n);
                break;
            case 2:
                Console.WriteLine("Tháng {0} có 28 hoặc 29 ngày", n);
                break;
        }
    }
    static void Main(string[] args) 
    {
        Console.WriteLine("---- Menu ----");
        Console.WriteLine("1. Hiển thị ngày trong tháng");
        Console.WriteLine("0. Thoát");
        Console.Write("Nhập lựa chọn của bạn: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                int n = Input();
                daymonth(n);
                break;
            case 0: break;
            default:
                Console.WriteLine("Nhập sai lựa chọn, vui lòng nhập lại.");
                break;
        }
    }
}