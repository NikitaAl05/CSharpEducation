namespace Practice3.Task6;

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point(1,3);
        Point p2 = new Point(1,4);

        double dist = p1.Distance(p2);
        Console.WriteLine($"Расстояние: {dist}");
    }
}