class Motobike : Vehicle
{
    public int DungTich { get; set; }
    public override void Input()
    {
        base.Input();
        do
        {
            Console.Write("Nhập dung tích: ");
            DungTich = int.Parse(Console.ReadLine());
            if (DungTich < 50 || DungTich > 2000)
            {
                Console.WriteLine("Dung tích không hợp lệ. Vui lòng nhập lại.");
            }
        } while (DungTich < 50 || DungTich > 2000);
    }
    public override void Output()
    {
        base.Output();
        Console.WriteLine($"{DungTich,-15}");
    }
}