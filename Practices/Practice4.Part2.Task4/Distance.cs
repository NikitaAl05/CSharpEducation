namespace Practice4.Part2.Task4;

public class Distance
{
    public double Length { get; set; } // метры

    public Distance(double length) { Length = length; }
    
    public static implicit operator double(Distance d) => d.Length / 1000;
    public static explicit operator Distance(double km) => new Distance(km * 1000);
}