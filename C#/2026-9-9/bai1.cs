using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Nhập tháng từ 1-12: ");
int a;
a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"Tháng {a} có ");
switch (a)
{
    case 1: Console.Write("31 ngày"); break;
    case 3: Console.Write("31 ngày"); break;
    case 5: Console.Write("31 ngày"); break;
    case 7: Console.Write("31 ngày"); break;
    case 8: Console.Write("31 ngày"); break;
    case 10: Console.Write("31 ngày"); break;
    case 12: Console.Write("31 ngày"); break;
    case 2: Console.Write("28/29 ngày"); break;
    case 4: Console.Write("30 ngày"); break;
    case 6: Console.Write("30 ngày"); break;
    case 9: Console.Write("30 ngày"); break;
    case 11 : Console.Write("30 ngày"); break;
}