namespace Practice4.Task3;

public class Animal
{
    public string Name;
    public int Age;

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    public void Eat() => Console.WriteLine($"{Name} is eating");
    public void Sleep() => Console.WriteLine($"{Name} is sleeping");
    
    public virtual string MakeSound() => "Some generic animal sound";
}