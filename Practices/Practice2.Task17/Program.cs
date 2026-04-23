namespace Practice2.Task17;

class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("==============================");
        Console.WriteLine("     ДО ОБМЕНА:");
        Console.WriteLine($"     a = [{a}]  b = [{b}]");
        Console.WriteLine("==============================");

        Swap(ref a, ref b);

        Console.WriteLine("     ПОСЛЕ ОБМЕНА:");
        Console.WriteLine($"     a = [{a}]  b = [{b}]");
        Console.WriteLine("==============================");
    }
    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}