public class QuickSorter
{
    public static void Sort(int[] targetArray)
    {
        QuickSort(targetArray, 0, targetArray.Length - 1);
    }

    private static void QuickSort(int[] targetArray, int leftIndex, int rightIndex)
    {
        if (leftIndex >= rightIndex)
        {
            return;
        }

        int pivotIndex = Partition(targetArray, leftIndex, rightIndex);

        QuickSort(targetArray, leftIndex, pivotIndex - 1);
        QuickSort(targetArray, pivotIndex + 1, rightIndex);
    }

    private static int Partition(int[] targetArray, int leftIndex, int rightIndex)
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