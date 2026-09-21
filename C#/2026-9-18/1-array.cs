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
    static void count(int[] a, int n)
    {
        int odd = 0, even = 0;
        for (int i = 0; i < n; i++)
        {
            if (a[i] % 2 == 0)
                even++;
            else
                odd++;
        }
        Console.WriteLine("Số lượng số chẵn trong mảng là: " + even);
        Console.WriteLine("Số lượng số lẻ trong mảng là: " + odd);
    }
    static void PerfectNumber(int[] a, int n)
    {
        int count = 0;
        Console.Write("Các số hoàn hảo trong mảng là: ");
        foreach (int i in a)
        {
            int sum = 0;
            for (int j = 1; j < i; j++)
            {
                if (i % j == 0)
                    sum += j;
            }
            if (sum == i && i != 0)
                Console.Write(i + " ");
                count++;
        }
        if (count == 0) Console.WriteLine("Mảng không có số hoàn hảo");
    }
    static void SquareNumber(int[] a, int n)
    {
        Console.Write("Các số chính phương trong mảng là: ");
        foreach (int i in a)
        {
            int num = (int)Math.Sqrt(i);
            if (num * num == i)
                Console.Write(i + " ");
        }
    }
    static void Main(string[] args)
    {
        int n = Input();
        renew:
        int[] arr = CreateArray(n);
        top:
        Console.WriteLine("\n🐧🐧🐧 Menu 🐧🐧🐧");
        Console.WriteLine("1. Làm mới mảng");
        Console.WriteLine("2. Xuất mảng ra màn hình");
        Console.WriteLine("3. Phần tử lớn nhất/nhỏ nhất của mảng");
        Console.WriteLine("4. Tổng các phần tử trong mảng");
        Console.WriteLine("5. Sắp xếp mảng tăng dần");
        Console.WriteLine("6. Đảo ngược mảng");
        Console.WriteLine("7. Đếm số lượng số chẵn và số lẻ trong mảng");
        Console.WriteLine("8. Trung bình cộng các phần tử của mảng");
        Console.WriteLine("9. Số hoàn hảo trong mảng");
        Console.WriteLine("10. Số chính phương trong mảng");
        Console.WriteLine("0. Thoát");
        Console.Write("Nhập lựa chọn: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
            goto renew;
            case 2:
            Console.Write("Mảng: ");
            Output(arr, n);
            goto top;
            case 3:
            Console.WriteLine("Phần tử lớn nhất của mảng là: "+ arr.Max());
            Console.WriteLine("Phần tử nhỏ nhất của mảng là: "+ arr.Min());
            goto top;
            case 4:
            Console.WriteLine("Tổng các phần tử trong mảng là: "+ arr.Sum());
            goto top;
            case 5:
            Console.Write("Mảng sau khi sắp xếp tăng dần là: ");
            Array.Sort(arr);
            Output(arr, n);
            goto top;
            case 6:
            Console.Write("Mảng sau khi đảo ngược là: ");
            Array.Reverse(arr);
            Output(arr, n);
            goto top;
            case 7:
            count(arr, n);
            goto top;
            case 8:
            Console.WriteLine("Trung bình cộng các phần tử của mảng là: " + arr.Average());
            goto top;
            case 9:
            PerfectNumber(arr, n);
            goto top;
            case 10:
            SquareNumber(arr, n);
            goto top;
            case 0:
            break;
            default: Console.WriteLine("Lựa chọn không hợp lệ!"); goto top;
        }
    }
}