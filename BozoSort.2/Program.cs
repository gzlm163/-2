using System;

internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers = ArrayInput.ReadArrayFromConsole();

        BozoSorter.Sort(numbers);

        ArrayOutput.PrintArray(numbers);
    }
}