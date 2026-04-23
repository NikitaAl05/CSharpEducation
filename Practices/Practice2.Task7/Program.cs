namespace Practice2.Task7;

class Program
{
    static void Main(string[] args)
    {
        A();
        Console.WriteLine("------------------");
        B();
        Console.WriteLine("------------------");
        C();
    }
    public static void A()
    {
        string str = "привет мир!";
        Console.WriteLine($"A. Текст: {str}");
        str = str.ToUpper();
        Console.WriteLine($"Измененный: {str}");
    }
    public static void B()
    {
        string str = "ПРИВЕТ МИР!";
        Console.WriteLine($"B. Текст: {str}");
        str = str.ToLower();
        Console.WriteLine($"Измененный: {str}");
    }
    public static void C()
    {
        string str = "привет мир!";
        Console.WriteLine($"C. Текст: {str}");
        string result = char.ToUpper(str[0]) + str.Substring(1);
        Console.WriteLine($"Измененный: {result}");
    }
}