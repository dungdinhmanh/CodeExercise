class Car : Vehicle
{
    public int SoGhe { get; set; }
    public override void Input()
    {
        base.Input();
        do
        {
            Console.Write("Nhập số ghế: ");
            SoGhe = int.Parse(Console.ReadLine());
            if (SoGhe < 2 || SoGhe > 75)
            {
                Console.WriteLine("Số ghế không hợp lệ. Vui lòng nhập lại.");
            }
        } while (SoGhe < 2 || SoGhe > 75);
    }
    public override void Output()
    {
        base.Output();
        Console.WriteLine($"{SoGhe,-15}");
    }
}