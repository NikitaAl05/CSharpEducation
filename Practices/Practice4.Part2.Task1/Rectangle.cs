namespace Practice4.Part2.Task1;

public class Rectangle : Shape
{
    private int a;
    private int b;
    
    public Rectangle(int a, int b) { this.a = a; this.b = b; }
    public override double CalculateArea()
    {
        return a * b;
    }
}