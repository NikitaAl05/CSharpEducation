namespace Practice3.Task11;

class Book
{
    private string name;
    private string author;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public Book(string name, string author)
    {
        Name = name;
        Author = author;
    }

    public string GetInfo(Book book)
    {
        return $"{book.Name} - {book.Author}";
    }
}