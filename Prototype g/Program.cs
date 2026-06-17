using System;

internal class Program
{
    static void Main(string[] args)
    {
        Point original = new Point("A", 5, 10);
        Point clone = original.DeepClone();

        Console.WriteLine("Original: " + original);
        Console.WriteLine("Clone:    " + clone);

        clone.Position.X = 99;
        clone.Position.Y = 99;

        Console.WriteLine();
        Console.WriteLine("After changing clone:");
        Console.WriteLine("Original: " + original);
        Console.WriteLine("Clone:    " + clone);

        Console.ReadKey();
    }
}