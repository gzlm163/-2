using System;

internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers = ArrayInput.ReadArrayFromConsole();

        Bogosorter.Sort(numbers);

        ArrayOutput.PrintArray(numbers);
    }
}