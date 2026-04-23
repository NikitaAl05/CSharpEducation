namespace Practice2.Task16;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-- Реверс знака --");
        int num = 5;
        Console.WriteLine($"Было: {num}");
        ReverseSign(ref num);
        Console.WriteLine($"Стало: {num}");
    }
    public static void ReverseSign(ref int number)
    {
        number = -number;
    }
}