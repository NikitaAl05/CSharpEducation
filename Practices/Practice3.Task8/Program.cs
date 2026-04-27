namespace Practice3.Task8;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(3, 5);
        double s = rectangle.Square();
        Console.WriteLine(s);
    }
}