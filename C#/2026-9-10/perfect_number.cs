using System.Text;

Console.OutputEncoding = Encoding.UTF8;
int n, i;
int sum = 0;
Console.Write("Nhập số n: ");
n = Convert.ToInt32(Console.ReadLine());
for (i = 1; i < n; i++)
    if (n % i == 0)
    {
        sum += i;
    }
if (sum==i)
{
    Console.WriteLine($"{n} là số hoàn hảo");
} else Console.WriteLine($"{n} không là số hoàn hảo");