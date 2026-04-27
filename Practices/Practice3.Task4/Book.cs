using System.Text;

namespace Practice3.Task4;

class Book
{
    private string name;
    private string author;

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

    public Book()
    {
        Name = "Джентльмены";
        Author = "Гай Ричи";
    }
    public Book(string name, string author)
    {
        Name = name;
        Author = author;
    }
    public string GetInfo()
    {
        var info = new StringBuilder();
        info.AppendLine($"Name: {Name}");
        info.AppendLine($"Author: {Author}");
        
        return info.ToString();
    }
    
}