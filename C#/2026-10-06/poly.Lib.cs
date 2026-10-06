class Student
{
    //tạo các thuộc tính private name và age, cùng với các phương thức getter và setter để truy cập chúng. Ngoài ra, lớp Student cũng có ba constructor khác nhau để khởi tạo đối tượng với các thông tin khác nhau, và một phương thức ShowInfo để hiển thị thông tin của sinh viên.
    private string name;
    private int age;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    //tạo các constructor khác nhau để khởi tạo đối tượng với các thông tin khác nhau
    public Student() { }
    public Student(string name)
    {
        this.name = "John Doe";
    }
    public Student(string name, int age)
    {
        this.name = "Alice Johnson";
        this.age = 19;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}