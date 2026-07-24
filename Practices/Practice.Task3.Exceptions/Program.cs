using Practice4.Task2;

namespace Practice.Task3.Exceptions;

class Program
{
    static void Main(string[] args)
    {
        ConsoleLogger logger = new ConsoleLogger();
        AgeScreen ageScreen = new AgeScreen(logger);

        try
        {
            int attempts = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Сколько вам лет?");
                    int age = Convert.ToInt32(Console.ReadLine());
                    ageScreen.AgeVerification(age);
                    
                    break;
                }
                catch (UnderageException ex)
                {
                    throw new TooManyAttemptsException(ex.Message);
                }
                catch (Exception ex) when (ex is ArgumentOutOfRangeException || 
                                           ex is FormatException)
                {
                    attempts++;
                    
                    string errorText = ex is FormatException 
                        ? "Ошибка: Вводить нужно только числа!" 
                        : ex.Message;
                    
                    logger.Error(errorText);
                
                    logger.Info($"Предупреждение: Осталось попыток: {3 - attempts}");                
                    if (attempts >= 3)
                    {
                        throw new TooManyAttemptsException("Доступ заблокирован: превышено число попыток.");
                    }
                }
            }
            Console.WriteLine("\n--- Проверка пройдена! ---");
        }
        catch (TooManyAttemptsException ex)
        {
            logger.Error($"[КРЯ] {ex.Message}");
        }
        Console.ReadLine();
    }
}

public class AgeScreen
{
    protected readonly ConsoleLogger _logger;

    public AgeScreen(ConsoleLogger logger)
    {
        _logger = logger;
    }
    public void AgeVerification(int age)
    {
        if (age < 0 || age > 110)
        {
            _logger.Error($"Введен некорректный возраст: {age}");
            throw new ArgumentOutOfRangeException(nameof(age), "Неверный диапазон возраста.");
        }

        if (age < 18)
        {
            throw new UnderageException("Ошибка: Вам нет 18 лет!");
        }
        
        _logger.Info("Отлично! Ты уже взрослый!");
    }
}

public class UnderageException : Exception
{
    public UnderageException(string message) : base(message) {}
}

public class TooManyAttemptsException : Exception
{
    public TooManyAttemptsException(string message) : base(message) {}
}