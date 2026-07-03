namespace Practice4.Part2.Task1;

public class Circle : Shape
{
    private double radius;
    
    public Circle(double radius) { this.radius = radius; }
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}