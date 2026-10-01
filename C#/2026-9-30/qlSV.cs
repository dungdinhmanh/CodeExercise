using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        ListStudent lst = new ListStudent();
        int choice;
        do
        {
            Console.WriteLine("--- Menu ---");
            Console.WriteLine("1. Thêm sinh viên");
            Console.WriteLine("2. Hiển thị danh sách sinh viên");
            Console.WriteLine("0. Thoát");
            Console.WriteLine("------------");
            Console.WriteLine("Nhập lựa chọn: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 0: 
                Console.WriteLine("Đang thoát ...");
                Thread.Sleep(1800);
                return;
                case 1:
                lst.AddSV(); break;
                case 2:
                lst.OutputList(); break;
                default: Console.WriteLine("Nhập sai lựa chọn, nhập lại."); break;
            }
        } while (choice != 0);
    }
}