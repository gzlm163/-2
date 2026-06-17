public class CloneClass
{
    public int X { get; set; }
    public int Y { get; set; }
    public DeepStructure Data { get; set; }

    public CloneClass()
    {
        Data = new DeepStructure();
    }

    public override string ToString()
    {
        return $"{X} {Y} {Data.A} {Data.B} {Data.GetHashCode()}";
    }
}