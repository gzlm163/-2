public class InsertionSorter
{
    public static void Sort(int[] targetArray)
    {
        int arrayLength = targetArray.Length;

        for (int currentIndex = 1; currentIndex < arrayLength; ++currentIndex)
        {
            int keyElement = targetArray[currentIndex];
            int previousIndex = currentIndex - 1;

            while (previousIndex >= 0 && targetArray[previousIndex] > keyElement)
            {
                targetArray[previousIndex + 1] = targetArray[previousIndex];
                --previousIndex;
            }

            targetArray[previousIndex + 1] = keyElement;
        }
    }
}