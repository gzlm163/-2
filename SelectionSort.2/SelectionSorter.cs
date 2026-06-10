public class SelectionSorter
{
    public static void Sort(int[] targetArray)
    {
        int arrayLength = targetArray.Length;

        for (int currentIndex = 0; currentIndex < arrayLength - 1; ++currentIndex)
        {
            int minimumIndex = currentIndex;

            for (int searchIndex = currentIndex + 1; searchIndex < arrayLength; ++searchIndex)
            {
                if (targetArray[searchIndex] < targetArray[minimumIndex])
                {
                    minimumIndex = searchIndex;
                }
            }

            if (minimumIndex != currentIndex)
            {
                (targetArray[currentIndex], targetArray[minimumIndex]) = (targetArray[minimumIndex], targetArray[currentIndex]);
            }
        }
    }
}