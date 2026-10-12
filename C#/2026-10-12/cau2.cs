using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        DSSV ds = new DSSV();
        int choice;

        Console.WriteLine("Chương trình quản lý sinh viên IT");
        do
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n--- Menu ---");
            Console.WriteLine("1. Thêm sinh viên");
            Console.WriteLine("2. Sửa thông tin sinh viên");
            Console.WriteLine("3. Xóa sinh viên");
            Console.WriteLine("4. Tìm kiếm sinh viên theo mã");
            Console.WriteLine("5. Sắp xếp theo điểm tổng kết tăng dần");
            Console.WriteLine("6. Hiển thị danh sách sinh viên");
            Console.WriteLine("0. Thoát");
            Console.WriteLine("-------------");
            Console.Write("Chọn chức năng: ");
            Console.ForegroundColor = ConsoleColor.White;

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ds.Add();
                    break;
                case 2:
                    ds.Modify();
                    break;
                case 3:
                    ds.Delete();
                    break;
                case 4:
                    ds.Search();
                    break;
                case 5:
                    ds.SortByDiemTK();
                    break;
                case 6:
                    ds.Output();
                    break;
                case 0:
                    Console.WriteLine("Kết thúc chương trình.");
                    return;
                default:
                    Console.WriteLine("Chức năng không hợp lệ. Vui lòng chọn lại.");
                    break;
            }
        } while (choice != 0);
    }
}