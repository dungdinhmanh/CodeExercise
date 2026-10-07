class TeacherTest
{
    List<Teacher> tc = new List<Teacher>()
    {
        new Teacher("T001", "Nguyễn Văn A", "Nam", "01/01/1980", "Hà Nội", "Toán", 20, 200000),
        new Teacher("T002", "Trần Thị B", "Nữ", "02/02/1985", "Hải Phòng", "Lý", 15, 250000),
        new Teacher("T003", "Lê Văn C", "Nam", "03/03/1990", "Đà Nẵng", "Hóa", 10, 300000),
        new Teacher("T004", "Phạm Thị D", "Nữ", "04/04/1995", "Cần Thơ", "Sinh", 25, 150000),
        new Teacher("T005", "Hoàng Văn E", "Nam", "05/05/2000", "Hồ Chí Minh", "Văn", 30, 100000)
    };
    public void InputList()
    {
        Console.Write("Nhập số lượng giáo viên: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập thông tin giáo viên thứ {i + 1}:");
            Teacher t = new Teacher();
            t.InputInfo();
            tc.Add(t);
        }
    }
    public void AddTeacher()
    {
        Console.WriteLine("Nhập thông tin giáo viên mới:");
        Teacher t = new Teacher();
        t.InputInfo();
        tc.Add(t);
    }
    public void Search()
    {
        Console.Write("Nhập mã giáo viên cần tìm: ");
        string maGV = Console.ReadLine();
        for (int i = 0; i < tc.Count; i++)
        {
            if (maGV.Equals(tc[i].Ma, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Tìm thấy giáo viên có mã {maGV} trong dang sách");
                return;
            }
        }
        Console.WriteLine("Không tìm thấy giáo viên có mã này.");
    }
    public void ModifyTeacher()
    {
        Console.Write("Nhập mã giáo viên cần sửa: ");
        string maGV = Console.ReadLine();
        for (int i = 0; i < tc.Count; i++)
        {
            if (maGV.Equals(tc[i].Ma, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Nhập thông tin mới: ");
                tc[i].InputInfo();
                return;
            }
        }
        Console.WriteLine("Không tìm thấy giáo viên có mã này.");
    }
    public void DeleteTeacher()
    {
        Console.Write("Nhập mã giáo viên cần xóa: ");
        string maGV = Console.ReadLine();
        for (int i = 0; i < tc.Count; i++)
        {
            if (maGV.Equals(tc[i].Ma, StringComparison.OrdinalIgnoreCase))
            {
                tc.RemoveAt(i);
                Console.WriteLine("Xóa giáo viên thành công.");
                return;
            }
        }
        Console.WriteLine("Không tìm thấy giáo viên có mã này.");
    }
    public void Sort()
    {
        
    }
}