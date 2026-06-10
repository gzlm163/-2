using System;

public class BozoSorter
{
    private static Random randomGenerator = new Random();

    public static void Sort(int[] targetArray)
    {
        bool isSorted = false;

        while (!isSorted)
        {
            isSorted = true;

            for (int checkIndex = 0; checkIndex < targetArray.Length - 1; ++checkIndex)
            {
                if (targetArray[checkIndex] > targetArray[checkIndex + 1])
                {
                    isSorted = false;
                    break;
                }
            }

            if (!isSorted)
            {
                int firstIndex = randomGenerator.Next(targetArray.Length);
                int secondIndex = randomGenerator.Next(targetArray.Length);

                if (firstIndex != secondIndex)
                {
                    (targetArray[firstIndex], targetArray[secondIndex]) = (targetArray[secondIndex], targetArray[firstIndex]);
                }
            }
        }
    }
}