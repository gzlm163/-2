using System;

internal class Program
{
    static void Main(string[] args)
    {
        Point original = new Point(5, 10);
        Point clone = (Point)original.Clone();

        Console.WriteLine("Original: " + original.ToString());
        Console.WriteLine("Clone:    " + clone.ToString());

        clone.X = 99;
        clone.Y = 99;

        Console.WriteLine("\nAfter changing clone:");
        Console.WriteLine("Original: " + original.ToString());
        Console.WriteLine("Clone:    " + clone.ToString());

        Console.ReadKey();
    }
}