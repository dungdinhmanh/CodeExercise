using System.Text;

class Program
{
    static int Input()
    {
        int n;
        do
        {
            Console.Write("Nhập số phần tử của mảng: ");
            n = int.Parse(Console.ReadLine());
        } while (n < 0);
        return n;
    }
    static int[] CreateArray(int n)
    {
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Random rand = new Random();
            arr[i] = rand.Next(-50, 100);
        }
        return arr;
    }
    static void Output(int[] a, int n)
    {
        foreach (int i in a)
        {
            Console.Write(i + " ");
        }
    }
    static void Main(string[] args)
    {
        int n = Input();
        int[] arr = CreateArray(n);
        Console.WriteLine("🐧🐧🐧 Menu 🐧🐧🐧");
        Console.WriteLine("1. Xuất mảng ra màn hình");
        Console.WriteLine("2. Phần tử lớn nhất của mảng");
        Console.WriteLine("3. Phần tử nhỏ nhất của mảng");
        Console.WriteLine("4. Sắp xếp mảng tăng dần");
        Console.WriteLine("5. Đảo ngược mảng");
        Console.WriteLine("0. Thoát");
        Console.Write("Nhập lựa chọn: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
            Console.Write("Mảng: ");
            Output(arr, n);
            break;
            case 2:
            Console.WriteLine("Phần tử lớn nhất của mảng là: "+ arr.Max());
            break;
            case 3:
            Console.WriteLine("Phần tử nhỏ nhất của mảng là: "+ arr.Min());
            break;
            case 4:
            Console.Write("Mảng sau khi sắp xếp tăng dần là: ");
            Array.Sort(arr);
            Output(arr, n);
            break;
            case 5:
            Console.Write("Mảng sau khi đảo ngược là: ");
            Array.Reverse(arr);
            Output(arr, n);
            break;
            default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
        }
    }
}