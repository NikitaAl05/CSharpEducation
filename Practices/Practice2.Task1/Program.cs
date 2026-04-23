namespace Practice2.Task1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("For: ");
        for (int i = 0; i <= 5; i++)
        {
            Console.Write($"{i} ");
        }
        
        Console.Write("\nWhile: ");
        int count = 0;
        while (count <= 5)
        {
            Console.Write($"{count} " );
            count++;
        }

        Console.Write("\ndo-while: ");
        int count1 = 0;
        do
        {
            count1++;
            Console.Write($"{count1} ");
        } while (count1 <= 5);
        
        Console.WriteLine("\n------- forInput -------");
        forInput();
        Console.WriteLine("------- whileInput -------");
        whileInput();
        Console.WriteLine("------- doWhileInput -------");
        doWhileInput();
    }

    public static void forInput()
    {
        string input = "";
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Введите слово: ");
            string str = Console.ReadLine();
            input += str + " ";
        }
        Console.WriteLine(input);
    }

    public static void whileInput()
    {
        int count = 0;
        string input = "";
        while (count < 3)
        {
            count++;
            Console.Write("Введите слово: ");
            string str = Console.ReadLine();
            input += str + " ";
        }
        Console.WriteLine(input);
    }

    public static void doWhileInput()
    {
        int count = 0;
        string input = "";
        do
        {
            count++;
            Console.Write("Введите слово: ");
            string str = Console.ReadLine();
            input += str + " ";
        }while (count < 3);
        Console.WriteLine(input);
    }
}