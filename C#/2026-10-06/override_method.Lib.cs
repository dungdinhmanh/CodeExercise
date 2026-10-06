class Vehicle
{
    public int NamSX { get; set; }
    public string HangSX { get; set; }
    public string MauSac { get; set; }
    public Vehicle(int namSX, string hangSX, string mauSac)
    {
        NamSX = namSX;
        HangSX = hangSX;
        MauSac = mauSac;
    }
    public Vehicle() {}
    public virtual void Input()
    {
        do
        {
            Console.Write("Nhập năm sản xuất: ");
            NamSX = int.Parse(Console.ReadLine());
            if (NamSX < 2000 || NamSX > DateTime.Now.Year)
            {
                Console.WriteLine("Năm sản xuất không hợp lệ. Vui lòng nhập lại.");
            }
        } while (NamSX < 2000 || NamSX > DateTime.Now.Year);
        Console.Write("Nhập hãng sản xuất: ");
        HangSX = Console.ReadLine();
        Console.Write("Nhập màu sắc: ");
        MauSac = Console.ReadLine();
    }
    public virtual void Output()
    {
        Console.Write($"{NamSX,-20}{HangSX,-30}{MauSac,-20}");
    }
}