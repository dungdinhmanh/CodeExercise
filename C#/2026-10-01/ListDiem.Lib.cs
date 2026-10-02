class ListSV
{
    private readonly List<SVMG> listSV = new List<SVMG>();

    public void Add()
    {
        Console.Write("Nhập số lượng sinh viên: ");
        int n = int.TryParse(Console.ReadLine(), out int result) ? result : 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập thông tin sinh viên thứ {i + 1}:");
            SVMG sv = new SVMG();
            sv.Input();
            listSV.Add(sv);
        }
    }

    public void AddSV()
    {
        SVMG sv = new SVMG();
        sv.Input();
        listSV.Add(sv);
    }

    public void Search()
    {
        Console.Write("Nhập mã sinh viên cần tìm: ");
        string maSV = Console.ReadLine() ?? string.Empty;

        foreach (SVMG sv in listSV)
        {
            if (sv.MaSV == maSV)
            {
                sv.OutputInfo();
                return;
            }
        }

        Console.WriteLine("Không tìm thấy sinh viên với mã sinh viên đó.");
    }

    public void RemoveSV()
    {
        Console.Write("Nhập mã sinh viên cần xóa: ");
        string maSV = Console.ReadLine() ?? string.Empty;

        for (int i = 0; i < listSV.Count; i++)
        {
            if (listSV[i].MaSV == maSV)
            {
                listSV.RemoveAt(i);
                Console.WriteLine("Xóa sinh viên thành công.");
                return;
            }
        }

        Console.WriteLine("Không tìm thấy sinh viên với mã sinh viên đó.");
    }

    public void Sort()
    {
        for (int i = 0; i < listSV.Count - 1; i++)
        {
            for (int j = i + 1; j < listSV.Count; j++)
            {
                if (listSV[i].Final() < listSV[j].Final())
                {
                    SVMG temp = listSV[i];
                    listSV[i] = listSV[j];
                    listSV[j] = temp;
                }
            }
        }
    }

    public void Output()
    {
        Console.WriteLine("Mã sinh viên".PadRight(20) + "Tên sinh viên".PadRight(30) + "Tên môn học".PadRight(30) + "Điểm hệ số 1".PadRight(15) + "Điểm hệ số 2".PadRight(15) + "Điểm hệ số 2 lần 2".PadRight(15) + "Điểm trung bình".PadRight(15) + "Điểm thi".PadRight(15) + "Điểm tổng kết".PadRight(15) + "Xếp loại");

        foreach (SVMG sv in listSV)
        {
            sv.OutputInfo();
        }
    }
}