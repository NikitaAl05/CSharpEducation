namespace Practice3.Task4;

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book();
        Book Book2 = new Book("Неизвестно", "Неизвестно");
        Console.WriteLine(book.GetInfo());
        Console.WriteLine(Book2.GetInfo());
    }
}