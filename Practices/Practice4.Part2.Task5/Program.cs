namespace Practice4.Part2.Task5;

class Program
{
    static void Main(string[] args)
    {
        Shape shape = new Shape();
        Shape rectangle = new Rectangle();
        Shape circle = new Circle();
        
        Console.WriteLine(shape.Draw());
        Console.WriteLine(rectangle.Draw());
        Console.WriteLine(circle.Draw());
    }
}