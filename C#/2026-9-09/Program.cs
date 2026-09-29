using System.Text;
Console.OutputEncoding = Encoding.UTF8;
Console.Write("Nhập số từ 2-8: ");
int n;
n = Convert.ToInt32(Console.ReadKey());
switch (n)
{
    case 2: Console.WriteLine("Thứ hai"); break;
    case 3: Console.WriteLine("Thứ ba"); break;
    case 4: Console.WriteLine("Thứ tư"); break;
    case 5: Console.WriteLine("Thứ năm"); break;
    case 6: Console.WriteLine("Thứ sáu"); break;
    case 7: Console.WriteLine("Thứ bảy"); break;
    case 8: Console.WriteLine("Chủ nhật"); break;
    default: Console.WriteLine("Giá trị đầu vào sai."); break;
}