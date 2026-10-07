using System;
using System.Text;

class Program
{
  static void Main(string[] args)
  {
    Console.OutputEncoding = Encoding.UTF8;
    Console.WriteLine("Chương trình quản lý giáo viên");
    TeacherTest teacherTest = new TeacherTest();
    int choice;
    do
    {
      Console.WriteLine("\nMenu:");
      Console.WriteLine("1. Nhập danh sách giáo viên");
      Console.WriteLine("2. Thêm giáo viên");
      Console.WriteLine("3. Sửa thông tin giáo viên");
      Console.WriteLine("4. Xóa giáo viên");
      Console.WriteLine("5. Hiển thị danh sách giáo viên");
      Console.WriteLine("6. Tính lương giáo viên");
      Console.WriteLine("0. Thoát");
      Console.Write("Chọn chức năng: ");
      ichoice = int.Parse(Console.ReadLine());
      switch (choice)
      {
        case 1:
          teacherTest.InputList();
          break;
        case 2:
          teacherTest.AddTeacher();
          break;
        case 3:
          teacherTest.ModifyTeacher("");
          break;
        case 4:
          teacherTest.DeleteTeacher("");
          break;
        case 5:
          Console.WriteLine($"{"Mã",-10}{"Họ tên",-20}{"Giới tính",-10}{"Ngày sinh",-15}{"Địa chỉ",-30}{"Lớp dạy",-20}{"Số giờ",-15}{"Lương giờ",-20}");
          foreach (Teacher t in teacherTest.tc)
          {
            t.ShowInfo();
          }
          break;
        case 6:
          foreach (Teacher t in teacherTest.tc)
          {
            int luong = t.TinhLuong();
            Console.WriteLine($"Mã: {t.ma}, Họ tên: {t.hoten}, Lương: {luong}");
          }
          break;
        case 0:
          return;
        default:
          Console.WriteLine("Chức năng không hợp lệ. Vui lòng chọn lại.");
          break;
      }
    } while (choice != 0);
  }
}
