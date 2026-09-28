using System;
using System.Text;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        BankAccount bak = new BankAccount("00123405679", "Nguyễn Văn A", 1000000);
        int choice;
        do
        {
            Console.WriteLine("\n1. Kiểm tra tài khoản");
            Console.WriteLine("2. Nạp tiền");
            Console.WriteLine("3. Rút tiền");
            Console.WriteLine("--------------");
            Console.Write("Nhập lựa chọn của bạn: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    bak.Info();
                    break;
                case 2:
                    Console.Write("Nhập số tiền bạn muốn nạp: ");
                    bak.Income(double.Parse(Console.ReadLine()));
                    break;
                case 3:
                    Console.Write("Nhập số tiền bạn muốn rút: ");
                    bak.Outcome(double.Parse(Console.ReadLine()));
                    break;
                case 0:
                    Console.WriteLine("Đang thoát ...");
                    Thread.Sleep(1800);
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    break;
            }
        } while (choice != 0);
    }
}