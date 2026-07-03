namespace Practice4.Part2.Task4;

class Program
{
    static void Main(string[] args)
    {
        Distance distance = new Distance(1500);

        double km = distance;
        Console.WriteLine(km + " км");

        double dKM = 4.2;
        Distance distance2 = (Distance)dKM;
        Console.WriteLine(distance2.Length + " м");

    }
}