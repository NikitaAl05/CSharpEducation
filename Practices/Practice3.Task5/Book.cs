using System.Text;

namespace Practice3.Task5;

class Book
{
    private string name;
    private string author;
    private int yearPublisher;

    public string Name
    {
        get => name;
        set { name = value; }
    }

    public string Author
    {
        get => author;
        set { author = value; }
    }

    public int YearPublisher
    {
        get => yearPublisher;
        set { yearPublisher = value; }
    }

    public Book()
    {
        Name = "Джентльмены";
        Author = "Гай Ричи";
        YearPublisher = 2000;
    }
    public Book(string name) : this(name, "Неизвестно", 1999) {}
    public Book(string name,  string author) : this(name, author, 2000) { }
    public Book(string name, string author,  int yearPublisher)
    {
        Name = name;
        Author = author;
        YearPublisher = yearPublisher;
    }
    
    public string GetInfo()
    {
        var info = new StringBuilder();
        info.AppendLine($"Название: {Name}");
        info.AppendLine($"Автор: {Author}");
        info.AppendLine($"Год публикации: {YearPublisher}");
        
        return info.ToString();
    }
}