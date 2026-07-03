namespace Practice4.Part2.Task8;

class Program
{
    static void Main(string[] args)
    {
        Vehicle[] vehicles = new Vehicle[]
        {
            new Car(),
            new Bicycle(),
            new Airplane()
        };

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle.Move());
        }
    }
}