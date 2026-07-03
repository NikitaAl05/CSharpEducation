namespace Practice4.Part2.Task7;

public class Triangle : Shape
{
    public double A { get; }
    public double H { get; }
    
    public Triangle(double a, double h) { A = a; H = h; }
    
    public override void CalculateArea()
    {
        Area = 0.5 * (A * H);
    }
}