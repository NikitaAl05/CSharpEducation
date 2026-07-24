using Practice4.Task2;
using System.Threading;

namespace Practice.Task4.Exceptions;

class Program
{
    static void Main(string[] args)
    {
        ConsoleLogger logger = new ConsoleLogger();

        while (true)
        {
            try
            {
                Console.Write("Введите путь к файлу: ");
                string path = Console.ReadLine();
                
                using (StreamReader reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                    {
                        string fileLine = reader.ReadLine();
                        
                        int file = Convert.ToInt32(fileLine);
                        Console.WriteLine(fileLine);
                    }
                }
                
                Console.WriteLine("\n--- Файл успешно прочитан! ---");
                break; 
            }
            catch (FileNotFoundException ex)
            {
                logger.Error($"Файл не найден: {ex.Message}");
                Console.WriteLine("Ошибка: Указанный файл не существует. Попробуйте еще раз.\n");
            }
            catch (FormatException ex)
            {
                logger.Error($"В файле текст вместо чисел: {ex.Message}");
                Console.WriteLine("Ошибка: В файле должны быть только числа. Исправьте файл и попробуйте снова.\n");
            }
            catch (IOException ex)
            {
                logger.Error($"Файл заблокирован: {ex.Message}");
                Console.WriteLine("Ошибка: Файл открыт в другой программе. Ждем 3 секунды...\n");
                
                Thread.Sleep(3000); 
            }
        }

        Console.ReadLine();
    }
}