class ListStudent
{
    List<Student> ls = new List<Student>()
    {
        new Student(1, "An", "CNTT2", "Hà Nội", "12/11/2005", "0973472364"),
        new Student(2, "Bình", "CNTT2", "Hải Phòng", "1/5/2005", "0476437283"),
        new Student(3, "Cường", "CNTT2", "Cà Mau", "6/7/2007", "0986875747"),
        new Student(4, "Nam", "CNTT2", "Sơn La", "20/2/2006", "0875475463"),
    };
    public void InputLS()
    {
        Console.Write("Nhập số lượng sinh viên cần thêm: ");
        int n = int.Parse(Console.ReadLine());
    }
}