namespace Practice4.Part2.Task6;

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        Animal dog = new Dog();
        Animal cat = new Cat();

        Console.WriteLine(animal.Move());
        Console.WriteLine(dog.Move());
        Console.WriteLine(cat.Move());
    }
}