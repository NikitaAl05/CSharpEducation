namespace Practice4.Task3;

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();
        IFlyable[] flyers = new IFlyable[]
        {
            new Parrot("Popyg", 12, "Red"),
            new Eagle()
        };
        Console.WriteLine("-------- Кто летчик ---------");
        foreach (IFlyable fly in flyers)
        {
            Console.WriteLine(fly.Fly());
        }
        Console.WriteLine("-----------------------------\n");
        animals.Add(new Animal("Maik", 2));
        animals.Add(new Dog("Lexi", 3));
        animals.Add(new Cat("Simon", 4));
        animals.Add(new Parrot("Parrot", 5, "Red"));

        foreach (Animal animal in animals)
        {
            if (animal is Parrot parrot)
            {
                Console.WriteLine($"-- Попугай --\nИмя: {parrot.Name}, Цвет: {parrot.Color}, Возраст: {parrot.Age} лет");
                Console.WriteLine(parrot.MakeSound());
                Console.WriteLine(parrot.MakeSound("Hello World?"));
            }
            else if (animal is Dog dog)
            {
                Console.WriteLine($"-- Собака --\nИмя: {dog.Name}, Возраст: {dog.Age} года");
                Console.WriteLine(dog.MakeSound());
            }
            else if (animal is Cat cat)
            {
                Console.WriteLine($"-- Кошка --\nИмя: {cat.Name}, Возраст: {cat.Age} года");
                Console.WriteLine(cat.MakeSound());
            }
            else
            {
                Console.WriteLine($"\n-- Animals --\nИмя: {animal.Name}, Возраст: {animal.Age} года");
                Console.WriteLine(animal.MakeSound());
            }

            animal.Eat();
            animal.Sleep();
            Console.WriteLine("------------------");
        }

    }
}