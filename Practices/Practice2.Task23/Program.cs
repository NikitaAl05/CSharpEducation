namespace Practice2.Task23;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите год: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year % 400 == 0)
        {
            Console.WriteLine("Високосный");
        }else if (year % 100 == 0)
        {
            Console.WriteLine("Не Високосный");
        }else if (year % 4 == 0)
        {
            Console.WriteLine("Високосный");
        }
        else
        {
            Console.WriteLine("Не Високосный");
        }
        
    }
}