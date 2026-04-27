namespace Practice3.Task11;

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book("Title","None");
        Console.WriteLine(book.GetInfo(book));
    }
}