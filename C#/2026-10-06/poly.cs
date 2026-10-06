using System.Text;

class Program
{
    static void Main(string[] args)
    {
    Console.OutputEncoding = Encoding.UTF8;
    Student stdt = new Student();
    stdt.Name = "John Doe";
    stdt.Age = 20;
    stdt.ShowInfo();
    Student stdt2 = new Student();
    stdt2.Age = 22;
    stdt2.ShowInfo();
    Student stdt3 = new Student();
    stdt3.ShowInfo();
    }
}