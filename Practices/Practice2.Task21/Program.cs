namespace Practice2.Task21;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int target = rand.Next(1, 10);
        
        int Guess = 0;
        
        Console.WriteLine("Угадай число от 1 до 100. Попробуй угадать!\n");

        while (Guess != target)
        {
            Console.Write("\nТвой вариант: ");
            if (int.TryParse(Console.ReadLine(), out Guess))
            {
                if (Guess == target)
                {
                    Console.WriteLine("Поздравляю! Ты угадал число!");
                }
                else
                {
                    Console.WriteLine("Не угадал, попробуй еще раз!");
                }
            }
        }
    }
}