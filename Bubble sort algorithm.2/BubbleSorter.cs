public class BubbleSorter
{
    public static void Sort(int[] targetArray)
    {
        int arrayLength = targetArray.Length;

        for (int currentPass = 0; currentPass < arrayLength - 1; ++currentPass)
        {
            for (int currentIndex = 0; currentIndex < arrayLength - 1 - currentPass; ++currentIndex)
            {
                if (targetArray[currentIndex] > targetArray[currentIndex + 1])
                {
                    (targetArray[currentIndex + 1], targetArray[currentIndex]) = (targetArray[currentIndex], targetArray[currentIndex + 1]);
                }
            }
        }
    }
}