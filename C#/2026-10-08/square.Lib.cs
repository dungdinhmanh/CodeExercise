class Square : Shape
{
    public int Canh {get;set;}
    public override int Perimeter()
    {
        return Canh * 4;
    }
    public override int Area()
    {
        return Canh * Canh;
    }
    public override void Input()
    {
        do
        {
            Console.Write("Nhập cạnh cho hình vuông: ");
            Canh = int.Parse(Console.ReadLine());
        } while (Canh < 0);
    }
    public override void Output()
    {
        Console.WriteLine($"Cạnh {Canh} Chu vi: {Perimeter()} Diện tích: {Area()}");
    }
    public Square() {}
    public Square(int Canh)
    {
        this.Canh = Canh;
    }
}