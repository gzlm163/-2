public class Point : IPrototype
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public IPrototype Clone()
    {
        return new Point(this.X, this.Y);
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}