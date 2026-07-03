namespace Practice4.Task3;

public class Dog : Animal
{
    public Dog(string name, int age) : base(name, age)
    {
        Console.WriteLine($"--- Создана собака имени {name} ---");
    }
    public override string MakeSound() => "Woof!";
}