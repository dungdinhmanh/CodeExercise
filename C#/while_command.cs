using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int n;
do
{
    Console.Write("Nhập n: ");
    n = Convert.ToInt32(Console.ReadLine());
} while (n<0);