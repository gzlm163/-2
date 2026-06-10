using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the length of the array: ");
        int arrayLength = int.Parse(Console.ReadLine());

        int[] numbers = new int[arrayLength];

        for (int elementIndex = 0; elementIndex < arrayLength; ++elementIndex)
        {
            Console.Write($"Enter element {elementIndex + 1}: ");
            numbers[elementIndex] = int.Parse(Console.ReadLine());
        }

        int arrayLengthLocal = numbers.Length;

        for (int currentIndex = 0; currentIndex < arrayLengthLocal - 1; ++currentIndex)
        {
            int minimumIndex = currentIndex;

            for (int searchIndex = currentIndex + 1; searchIndex < arrayLengthLocal; ++searchIndex)
            {
                if (numbers[searchIndex] < numbers[minimumIndex])
                {
                    minimumIndex = searchIndex;
                }
            }

            if (minimumIndex != currentIndex)
            {
                (numbers[currentIndex], numbers[minimumIndex]) = (numbers[minimumIndex], numbers[currentIndex]);
            }
        }

        Console.WriteLine("Sorted array:");

        for (int elementIndex = 0; elementIndex < numbers.Length; ++elementIndex)
        {
            Console.Write(numbers[elementIndex] + " ");
        }

        Console.WriteLine();
    }
}