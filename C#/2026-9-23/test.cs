using System.Text;
class Program
{
    static Random rand = new Random();

    static int Input()
    {
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
        {
            Console.Write("Giá trị không hợp lệ! Vui lòng nhập lại số nguyên dương: ");
        }
        return n;
    }

    static void CreateArray(int[,] a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                a[i, j] = rand.Next(-50, 100);
            }
        }
        Console.WriteLine("Khởi tạo mảng thành công!");
    }

    static void Output(int[,] a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void Check(int[,] a, Func<int, bool> func)
    {
        bool hasElement = false;
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (func(a[i, j]))
                {
                    Console.Write(a[i, j] + " ");
                    hasElement = true;
                }
            }
        }
        if (!hasElement) Console.Write("Không có phần tử nào thỏa mãn");
        Console.WriteLine();
    }
    static bool CheckPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
    static bool CheckSquare(int n)
    {
        if (n < 0) return false;
        int num = (int)Math.Sqrt(n);
        return (num * num == n);
    }
    static bool PerfectNum(int n)
    {
        if (n <= 0) return false;
        int sum = 0;
        for (int i = 1; i < n; i++)
        {
            if (n % i == 0) sum += i;
        }
        return (sum == n);
    }
    static int CountMax(int[,] a)
    {
        int max = a[0, 0];
        int count = 0;

        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i, j] > max)
                {
                    max = a[i, j];
                    count = 1;
                }
                else if (a[i, j] == max)
                {
                    count++;
                }
            }
        }
        Console.WriteLine($"- Giá trị lớn nhất (Max) trong mảng là: {max}");
        return count;
    }
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập số hàng: ");
        int m = Input();
        Console.Write("Nhập số cột: ");
        int n = Input();
        int[,] arr = new int[m, n];
        CreateArray(arr); 

    menu:
        Console.Clear();
        Console.WriteLine("========== MENU ==========");
        Console.WriteLine("1. Khởi tạo lại mảng ngẫu nhiên");
        Console.WriteLine("2. Xuất mảng");
        Console.WriteLine("3. In các số nguyên tố");
        Console.WriteLine("4. In các số chính phương");
        Console.WriteLine("5. In các số hoàn hảo");
        Console.WriteLine("6. Đếm số lượng giá trị lớn nhất");
        Console.WriteLine("0. Thoát");
        Console.WriteLine("==========================");
        Console.Write("Nhập lựa chọn: ");
        
        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice)) choice = -1;

        switch (choice)
        {
            case 1:
                CreateArray(arr);
                Console.WriteLine("Nhấn phím bất kỳ để quay lại menu...");
                Console.ReadKey(); goto menu;
            case 2:
                Console.WriteLine("Mảng hiện tại: ");
                Output(arr);
                Console.WriteLine("Nhấn phím bất kỳ để quay lại menu...");
                Console.ReadKey(); goto menu;
            case 3:
                Console.Write("Các số nguyên tố trong mảng là: ");
                Check(arr, CheckPrime);
                Console.WriteLine("Nhấn phím bất kỳ để quay lại menu...");
                Console.ReadKey(); goto menu;
            case 4:
                Console.Write("Các số chính phương trong mảng là: ");
                Check(arr, CheckSquare);
                Console.WriteLine("Nhấn phím bất kỳ để quay lại menu...");
                Console.ReadKey(); goto menu;
            case 5:
                Console.Write("Các số hoàn hảo trong mảng là: ");
                Check(arr, PerfectNum);
                Console.WriteLine("Nhấn phím bất kỳ để quay lại menu...");
                Console.ReadKey(); goto menu;
            case 6:
                int count = CountMax(arr);
                Console.WriteLine($"- Số lần xuất hiện của số lớn nhất: {count} lần");
                Console.WriteLine("Nhấn phím bất kỳ để quay lại menu...");
                Console.ReadKey(); goto menu;
            case 0:
                Console.WriteLine("Tạm biệt!");
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("Lựa chọn sai! Nhấn phím bất kỳ để chọn lại...");
                Console.ReadKey(); goto menu;
        }
    }
}
