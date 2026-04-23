namespace Practice2.Task8;

class Program
{
    static void Main(string[] args)
    {
        int a = Int32.Parse(Console.ReadLine());
        int b = Int32.Parse(Console.ReadLine());
        int c = Int32.Parse(Console.ReadLine());

        if (a == b || b == c || a == c)
        {
            Console.WriteLine($"{a + 5} {b + 5} {c + 5}");
        }
        else
        {
            Console.WriteLine("равных нет");
        }
        
    }  
}