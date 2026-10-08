class Rectangle1 : Shape
{
    public int Length {get;set;}
    public int Width {get;set;}
    public override int Perimeter()
    {
        return (Length + Width)*2;
    }
    public override int Area()
    {
        return Length * Width;
    }
    public override void Input()
    {
        do
        {
            Console.Write("Nhập chiều dài: ");
            Length = int.Parse(Console.ReadLine());
            Console.Write("Nhập chiều rộng: ");
            Width = int.Parse(Console.ReadLine());
        } while (Length < 0 && Width < 0);
    }
    public override void Output()
    {
        Console.WriteLine($"Chiều dài: {Length} Chiều rộng: {Width}\n Chu vi: {Perimeter()} Diện tích: {Area()}");
    }
    public Rectangle1() { }
    public Rectangle1(int Length, int Width)
    {
        this.Length = Length;
        this.Width = Width;
    }
}