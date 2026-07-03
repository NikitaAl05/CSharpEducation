namespace Practice4.Part2.Task2;

class Program
{
    static void Main(string[] args)
    {
        Animal dog = new Dog();
        Animal cat = new Cat();
        
        Console.WriteLine(dog.MakeSound());
        Console.WriteLine(cat.MakeSound());
    }
}