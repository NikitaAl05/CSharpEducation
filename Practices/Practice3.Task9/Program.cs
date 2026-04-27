using System.Text;

namespace Practice3.Task9;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Nikita", 2);
        Console.WriteLine(student.GetInfo());
        student.Anonymize(student);
        Console.WriteLine(student.GetInfo());
    }
}