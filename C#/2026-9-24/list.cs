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
    static void ListInput(List<int> list)
    {
        for (int i = 0; i < list.Capacity; i++)
        {
            list.Add(rand.Next(-50,100));
        }
    }
    static void ListOutput(List<int> list)
    {
        foreach (int i in list)
        {
            Console.Write(i + "\t");
        }
    }
    static void InsertX(List<int> list)
    {
        Console.Write("Nhập phần tử cần chèn: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Nhập vị trí cần chèn: ");
        int x = int.Parse(Console.ReadLine());
        list.Insert(n, x);
        Console.Write($"Danh sách sau khi chèn {n} tại vị trí {x}: ");
        foreach (int i in list)
        {
            Console.Write(i +"\t");
        }
    }
    static void Main(string[] args)
    {
        int n = Input();
        List <int> list = new List(n);
        do
        {
            Console.Clear;
            Console.
        }
    }
}