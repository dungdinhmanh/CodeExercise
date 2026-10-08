using System;
using System.Drawing;
using System.Text;

class Program
{
    static void Main (string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Shape hv = new Square(6);
        hv.Output();
        Shape hcn = new Rectangle1(4,5);
        hcn.Output();
    }
}