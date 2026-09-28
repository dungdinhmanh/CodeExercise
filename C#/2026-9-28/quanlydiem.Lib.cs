using System.Text;

class PM //PM - Point Management
{
    public string maSV;
    public string hoten;
    public string monhoc;
    public double diem; 
    public PM (string maSV, string hoten, string monhoc, double diem)
    {
        this.maSV = maSV;
        this.hoten = hoten;
        this.monhoc = monhoc;
        this.diem = diem;
    }
    public void Output()
    {
        Console.WriteLine($"Thông tin học sinh:\n- Mã sinh viên: {maSV}\n- Họ tên: {hoten}\n- Môn học: {monhoc}\n- Điểm: {diem}\n- Xếp loại: {Ranking()}");
    }
    public string Ranking()
    {
        if(diem >= 9) return "Xuất sắc";
        else if (diem >= 8) return "Giỏi";
        else if (diem >= 7) return "Khá";
        else if (diem >= 5) return "Trung bình";
        else return "Yếu";
    }
}