namespace Practice4.Part2.Task11;

class Program
{
    static void Main(string[] args)
    {
        int x = 20;
        int y = 40;
        
        Console.WriteLine($"До обмена: x = {x}, y = {y}");
        Swap(ref x, ref y);
        Console.WriteLine($"После обмена: x = {x}, y = {y}");

        string a = "Спал";
        string b = "Опосум";

        Console.WriteLine($"До обмен: a = {a}, b = {b}");
        Swap(ref a, ref b);
        Console.WriteLine($"До обмен: a = {a}, b = {b}");
    }

    static public void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}
