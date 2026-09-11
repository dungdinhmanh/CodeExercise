int a;
Console.Write("Nhập a=");
a= Convert.ToInt32(Console.ReadLine());
switch(a)
{
    case 1:
    case 2: Console.WriteLine("yes");break;
    case 3: Console.WriteLine("no");break;
    default: Console.WriteLine("Tạm biệt"); break;
} 
