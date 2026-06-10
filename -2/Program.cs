using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the length of the array:");

        int arrayLength = int.Parse(Console.ReadLine());
        int[] numbers = new int[arrayLength];

        for (int elementIndex = 0; elementIndex < arrayLength; ++elementIndex)
        {
            Console.Write($"Enter element {elementIndex + 1}: ");
            numbers[elementIndex] = int.Parse(Console.ReadLine());
        }

        for (int currentPass = 0; currentPass < arrayLength - 1; ++currentPass)
        {
            for (int currentIndex = 0; currentIndex < arrayLength - 1 - currentPass; ++currentIndex)
            {
                if (numbers[currentIndex] > numbers[currentIndex + 1])
                {
                    (numbers[currentIndex + 1], numbers[currentIndex]) = (numbers[currentIndex], numbers[currentIndex + 1]);
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