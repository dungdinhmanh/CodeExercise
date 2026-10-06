using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Vehicle car = new Car();
        Vehicle motobike = new Motobike();
        Vehicle truck = new Truck();
        car.Input();
        motobike.Input();
        truck.Input();
        car.Output();
        motobike.Output();
        truck.Output();
    }
}