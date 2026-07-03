namespace Practice4.Part2.Task7;

class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = new Shape[]
        {
            new Rectangle(2, 2),
            new Circle(3),
            new Triangle(4, 5),
        };

        foreach (var shape in shapes)
        {
            shape.CalculateArea();
            Console.WriteLine($"Площадь фигуры {shape.GetType().Name} = {shape.Area:F2}");
        }
    }
}