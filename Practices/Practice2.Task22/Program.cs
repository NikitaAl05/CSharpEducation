namespace Practice2.Task22;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int target = rand.Next(1, 101);
        
        int Guess = 0;
        int attempts = 0;
        
        Console.WriteLine("Угадай число от 1 до 100. Попробуй угадать!\n");

        while (Guess != target && attempts < 10)
        {
            Console.Write($"Попытка {attempts + 1}. Твой вариант: ");
            if (int.TryParse(Console.ReadLine(), out Guess))
            {
                attempts++;

                if (Guess > target)
                {   
                    Console.WriteLine("Меньше");
                }else if (Guess < target)
                {
                    Console.WriteLine("Больше");
                }
            }
        }
        
        if (Guess == target)
        {
            Console.WriteLine($"\nПОЗДРАВЛЯЮ!! Ты угадал число за {attempts} попыток!");
        }
        else
        {
            Console.WriteLine($"\nТы проиграл." +
                              $"\nПопытки закончились. Было загадано: {target}");
        }
    }
}