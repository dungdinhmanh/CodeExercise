class Teacher : Person
{
    public string Lopday { get; set; }
    public int Sogio { get; set; }
    public int Luonggio { get; set; }
    public Teacher(string ma, string hoten, string gioitinh, string ngaysinh, string diachi, string lopday, int sogio, int luonggio) : base(ma, hoten, gioitinh, ngaysinh, diachi)
    {
        this.Lopday = lopday;
        this.Sogio = sogio;
        this.Luonggio = luonggio;
    }
    public Teacher() { }
    public override void InputInfo()
    {
        base.InputInfo();
        Console.Write("Nhập lớp dạy: ");
        Lopday = Console.ReadLine();
        do {
            Console.Write("Nhập số giờ: ");
            Sogio = int.Parse(Console.ReadLine());
            if (Sogio <= 0)
            {
                Console.WriteLine("Số giờ không được âm. Vui lòng nhập lại.");
            }
        } while (Sogio <= 0);
        do {
            Console.Write("Nhập lương giờ: ");
            Luonggio = int.Parse(Console.ReadLine());
            if (Luonggio <= 0)
            {
                Console.WriteLine("Lương giờ không được âm. Vui lòng nhập lại.");
            }
        } while (Luonggio <= 0);
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"{Lopday,-20}{Sogio,-15}{Luonggio,-20}");
    }
    public int TinhLuong()
    {
         return Sogio * Luonggio;
    }
}