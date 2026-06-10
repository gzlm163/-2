using System;

internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers = ArrayInput.ReadArrayFromConsole();

        QuickSorter.Sort(numbers);

        ArrayOutput.PrintArray(numbers);
    }
}