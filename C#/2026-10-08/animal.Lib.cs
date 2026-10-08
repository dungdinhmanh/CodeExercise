abstract class Animal
{
    public string Name {get;set;}
    public int Age {get;set;}
    public string Description {get;set;}
    public abstract void ShowInfo();
    public abstract void Sound();
    public abstract void Input();
    public Animal() { }
    public Animal(string name, int age, string desc)
    {
        Name = name;
        Age = age;
        Description = desc;
    }
}