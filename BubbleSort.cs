using System;

class Program
{
    // Bubble Sort Function
    public static void BubbleSort(int[] array)
    {
        int n = array.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            // Last i elements are already sorted, so no need to check them
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Swap the elements
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;

                    swapped = true;
                }
            }

            // If no two elements were swapped, the array is already sorted
            if (!swapped)
                break;
        }
    }

    static void Main(string[] args)
    {
        // Example usage
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Original array:");
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\nSorting the array using Bubble Sort...");

        BubbleSort(arr);

        Console.WriteLine("Sorted array:");
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
    }
}
