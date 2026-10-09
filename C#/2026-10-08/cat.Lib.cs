class Cat : Animal
{
    public string Name {get;set;}
    public int Age {get;set;}
    public string Desc {get;set;}
    public override void Input()
    {
        Console.Write("Nhập tên động vật: ");
        Name = Console.ReadLine();
        do
        {
            Console.Write("Nhập tuổi động vật: ");
            Age = int.Parse(Console.ReadLine());
        } while (Age < 0);
        Console.Write("Nhập mô tả: ");
        Desc = Console.ReadLine();
    }
    public override void ShowInfo()
    {
        Console.WriteLine($"");
    }
}