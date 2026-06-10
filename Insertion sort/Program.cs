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

        for (int currentIndex = 1; currentIndex < arrayLength; ++currentIndex)
        {
            int keyElement = numbers[currentIndex];
            int previousIndex = currentIndex - 1;

            while (previousIndex >= 0 && numbers[previousIndex] > keyElement)
            {
                numbers[previousIndex + 1] = numbers[previousIndex];
                --previousIndex;
            }

            numbers[previousIndex + 1] = keyElement;
        }

        Console.WriteLine("Sorted array:");
        for (int elementIndex = 0; elementIndex < numbers.Length; ++elementIndex)
        {
            Console.Write(numbers[elementIndex] + " ");
        }

        Console.WriteLine();
    }
}