namespace Practice3.Task5;

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book();
        Book book2 = new Book("Привет Мир!");
        Book book3 = new Book("Погода", "Погодин");
        Book book4 = new Book("с#", "Nikita", 2026);
        
        Console.WriteLine(book.GetInfo());
        Console.WriteLine(book2.GetInfo());
        Console.WriteLine(book3.GetInfo());
        Console.WriteLine(book4.GetInfo());
    }
}