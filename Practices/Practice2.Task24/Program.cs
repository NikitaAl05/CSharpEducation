namespace Practice2.Task24;

public enum WeekDay
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class Program
{
    static void Main(string[] args)
    { 
        foreach (WeekDay day in Enum.GetValues(typeof(WeekDay)))
        {
            Console.WriteLine(day);
        }
    }
}