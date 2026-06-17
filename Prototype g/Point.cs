public class Point
{
    public string Name { get; set; }
    public Coordinates Position { get; set; }

    public Point(string name, int x, int y)
    {
        Name = name;
        Position = new Coordinates(x, y);
    }

    public Point DeepClone()
    {
        Point clone = new Point(this.Name, this.Position.X, this.Position.Y);
        return clone;
    }

    public override string ToString()
    {
        return $"{Name}: ({Position.X}, {Position.Y})";
    }
}
