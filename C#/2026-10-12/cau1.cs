using System;
using System.Text;

class Program
{
    static int Input()
    {
        int n;
        do
        {
            Console.Write("Nhập số nguyên dương: ");
            n = int.Parse(Console.ReadLine());
        } while (n < 0);
        return n;
    }
    static bool PerfectNum(int n)
    {
        int sum = 0;
        int i;
        for (i = 1; i < n; i++)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }
        if (sum==i) return true; else return false;
    }
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int n = Input();
        if (PerfectNum(n))
        {
            Console.WriteLine($"{n} là số hoàn hảo.");
        } else Console.WriteLine($"{n} không phải số hoàn hảo.");
    }
}