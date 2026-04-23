namespace Practice2.Task5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Сравнение двух чисел ---");
        Console.Write("Певрое число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Второе число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine($"{num1} > {num2}");
        }
        else if(num1 == num2)
        {
            Console.WriteLine($"{num1} = {num2}");
        }
        else
        {
            Console.WriteLine($"{num1} < {num2}");
        }
        
    }
}