namespace Practice3.Task7;

class Program
{
    static void Main(string[] args)
    {
        int day = GetDaysInMonth(Month.January);
        Console.WriteLine(day);
        
    }
    public static int GetDaysInMonth(Month month)
    {
        return month switch
        {
            Month.January => 31,
            Month.February => 28,
            Month.March => 31,
            Month.April => 30,
            Month.May => 31,
            Month.June => 30,
            Month.July => 31,
            Month.August => 31,
            Month.September => 30,
            Month.October => 31,
            Month.November => 30,
            Month.December => 31,
            _ => throw new ArgumentException("Неизвестный месяц")
        };
    }
    
}

public enum Month
{
    December,
    January,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
}