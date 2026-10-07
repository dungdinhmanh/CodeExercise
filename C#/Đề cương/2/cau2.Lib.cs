class Person
{
  public string ma {get; set; }
  public string hoten {get; set; }
  public string gioitinh {get; set; }
  public string ngaysinh {get; set; }
  public string diachi {get; set; }
  public Person(string ma, string hoten, string gioitinh, string ngaysinh, string diachi)
  {
    this.ma = ma;
    this.hoten = hoten;
    this.gioitinh = gioitinh;
    this.ngaysinh = ngaysinh;
    this.diachi = diachi;
  }
  public Person() { }
  public void InputInfo()
  {
    Console.Write("Nhập mã: ");
    ma = Console.ReadLine();
    Console.Write("Nhập họ tên: ");
    hoten = Console.ReadLine();
    Console.Write("Nhập giới tính: ");
    gioitinh = Console.ReadLine();
    Console.Write("Nhập ngày sinh: ");
    ngaysinh = Console.ReadLine();
    Console.Write("Nhập địa chỉ: ");
    diachi = Console.ReadLine();
  }
  public void ShowInfo()
  {
    Console.WriteLine($"{ma,-10}{hoten,-20}{gioitinh,-10}{ngaysinh,-15}{diachi,-30}");
  }
}
