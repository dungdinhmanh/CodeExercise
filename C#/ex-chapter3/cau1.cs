int a;
Console.Write("Nhập a=");
a= Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine($"{a} là số chẵn");
}
else
    Console.WriteLine($"{a} là số lẻ");
Console.WriteLine("Tạm biệt");
