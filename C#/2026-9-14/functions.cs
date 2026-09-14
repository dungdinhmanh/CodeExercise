using System.Text;

Console.OutputEncoding = Encoding.UTF8;

static int pos_only()
{
    int n;
    do
    {
        
        Console.Write("Nhập số nguyên dương: ");
        n = Convert.ToInt32(Console.ReadLine());
    } while (n<0);
    return n;
}

int a,b;
a = pos_only();
b = pos_only();
