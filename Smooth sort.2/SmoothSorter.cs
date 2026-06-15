using System;

public static class SmoothSorter
{
    public static void Sort(int[] targetArray)
    {
        int arrayLength = targetArray.Length;
        if (arrayLength == 0) return;

        int[] leonardoNumbers = new int[arrayLength + 1];
        leonardoNumbers[0] = 1;
        leonardoNumbers[1] = 1;
        for (int leonardoIndex = 2; leonardoIndex <= arrayLength; ++leonardoIndex)
        {
            leonardoNumbers[leonardoIndex] = leonardoNumbers[leonardoIndex - 1] + leonardoNumbers[leonardoIndex - 2] + 1;
        }

        int heapCount = 0;
        int lastHeapSize = 0;
        int lastHeapOffset = 0;

        for (int currentIndex = 0; currentIndex < arrayLength; ++currentIndex)
        {
            if (heapCount > 0 && lastHeapSize == leonardoNumbers[heapCount])
            {
                ++heapCount;
                lastHeapSize = leonardoNumbers[heapCount];
            }
            else if (heapCount > 1 && lastHeapSize == leonardoNumbers[heapCount - 1] + 1)
            {
                heapCount = heapCount - 1;
                lastHeapSize = leonardoNumbers[heapCount];
            }
            else
            {
                if (heapCount == 0)
                {
                    heapCount = 1;
                    lastHeapSize = leonardoNumbers[1];
                }
                else
                {
                    heapCount = heapCount + 1;
                    lastHeapSize = leonardoNumbers[heapCount];
                }
            }

            lastHeapOffset = currentIndex + 1 - lastHeapSize;

            int heapRootIndex = lastHeapOffset;
            int leftChildIndex = heapRootIndex + leonardoNumbers[heapCount - 1] + 1;
            int rightChildIndex = heapRootIndex + leonardoNumbers[heapCount - 2] + 1;

            if (heapCount > 1 && leftChildIndex <= currentIndex)
            {
                if (targetArray[leftChildIndex] > targetArray[heapRootIndex])
                {
                    (targetArray[leftChildIndex], targetArray[heapRootIndex]) = (targetArray[heapRootIndex], targetArray[leftChildIndex]);
                }
            }

            if (heapCount > 2 && rightChildIndex <= currentIndex)
            {
                if (targetArray[rightChildIndex] > targetArray[heapRootIndex])
                {
                    (targetArray[rightChildIndex], targetArray[heapRootIndex]) = (targetArray[heapRootIndex], targetArray[rightChildIndex]);
                }
            }
        }

        for (int currentIndex = arrayLength - 1; currentIndex >= 0; --currentIndex)
        {
            int rootIndex = 0;
            int heapToExtract = 0;
            int tempOffset = 0;

            for (int heapIndex = 1; heapIndex <= heapCount; ++heapIndex)
            {
                int heapSize = leonardoNumbers[heapIndex];
                int heapOffset = currentIndex + 1 - heapSize;

                if (heapOffset <= tempOffset)
                {
                    break;
                }

                if (targetArray[heapOffset] > targetArray[rootIndex])
                {
                    rootIndex = heapOffset;
                    heapToExtract = heapIndex;
                }

                tempOffset = heapOffset;
            }

            if (rootIndex != currentIndex)
            {
                (targetArray[rootIndex], targetArray[currentIndex]) = (targetArray[currentIndex], targetArray[rootIndex]);
            }

            if (heapToExtract > 1)
            {
                int heapSize = leonardoNumbers[heapToExtract];
                int heapOffset = currentIndex - heapSize + 1;

                int leftHeapSize = leonardoNumbers[heapToExtract - 1];
                int rightHeapSize = leonardoNumbers[heapToExtract - 2];

                int leftHeapOffset = heapOffset + leftHeapSize + 1;
                int rightHeapOffset = heapOffset + leonardoNumbers[heapToExtract - 1] + 1;

                heapCount = heapCount + 1;
                lastHeapSize = leonardoNumbers[heapCount];
                lastHeapOffset = leftHeapOffset;

                heapCount = heapCount + 1;
                lastHeapSize = leonardoNumbers[heapCount];
                lastHeapOffset = rightHeapOffset;
            }
        }
    }
}