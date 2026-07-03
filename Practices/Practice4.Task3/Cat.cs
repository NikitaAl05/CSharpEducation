namespace Practice4.Task3;

public class Cat : Animal
{
    public Cat(string name, int age) : base(name, age)
    {
        Console.WriteLine($"--- Создана кошка по имени {name} --- ");
    }
    public override string MakeSound() => "Meow!";
}