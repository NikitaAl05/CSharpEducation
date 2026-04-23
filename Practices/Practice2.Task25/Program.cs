namespace Practice2.Task25;

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
        Console.Write("Введите число от 1 до 7: ");
        int input = Convert.ToInt32(Console.ReadLine());

        WeekDay day = input switch
        {
            1 => WeekDay.Monday,
            2 => WeekDay.Tuesday,
            3 => WeekDay.Wednesday,
            4 => WeekDay.Thursday,
            5 => WeekDay.Friday,
            6 => WeekDay.Saturday,
            7 => WeekDay.Sunday,
            _ => throw new ArgumentException("Ошибка: нужно число от 1 до 7")
        };

        Console.WriteLine(day);
    }
}