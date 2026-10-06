class Truck : Vehicle
{
    public int TaiTrong { get; set; }
    public override void Input()
    {
        base.Input();
        do
        {
            Console.Write("Nhập tải trọng: ");
            TaiTrong = int.Parse(Console.ReadLine());
            if (TaiTrong < 1 || TaiTrong > 100)
            {
                Console.WriteLine("Tải trọng không hợp lệ. Vui lòng nhập lại.");
            }
        } while (TaiTrong < 1 || TaiTrong > 100);
    }
    public override void Output()
    {
        base.Output();
        Console.WriteLine($"{TaiTrong,-15}");
    }
}