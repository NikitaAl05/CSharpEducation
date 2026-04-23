namespace Practice2.Task2;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("--- Конвертер Длины ---");
            Console.WriteLine("a. метры в километры\n" +
                              "b. километры в сантиметры\n" +
                              "c. м/с в км/ч\n" +
                              "d. градусы C в градусы F");

            if (char.TryParse(Console.ReadLine(), out char choice))
            {
                if (choice == 'a' || choice == 'A')
                {
                    Console.Write("Метры: ");
                    double input = Convert.ToDouble(Console.ReadLine());
                    double result = input / 1000;
                    Console.WriteLine($"Километры: {result}");
                }
                else if (choice == 'b' || choice == 'B')
                {
                    Console.Write("Километры: ");
                    int input = Convert.ToInt32(Console.ReadLine());
                    double result = input * 100000;
                    Console.WriteLine($"Сантиметры: {result}");
                }
                else if (choice == 'c' || choice == 'C')
                {
                    Console.Write("м/с: ");
                    double input = Convert.ToDouble(Console.ReadLine());
                    double result = input * 3.6;
                    Console.WriteLine($"км/ч: {result}");
                }
                else if (choice == 'd' || choice == 'D')
                {
                    Console.Write("Градусы С: ");
                    double input = Convert.ToDouble(Console.ReadLine());
                    double result = (input * 1.8) + 32;
                    Console.WriteLine($"Градусы F: {result}");
                }
            }
            Console.WriteLine("Нажмите [Enter] чтоб продолжить");
            Console.ReadKey();
        }
    }
}