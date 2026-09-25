using System.Text;
using System.Collections.Generic;

class Program
{
    static Random rand = new Random();
    static int Input()
    {
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n < 30)
        {
            Console.WriteLine("Nhập n lớn hơn 30: ");
        }
        return n;
    }
    static void ListInput(List<int> list, int n)
    {
        list.Clear();
        for (int i = 0; i < n; i++)
        {
            list.Add(rand.Next(-50,100));
        }
    }
    static void ListOutput(List<int> list)
    {
        if (list.Count == 0)
        {
            Console.WriteLine("Danh sách trống.");
            return;
        }
        foreach (int i in list)
        {
            Console.Write(i + "\t");
        }
    }
    static void InsertX(List<int> list)
    {
        Console.Write("Nhập phần tử cần chèn: ");
        int value = int.Parse(Console.ReadLine());
        Console.Write($"Nhập vị trí cần chèn (0 - {list.Count}): ");
        int index = int.Parse(Console.ReadLine());
        list.Insert(index, value);
        Console.Write($"Danh sách sau khi chèn {value} tại vị trí {index}: ");
        ListOutput(list);
    }
    static void RemoveX(List<int> list)
    {
        if (list.Count == 0) 
        { 
            Console.WriteLine("Danh sách rỗng!"); 
            return; 
        }
        Console.Write($"Nhập vị trí cần xóa (0 - {list.Count - 1}): ");
        list.RemoveAt(int.Parse(Console.ReadLine()));
        Console.Write("Danh sách sau khi xóa: "); ListOutput(list);
    }
    static void SearchX(List<int> list)
    {
        Console.Write("Nhập phần tử cần tìm: ");
        int a = int.Parse(Console.ReadLine());
        int index = list.IndexOf(a);
        if (index != -1)
            {
                Console.WriteLine($"Phần tử xuất hiện đầu tiên ở vị trí {index}");
            }
        else Console.WriteLine("Không tìm thấy phần tử trong danh sách");
    }
    static void GetValue(List<int> list)
    {
        if (list.Count == 0) 
        {
            Console.WriteLine("Danh sách rỗng!"); 
            return; 
        }
        Console.Write($"Nhập vị trí cần lấy giá trị (0 - {list.Count - 1}): ");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine($"Phần tử tại vị trí {index} là: {list[index]}");
    }
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int n = Input();
        int choice;
        List <int> list = new List<int>();
        do
        {
            Console.Clear();
            Console.WriteLine("---- Menu ----");
            Console.WriteLine("1. Nhập danh sách (làm mới)");
            Console.WriteLine("2. Hiển thị danh sách");
            Console.WriteLine("3. Thêm phần tử vào cuối danh sách");
            Console.WriteLine("4. Xóa phần tử");
            Console.WriteLine("5. Chèn phần tử vào danh sách");
            Console.WriteLine("6. Xóa phần tử tại vị trí");
            Console.WriteLine("7. Tìm kiếm phần tử có tồn tại trong danh sách không");
            Console.WriteLine("8. Trả về phần tử tại x trong danh sách");
            Console.WriteLine("9. Sắp xếp danh sách tăng dần");
            Console.WriteLine("10. Đảo ngược danh sách");
            Console.WriteLine("0. Thoát");
            Console.WriteLine("--------------");
            Console.Write("Nhập lựa chọn: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                Console.WriteLine("Nhập vào danh sách");
                ListInput(list, n);
                break;
                case 2:
                Console.Write("Danh sách vừa nhập là: ");
                ListOutput(list);
                break;
                case 3:
                Console.Write("Nhập phần tử cần thêm vào cuối danh sách: ");
                list.Add(int.Parse(Console.ReadLine()));
                Console.Write("Danh sách sau khi thêm: ");
                ListOutput(list);
                break;
                case 4:
                Console.Write("Nhập phần tử cần xóa: ");
                list.Remove(int.Parse(Console.ReadLine()));
                Console.Write("Danh sách sau khi xóa: ");
                ListOutput(list);
                break;
                case 5:
                InsertX(list);
                break;
                case 6:
                RemoveX(list);
                break;
                case 7:
                SearchX(list);
                break;
                case 8:
                GetValue(list);
                break;
                case 9:
                list.Sort();
                Console.Write("Danh sách sau khi sắp xếp tăng dần: ");
                ListOutput(list);
                break;
                case 10:
                list.Reverse();
                Console.Write("Danh sách sau khi đảo ngược: ");
                ListOutput(list);
                break;
                case 0:
                Console.WriteLine("Tạm biệt!");
                break;
            }
             if (choice != 0)
            {
                Console.WriteLine("\nNhấn phím bất kỳ để quay lại Menu...");
                Console.ReadKey();
            }
        } while(choice != 0);
    }
}