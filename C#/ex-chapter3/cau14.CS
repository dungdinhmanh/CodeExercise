using System.Runtime.InteropServices;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

static int input()
{
    int n;
    do
    {
        Console.Write("Nhập số nguyên dương: ");
        n = Convert.ToInt32(Console.ReadLine());
    } while (n<0);
    return n;
}
static bool check_triangle(int a, int b, int c)
{
    if (((a+b)>c) && ((a+c)>b) && ((b+c)>a) )
    {
        return true;
    } else return false;
}
static int chuvi(a,b,c)
{
    
}
int a,b,c;
a = input();
b = input();
c = input();
