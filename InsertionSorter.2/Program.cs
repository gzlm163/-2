using System;

internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers = ArrayInput.ReadArrayFromConsole();

        InsertionSorter.Sort(numbers);

        ArrayOutput.PrintArray(numbers);
    }
}