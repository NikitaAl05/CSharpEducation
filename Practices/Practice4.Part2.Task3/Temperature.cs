namespace Practice4.Part2.Task3;

public class Temperature
{
    public double Celsius { get; }

    public Temperature(double celcies) { Celsius = celcies; }

    public static implicit operator double(Temperature temp)
    {
        return temp.Celsius * 1.8 + 32;
    }

    public static explicit operator Temperature(double fahrenheit)
    {
        return new Temperature((fahrenheit - 32) / 1.8);
    }
    
}
