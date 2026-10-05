using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        DanhSachNhanVien DS = new DanhSachNhanVien();
        int choice;
        Console.WriteLine("Chương trình quản lý nhân viên");
        do
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n--- Menu ---");
            Console.WriteLine("1. Thêm nhân viên");
            Console.WriteLine("2. Sửa thông tin nhân viên");
            Console.WriteLine("3. Xóa nhân viên");
            Console.WriteLine("4. Tìm kiếm nhân viên");
            Console.WriteLine("5. Thoát");
            Console.WriteLine("-------------");
            Console.Write("Chọn chức năng (1-5): ");
            choice = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            switch (choice)
            {
                case 1:
                    DS.Add();
                    break;
                case 2:
                    DS.Modify();
                    break;
                case 3:
                    DS.RemoveNV();
                    break;
                case 4:
                    DS.Search();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Chức năng không hợp lệ. Vui lòng chọn lại.");
                    break;
            }
        } while (choice != 5);
    }
}