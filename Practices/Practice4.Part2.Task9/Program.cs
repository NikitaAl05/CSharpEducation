namespace Practice4.Part2.Task9;

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person { Name = "Nikita", Age = 23 };
        Person person2 = new Person { Name = "Nikita", Age = 23 };
        
        Person person3 = new Person { Name = "Lexi", Age = 2 };
        
        Console.WriteLine("--- ToString ---");
        Console.WriteLine(person1);
        Console.WriteLine(person2);
        Console.WriteLine(person3);
        Console.WriteLine();
        
        Console.WriteLine("--- Equals ---");
        Console.WriteLine($"person1 равен person2? {person1.Equals(person2)}"); 
        Console.WriteLine($"person1 равен person3? {person1.Equals(person3)}");
        Console.WriteLine();
        
        Console.WriteLine("--- GetHashCode ---");
        Console.WriteLine($"Хэш-код person1: {person1.GetHashCode()}");
        Console.WriteLine($"Хэш-код person2: {person2.GetHashCode()}");
        Console.WriteLine($"Хэш-код person3: {person3.GetHashCode()}");
        
        
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString() => $"Имя: {Name}, Возраст: {Age}";
    public override bool Equals(object? obj)
    {
        if (obj is Person other)
        {
            return Name == other.Name && Age == other.Age;
        }
        return false;
    }
    public override int GetHashCode() => HashCode.Combine(Name, Age);
}