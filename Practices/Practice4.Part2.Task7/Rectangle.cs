namespace Practice4.Part2.Task7;

public class Rectangle : Shape
{
    public double A { get; }
    public double B { get; }
    
    public Rectangle(double a, double b){ A = a; B = b; }
    
    public override void CalculateArea()
    {
        Area = A * B;
    }
}