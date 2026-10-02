using System.Text;

class Program
{
    static void Main(string[] args)
    {
        System.Console.OutputEncoding = Encoding.UTF8;
        ListSV listDiem = new ListSV();
        int choice;
        do
        {
            Console.WriteLine("1. Nhập danh sách sinh viên");
            Console.WriteLine("2. Thêm sinh viên");
            Console.WriteLine("3. Tìm kiếm sinh viên theo mã");
            Console.WriteLine("4. Xóa sinh viên theo mã");
            Console.WriteLine("5. Sắp xếp danh sách sinh viên theo điểm tổng kết");
            Console.WriteLine("6. Hiển thị danh sách sinh viên");
            Console.WriteLine("0. Thoát");
            string? input;
            do
            {
                Console.Write("Nhập lựa chọn của bạn: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out choice));

            switch (choice)
            {
                case 1:
                    listDiem.Add();
                    break;
                case 2:
                    listDiem.AddSV();
                    break;
                case 3:
                    listDiem.Search();
                    break;
                case 4:
                    listDiem.RemoveSV();
                    break;
                case 5:
                    listDiem.Sort();
                    break;
                case 6:
                    listDiem.Output();
                    break;
                case 0:
                    Console.WriteLine("Thoát chương trình.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }
        } while (choice != 0);
    }
}