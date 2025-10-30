namespace test;

static class PointExtension
{
    public static double DistanceBetween(this Point p1, Point p2)
    {
        double deltaX = p1.X - p2.X;
        double deltaY = p1.Y - p2.Y;
        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }
}