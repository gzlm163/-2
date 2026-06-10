using System;

internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers = ArrayInput.ReadArrayFromConsole();

        BubbleSorter.Sort(numbers);

        ArrayOutput.PrintArray(numbers);
    }
}