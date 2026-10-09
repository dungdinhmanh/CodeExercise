class Student : IStudent
{
    public int ID {get;set;}
    public string Name {get;set;}
    public string Lop {get;set;}
    public string Hometown {get;set;}
    public string Birthday {get;set;}
    public string PhoneNum {get;set;}

    public Student() { }
    public Student(int id, string name, string lop, string hometown, string birthday, string phonenum)
    {
        ID = id;
        Name = name;
        Lop = lop;
        Hometown = hometown;
        Birthday = birthday;
        PhoneNum = phonenum;
    }

    public void Output()
    {
        Console.WriteLine($"{ID, -10}{Name, -30}{Class, -25}{Hometown, -30}{Birthday, -20}{PhoneNum, -15}");
    }
}