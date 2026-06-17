using System;

internal class Program
{
    static void Main(string[] args)
    {
        ShallowCloneClass shallowOriginal = new ShallowCloneClass();
        shallowOriginal.X = 1;
        shallowOriginal.Y = 2;
        shallowOriginal.Data.A = 3;
        shallowOriginal.Data.B = 4;

        ShallowCloneClass shallowClone = (ShallowCloneClass)shallowOriginal.Clone();

        Console.WriteLine(shallowOriginal.ToString());
        Console.WriteLine(shallowClone.ToString());

        DeepCloneClass deepOriginal = new DeepCloneClass();
        deepOriginal.X = 1;
        deepOriginal.Y = 2;
        deepOriginal.Data.A = 3;
        deepOriginal.Data.B = 4;

        DeepCloneClass deepClone = (DeepCloneClass)deepOriginal.Clone();

        Console.WriteLine(deepOriginal.ToString());
        Console.WriteLine(deepClone.ToString());

        Console.ReadKey();
    }
}