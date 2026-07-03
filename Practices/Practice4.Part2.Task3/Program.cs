namespace Practice4.Part2.Task3;

class Program
{
    static void Main(string[] args)
    {
        Temperature temp = new Temperature(20);

        double fahrenheit = temp;
        Console.WriteLine(fahrenheit);
        
        double tempFahrenheit = 111.0;
        Temperature temp2 = (Temperature)tempFahrenheit;
        
        Console.WriteLine(temp2.Celsius);
        
        
    }
}