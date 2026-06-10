using System;

public class Bogosorter
{
    private static Random randomGenerator = new Random();

    public static void Sort(int[] targetArray)
    {
        while (!IsSorted(targetArray))
        {
            Shuffle(targetArray);
        }
    }

    private static bool IsSorted(int[] targetArray)
    {
        for (int elementIndex = 0; elementIndex < targetArray.Length - 1; ++elementIndex)
        {
            if (targetArray[elementIndex] > targetArray[elementIndex + 1])
            {
                return false;
            }
        }
        return true;
    }

    private static void Shuffle(int[] targetArray)
    {
        for (int elementIndex = 0; elementIndex < targetArray.Length; ++elementIndex)
        {
            int randomIndex = randomGenerator.Next(elementIndex, targetArray.Length);
            (targetArray[elementIndex], targetArray[randomIndex]) = (targetArray[randomIndex], targetArray[elementIndex]);
        }
    }
}