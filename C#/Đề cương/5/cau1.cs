using System.Text;

class Program {
    static int Input()
    {
        int n;
        do
        {
            Console.Write("Nhập số nguyên dương n: ");
            n = int.Parse(Console.ReadLine());
        } while (n < 0);
        return n;
    }
    static double SUM(int n)
    {
        if (n == 1)
            return 1.0/2;
        return 1.0 / (2 * n) + SUM(n - 1);
    }
    static void Main(string[] args)
    {
        int n = Input();
        Console.WriteLine("Tổng S = " + Math.Round(SUM(n), 2));
    }
}