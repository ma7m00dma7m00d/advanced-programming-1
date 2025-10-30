namespace test;

struct Point
{

    public double X { get; }
    public double Y { get; }

    public Point(double x, double y)
    {
        this.X = x;
        this.Y = y;
    }

    public override string ToString() => $"x= {X}, y= {Y}";
}





