namespace Practice2.Task6;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        A();
        Console.WriteLine("-----------------------------------------");
        B();
        Console.WriteLine("-----------------------------------------");
        C(args);
    }

    public static void A()
    {
        string str = "Првиет, как дела меня зовут Никита мне 10 лет. Я хожу в зал и ем протеин.";
        Console.WriteLine($"Текст: {str}");
        char ch = 'и';
        Console.WriteLine($"Символ: {ch}");

        int count = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ch)
            {
                count++;
            }
        }
        double result = ((double)count * 100) / str.Length;
        result = Math.Round(result, 1);
        Console.WriteLine($"Процент вхождения символа равен: {result}%"); 
    }
    public static void B()
    {
        Console.Write("Введите текст: ");
        string str = Console.ReadLine();
        
        Console.Write("Введите символ который надо найти: ");
        char ch = Convert.ToChar(Console.ReadLine());
        
        int count = 0;
        foreach (char c in str)
        {
            if (ch == c)
            {
                count++;
            }
        }
        double result = ((double)count * 100) / str.Length;
        result = Math.Round(result, 1);
        Console.WriteLine($"Процент вхождения символа равен: {result}%");    
    }
    public static void C(string[] args)
    {
        string str = args[0];
        Console.WriteLine($"Текст: {str}");
        char ch = args[1][0];
        Console.WriteLine($"Символ: {ch}");
        
        int count = 0;
        foreach (char c in str)
        {
            if (ch == c)
            {
                count++;
            }
        }
        double result = ((double)count * 100) / str.Length;
        result = Math.Round(result, 1);
        Console.WriteLine($"Процент вхождения символа равен: {result}%");  
    }
}