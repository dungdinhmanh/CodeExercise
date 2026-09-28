using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Torch tch = new Torch(false);
        int choice;
        do
        {
            Console.WriteLine("1. Bật đèn");
            Console.WriteLine("2. Tắt đèn");
            Console.WriteLine("0. Thoát");
            Console.WriteLine("----------");
            Console.Write("Nhập lựa chọn: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                tch.On();
                Console.WriteLine("Trạng thái: " + tch.Output());
                break;
                case 2:
                tch.Off();
                Console.WriteLine("Trạng thái: " + tch.Output());
                break;
                case 0:
                Console.WriteLine("Đang thoát chương trình");
                Thread.Sleep(1800);
                return;
                default:
                Console.WriteLine("Lựa chọn không hợp lệ!");
                break;
            }
        } while (choice != 0);
    }
}