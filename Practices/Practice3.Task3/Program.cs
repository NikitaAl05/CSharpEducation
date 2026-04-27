namespace Practice3.Task3;

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        Console.WriteLine(calc.sum(2,5));
        Console.WriteLine(calc.sub(10,5));
        Console.WriteLine(calc.mult(2,5));
        Console.WriteLine(calc.div(4,2));
    }
}