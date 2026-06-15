using System;

public class ArrayOutput
{
    public static void PrintArray(int[] targetArray)
    {
        Console.WriteLine("Sorted array:");
        for (int elementIndex = 0; elementIndex < targetArray.Length; ++elementIndex)
        {
            Console.Write(targetArray[elementIndex] + " ");
        }

        Console.WriteLine();
    }
}