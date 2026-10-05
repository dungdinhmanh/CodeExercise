class NhanVien
{
    private string maNV;
    private string hoTen;
    private string gioiTinh;
    private string chucVu;
    private double luongCoBan;
        private double soNgayCong;
    private double phuCap;
    private double luongTong;

    public string MaNV { get { return maNV; } set { maNV = value; } }
    public string HoTen { get { return hoTen; } set { hoTen = value; } }
    public string GioiTinh { get { return gioiTinh; } set { gioiTinh = value; } }
    public string ChucVu { get { return chucVu; } set { chucVu = value; } }
    public double LuongCoBan { get { return luongCoBan; } set { luongCoBan = value; } }
    public double SoNgayCong { get { return soNgayCong; } set { soNgayCong = value; } }
    public double PhuCap { get { return phuCap; } set { phuCap = value; } }
    public double LuongTong { get { return luongTong; } set { luongTong = value; } }

    public NhanVien() {}
    public NhanVien(string maNV, string hoTen, string gioiTinh, string chucVu, double luongCoBan, double soNgayCong)
    {
        this.maNV = MaNV;
        this.hoTen = HoTen;
        this.gioiTinh = GioiTinh;
        this.chucVu = ChucVu;
        this.luongCoBan = LuongCoBan;
        this.soNgayCong = SoNgayCong;
    }
    public double TinhPhuCap()
    {
        if (chucVu == "Giám đốc")
            return 2000000;
        else if (chucVu == "Trưởng phòng")
            return 1500000;
        else
            return 1000000;
    }
    public double TinhLuongTong()
    {
        return LuongCoBan * SoNgayCong/26 + TinhPhuCap();
    }
    public void Input()
    {
        Console.Write("Nhập mã nhân viên: ");
        maNV = Console.ReadLine();
        Console.Write("Nhập họ tên: ");
        hoTen = Console.ReadLine();
        Console.Write("Nhập giới tính (true/false): ");
        gioiTinh = Console.ReadLine();
        Console.Write("Nhập chức vụ: ");
        chucVu = Console.ReadLine();
        Console.Write("Nhập lương cơ bản: ");
        luongCoBan = double.Parse(Console.ReadLine());
        Console.Write("Nhập số ngày công: ");
        soNgayCong = double.Parse(Console.ReadLine());
        phuCap = TinhPhuCap();
        luongTong = TinhLuongTong();
    }
}