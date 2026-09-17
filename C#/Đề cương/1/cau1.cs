using System.Text;

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

static void prime_test()
{
    bool isPrime = true;
    int n = input();
    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
        Console.WriteLine(n + " là số nguyên tố.");
    }
    else
    {
        Console.WriteLine(n + " không phải là số nguyên tố.");
    }
}

static void Main(string[] args)
{
    Console.OutputEncoding = Encoding.UTF8;
    Console.WriteLine("Nhập số nguyên dương");
    input();
    Console.WriteLine("****** Menu ******");
    Console.WriteLine("1. Kiểm tra số nguyên tố");
    Console.WriteLine("0. Thoát");
    Console.Write("Chọn chức năng (1-0): ");
    int choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            prime_test();
            break;
        case 0:
            Console.WriteLine("Đang thoát chương trình.");
            break;
        default:
            Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
            break;
    }
}