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

        QuickSort(numbers, 0, numbers.Length - 1);

        Console.WriteLine("Sorted array:");

        for (int elementIndex = 0; elementIndex < numbers.Length; ++elementIndex)
        {
            Console.Write(numbers[elementIndex] + " ");
        }

        Console.WriteLine();
    }

    static void QuickSort(int[] targetArray, int leftIndex, int rightIndex)
    {
        if (leftIndex >= rightIndex)
        {
            return;
        }

        int pivotIndex = Partition(targetArray, leftIndex, rightIndex);

        QuickSort(targetArray, leftIndex, pivotIndex - 1);
        QuickSort(targetArray, pivotIndex + 1, rightIndex);
    }

    static int Partition(int[] targetArray, int leftIndex, int rightIndex)
    {
        int pivotValue = targetArray[rightIndex];
        int storeIndex = leftIndex;

        for (int currentIndex = leftIndex; currentIndex < rightIndex; ++currentIndex)
        {
            if (targetArray[currentIndex] < pivotValue)
            {
                (targetArray[storeIndex], targetArray[currentIndex]) = (targetArray[currentIndex], targetArray[storeIndex]);
                ++storeIndex;
            }
        }

        (targetArray[storeIndex], targetArray[rightIndex]) = (targetArray[rightIndex], targetArray[storeIndex]);

        return storeIndex;
    }
}