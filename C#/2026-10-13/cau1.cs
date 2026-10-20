using System;

class Program
{
    static Random rnd = new Random();
    static int Input()
    {
        int n;
        do
        {
            n = int.TryParse(Console.ReadLine());
        } while (n < 0);
        return n;
    }
    static int[] CreateArray(int[] arr)
    {
        for (int i = 0; i < arr.Count(); i++)
        {
            arr[i] = rnd.Next(-50,50);
        }
        return ds;
    }
    static void Main(string[] args)
    {
        Console.Write("Nhập số hàng: ");
        int m = Input();
        Console.Write("Nhập số cột: ");
        int n = Input();
        int[,] arr = new int[m,n];
        
    }
}