namespace Practice4.Part2.Task7;

public class Circle : Shape
{
    public double Radius { get; }
    
    public Circle(double r) { Radius = r; }
    
    public override void CalculateArea()
    {
        Area = Math.PI * (Radius * Radius);
    }
}