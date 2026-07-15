using Practice4.Task2;

namespace Practice.Task1.Exceptions;

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

                string[] lines = File.ReadAllLines(path);

                int num1 = Convert.ToInt32(lines[0]);
                int num2 = Convert.ToInt32(lines[1]);

                int result = num1 / num2;
                Console.WriteLine(result);

                logger.Info("Расчет успешно выполнен!");
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
            catch (DivideByZeroException ex)
            {
                logger.Error($"Математическая ошибка: {ex.Message}");
                Console.WriteLine("Ошибка: На ноль делить нельзя! Исправьте число в файле и попробуйте еще раз.\n");
            }
            catch (IndexOutOfRangeException ex)
            {
                logger.Error($"Недостаточно данных в файле: {ex.Message}");
                Console.WriteLine("Ошибка: В файле должно быть как минимум два числа (каждое на новой строке).\n");
            }
            catch (IOException ex)
            {
                logger.Error($"Ошибка ввода-вывода (возможно файл поврежден): {ex.Message}");
                Console.WriteLine("Ошибка: Не удалось прочитать файл (он может быть поврежден).\n");
            }
        }
    }
}