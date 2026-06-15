using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] numbers = new int[arraySize];

        Console.WriteLine("Enter array elements:");
        for (int elementIndex = 0; elementIndex < arraySize; ++elementIndex)
        {
            Console.Write($"Element {elementIndex + 1}: ");
            numbers[elementIndex] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("Original array:");
        PrintArray(numbers);

        SmoothSort(numbers);

        Console.WriteLine();
        Console.WriteLine("Sorted array:");
        PrintArray(numbers);
    }

    static void PrintArray(int[] numbers)
    {
        for (int elementIndex = 0; elementIndex < numbers.Length; ++elementIndex)
        {
            Console.Write(numbers[elementIndex] + " ");
        }
        Console.WriteLine();
    }

    static int[] GenerateLeonardoNumbers(int maxOrder)
    {
        if (maxOrder < 0) maxOrder = 0;
        int[] leonardo = new int[maxOrder + 2];
        leonardo[0] = 1;
        leonardo[1] = 1;
        for (int orderIndex = 2; orderIndex <= maxOrder + 1; ++orderIndex)
        {
            leonardo[orderIndex] = leonardo[orderIndex - 1] + leonardo[orderIndex - 2] + 1;
        }
        return leonardo;
    }

    static void SmoothSort(int[] numbers)
    {
        int arrayLength = numbers.Length;
        if (arrayLength < 2) return;

        int maxOrder = (int)Math.Log(arrayLength, 1.618) + 20;
        int[] leonardoNumbers = GenerateLeonardoNumbers(maxOrder);

        int heapSizeMask = 1;
        int currentLeonardoOrder = 1;

        for (int currentIndex = 0; currentIndex < arrayLength; ++currentIndex)
        {
            if ((heapSizeMask & 3) == 3)
            {
                Sift(numbers, currentIndex, currentLeonardoOrder, leonardoNumbers);
                heapSizeMask >>= 2;
                currentLeonardoOrder += 2;
            }
            else
            {
                if (leonardoNumbers[currentLeonardoOrder - 1] >= arrayLength - currentIndex)
                {
                    Trinkle(numbers, currentIndex, heapSizeMask, currentLeonardoOrder, false, leonardoNumbers);
                }
                else
                {
                    Sift(numbers, currentIndex, currentLeonardoOrder, leonardoNumbers);
                }

                if (currentLeonardoOrder == 1)
                {
                    heapSizeMask <<= 1;
                    currentLeonardoOrder = 0;
                }
                else
                {
                    heapSizeMask <<= currentLeonardoOrder - 1;
                    currentLeonardoOrder = 1;
                }
            }

            heapSizeMask |= 1;
        }

        Trinkle(numbers, arrayLength - 1, heapSizeMask, currentLeonardoOrder, false, leonardoNumbers);

        for (int currentIndex = arrayLength - 1; currentIndex > 0; --currentIndex)
        {
            if (currentLeonardoOrder <= 1)
            {
                int trailingZeros = CountTrailingZeros(heapSizeMask);
                heapSizeMask >>= trailingZeros;
                currentLeonardoOrder += trailingZeros;
            }
            else
            {
                heapSizeMask &= ~1;
                heapSizeMask <<= 2;
                heapSizeMask ^= 7;
                currentLeonardoOrder -= 2;

                int index1 = currentIndex - leonardoNumbers[currentLeonardoOrder] - 1;
                if (index1 >= 0)
                {
                    Trinkle(numbers, index1, heapSizeMask >> 1, currentLeonardoOrder + 1, true, leonardoNumbers);
                }
                Trinkle(numbers, currentIndex - 1, heapSizeMask, currentLeonardoOrder, true, leonardoNumbers);
            }
        }
    }

    static void Sift(int[] numbers, int rootIndex, int leonardoOrder, int[] leonardoNumbers)
    {
        int rootValue = numbers[rootIndex];
        while (leonardoOrder > 1)
        {
            int rightChildIndex = rootIndex - 1;
            if (rightChildIndex < 0) break;

            int leftChildIndex = rootIndex - 1 - leonardoNumbers[leonardoOrder - 2];
            if (leftChildIndex < 0) break;

            if (rootValue >= numbers[leftChildIndex] && rootValue >= numbers[rightChildIndex])
                break;

            if (numbers[leftChildIndex] > numbers[rightChildIndex])
            {
                numbers[rootIndex] = numbers[leftChildIndex];
                rootIndex = leftChildIndex;
                --leonardoOrder;
            }
            else
            {
                numbers[rootIndex] = numbers[rightChildIndex];
                rootIndex = rightChildIndex;
                leonardoOrder -= 2;
            }
        }
        numbers[rootIndex] = rootValue;
    }

    static void Trinkle(int[] numbers, int rootIndex, int heapSizeMask, int leonardoOrder, bool isTrusty, int[] leonardoNumbers)
    {
        int rootValue = numbers[rootIndex];
        while (heapSizeMask != 1)
        {
            int previousHeapRootIndex = rootIndex - leonardoNumbers[leonardoOrder];
            if (previousHeapRootIndex < 0) break;

            if (numbers[previousHeapRootIndex] <= rootValue)
                break;

            if (!isTrusty && leonardoOrder > 1)
            {
                int rightChildIndex = rootIndex - 1;
                if (rightChildIndex < 0) break;

                int leftChildIndex = rootIndex - 1 - leonardoNumbers[leonardoOrder - 2];
                if (leftChildIndex < 0) break;

                if (numbers[previousHeapRootIndex] <= numbers[leftChildIndex] ||
                    numbers[previousHeapRootIndex] <= numbers[rightChildIndex])
                    break;
            }

            numbers[rootIndex] = numbers[previousHeapRootIndex];
            rootIndex = previousHeapRootIndex;

            int trailingZeros = CountTrailingZeros(heapSizeMask >> 1);
            heapSizeMask >>= trailingZeros + 1;
            leonardoOrder += trailingZeros + 1;
            isTrusty = false;
        }
        numbers[rootIndex] = rootValue;

        if (!isTrusty)
        {
            Sift(numbers, rootIndex, leonardoOrder, leonardoNumbers);
        }
    }

    static int CountTrailingZeros(int value)
    {
        int zeroCount = 0;
        while ((value & 1) == 0 && value != 0)
        {
            ++zeroCount;
            value >>= 1;
        }
        return zeroCount;
    }
}