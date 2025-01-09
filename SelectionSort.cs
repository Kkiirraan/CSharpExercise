using System;

class Program
{
    // Function to perform Selection Sort
    public static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        // Traverse the array
        for (int i = 0; i < n - 1; i++)
        {
            // Find the minimum element in the remaining unsorted array
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap the found minimum element with the first element of the unsorted portion
            if (minIndex != i)
            {
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }
    }

    static void Main(string[] args)
    {
        // Example input array
        int[] array = { 64, 25, 12, 22, 11 };

        Console.WriteLine("Original Array: " + string.Join(", ", array));

        // Perform Selection Sort
        SelectionSort(array);

        Console.WriteLine("Sorted Array: " + string.Join(", ", array));
    }
}
