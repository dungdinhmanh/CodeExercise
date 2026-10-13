using System;

class Program
{
    static int Input()
    {
        int n;
        do
        {
            n = int.TryParse(Console.ReadLine());
        } while (n < 0);
        return n;
    }
    static List<int> CreateArray(List <int> ds)
    {
        for (int i = 0; i < ds.Count(); i++)
        {
            Random rnd = new Random();
            ds.Add(rnd.Next(-50,50));
        }
        return ds;
    }
    static void Main(string[] args)
    {
        Console.Write("Nhập số hàng: ");
        int m = Input();
        Console.Write("Nhập số cột: ");
        int n = Input();

    }
}