namespace Practice3.Task8;

struct Rectangle
{
    private double widht;
    private double height;

    public double Widht
    {
        get => widht;
        set { widht = value; }
    }
    public double Height
    {
        get => height;
        set { height = value; }
    }

    public Rectangle(double width, double height)
    {
        Widht = width;
        Height = height;
    }

    public double Square()
    {
        return Widht * Height;
    }
}