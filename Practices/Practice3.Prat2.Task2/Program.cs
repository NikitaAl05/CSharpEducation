
using Practice3.Prat2.Task1;

namespace Practice3.Prat2.Task2;

class Program
{
    static void Main(string[] args)
    {
        var calc = new MathHelper();

        Console.WriteLine(calc.Sum(1, 2));
        Console.WriteLine(calc.Sub(1, 2));
        Console.WriteLine(calc.Mul(1, 2));
        Console.WriteLine(calc.Div(1, 2));
    }
}