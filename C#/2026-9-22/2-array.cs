using System.Diagnostics;
using System.Text;

class Program
{
    static int Input()
    {
        int n;
        do
        {
            n = int.Parse(Console.ReadLine());
        } while (n < 0);
        return n;
    }
    static void CreateArray(int[,] a)
    {
        Random rnd = new Random();
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                a[i,j] = rnd.Next(-50,100);
            }
        }
    }
    static void Output(int[,]a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
    static void MinMax(int[,]a)
    {
        int max = a[0,0], min = a[0,0];
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i,j] > max) max = a[i,j];
                if (a[i,j] < min) min = a[i,j];
            }
        }
        Console.WriteLine("Giá trị lớn nhất của mảng là: " + max);
        Console.WriteLine("Giá trị nhỏ nhất của mảng là: " + min);
    }
    static void MaxRow (int[,]a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            int max= a[i,0];
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i,j] > max) max = a[i,j];
            }
            Console.WriteLine($"Max của dòng {i} là: " + max);
        }
    }
    static void FindX(int[,]a)
    {
        Console.Write("Nhập x để tìm: ");
        int x = int.Parse(Console.ReadLine());
        bool found = false;
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i,j] == x) {
                    Console.WriteLine($"{x} nằm ở hàng {i} cột {j}");
                    found = true;
                    return;
                }
            }
        }
        if (!found) Console.WriteLine("Không tồn tại x trong mảng");
    }
    static void Main(string[] args)
    {   
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập số hàng: "); 
        int m = Input();
        Console.Write("Nhập số cột: ");
        int n = Input();
        int[,]arr = new int[m,n];
        CreateArray(arr);
        while (true)
        {
            Console.WriteLine("\n---- MENU ----");
        Console.WriteLine("1. Làm mới ");
        Console.WriteLine("2. Xuất mảng");
        Console.WriteLine("3. Giá trị lớn nhất/nhỏ nhất của mảng");
        Console.WriteLine("4. Giá trị lớn nhất của 1 hàng");
        Console.WriteLine("5. Tìm x trong mảng");
        Console.WriteLine("0. Thoát chương trình");
        Console.Write("Nhập lựa chọn của bạn: ");
        int choice = int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1:
            CreateArray(arr);
            Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
            Console.ReadKey();
            break;
            case 2:
            Console.Write("Mảng hiện tại: ");
            Output(arr);
            Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
            Console.ReadKey();
            break;
            case 3:
            MinMax(arr);
            Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
            Console.ReadKey();
            break;
            case 4:
            MaxRow(arr);
            Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
            Console.ReadKey();
            break;
            case 5:
            FindX(arr);
            Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
            Console.ReadKey();
            break;
            case 0:
            Console.WriteLine("Chương trình kết thúc. Tạm biệt!");
            return;
            default:
            Console.WriteLine("Nhập sai lựa chọn, vui lòng nhập lại");
            Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
            Console.ReadKey();
            break;
        }
        }
    }
}