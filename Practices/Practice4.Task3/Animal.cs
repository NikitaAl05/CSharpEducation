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

public class Dog : Animal
{
    public Dog(string name, int age) : base(name, age)
    {
        Console.WriteLine($"--- Создана собака имени {name} ---");
    }
    public override string MakeSound() => "Woof!";
}

public class Cat : Animal
{
    public Cat(string name, int age) : base(name, age)
    {
        Console.WriteLine($"--- Создана кошка по имени {name} --- ");
    }
    public override string MakeSound() => "Meow!";
}

public class Parrot : Animal, IFlyable
{
    public string Color;

    public Parrot(string name, int age, string color) : base(name, age)
    {
        this.Color = color;
    }
    
    public new string MakeSound() => "Parrot is talking";

    public string MakeSound(string words)
    {
        return words;
    }

    public string Fly() => "Parrot is flying";
}

public interface IFlyable
{
    public string Fly();
}

public class Eagle : IFlyable
{
    public string Fly() => "Eagle is soaring high";
}