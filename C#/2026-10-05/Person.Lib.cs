class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
    public Person()
    {
        Name = "Nguyễn Hải An";
    }
    public void Output(){
        Console.WriteLine("Tên: " + Name);
    }
}