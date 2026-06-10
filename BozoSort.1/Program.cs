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

        Random randomGenerator = new Random();
        bool isSorted = false;

        while (!isSorted)
        {
            isSorted = true;

            for (int checkIndex = 0; checkIndex < numbers.Length - 1; ++checkIndex)
            {
                if (numbers[checkIndex] > numbers[checkIndex + 1])
                {
                    isSorted = false;
                    break;
                }
            }

            if (!isSorted)
            {
                int firstIndex = randomGenerator.Next(numbers.Length);
                int secondIndex = randomGenerator.Next(numbers.Length);

                if (firstIndex != secondIndex)
                {
                    (numbers[firstIndex], numbers[secondIndex]) = (numbers[secondIndex], numbers[firstIndex]);
                }
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