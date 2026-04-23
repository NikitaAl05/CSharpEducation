namespace Practice2.Task4;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите длину треугольник: ");
        int length = int.Parse(Console.ReadLine());
        
        Console.Write("Введите символ для отрисовки: ");
        char a = Convert.ToChar(Console.ReadLine());
        
        for (int i = 1; i <= length; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(a);
            }
            Console.WriteLine();
        }
        
        Console.WriteLine(" ");
        
        for (int i = length; i >= 0; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(a);
            }
            Console.WriteLine();
        }
    }
}