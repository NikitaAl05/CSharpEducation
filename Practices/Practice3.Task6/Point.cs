namespace Practice3.Task6;

struct Point 
{
    private int x;
    private int y;
    public int X
    {
        get { return x; }
        set { x = value; }
    }
    public int Y
    {
        get { return y; }
        set { y = value; }
    }
    
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public double Distance(Point other)
    {
        int dX = X - other.X;
        int dY = Y - other.Y;
        return Math.Sqrt(dX * dX + dY * dY);
    }
}