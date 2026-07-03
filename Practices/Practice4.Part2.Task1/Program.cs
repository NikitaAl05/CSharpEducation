namespace Practice4.Part2.Task1;

class Program
{
    static void Main(string[] args)
    {
        Shape circle = new Circle(2);
        Shape rectangle = new Rectangle(2,3);

        Console.WriteLine(circle.CalculateArea());
        Console.WriteLine(rectangle.CalculateArea());
    }
}