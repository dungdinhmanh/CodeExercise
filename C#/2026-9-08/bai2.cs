using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.Write("Nhập số a: ");
a = Convert.ToInt16(Console.ReadLine);
Console.Write("Nhập số b: ");
b = Convert.ToInt16(Console.ReadLine);

if (a != 0)
{
    if (b != 0)
    {
        result = -b/a;
    }
    Console.WriteLine($"Phương trình có nghiệm duy nhất {a}x+{b}=0 là {result}");
}
else
{
    if (b = 0)
    {
        Console.WriteLine("Phương trình vô số nghiệm");
    }
    Console.WriteLine("Phương trình vô nghiệm");
}