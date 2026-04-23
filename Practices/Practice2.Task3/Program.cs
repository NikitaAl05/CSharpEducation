namespace Practice2.Task3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значения для вычисления выражения");
        Console.WriteLine("(a + b - f / a) + f * a * a - (a + b)");
        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("f: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double result = Math.Round(Expression(a, b, c), 2);
        Console.WriteLine($"Итого: {result}");
    }
    public static double Expression(double a, double b, double f)
    {
        return (a + b - f / a) + f * a * a - (a + b);
    }
}