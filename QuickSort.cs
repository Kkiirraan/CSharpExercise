using System;

class Program
{
    // Function to perform Quick Sort
    public static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            // Partition the array and get the pivot index
            int pivotIndex = Partition(arr, low, high);

            // Recursively sort elements before and after the partition
            QuickSort(arr, low, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, high);
        }
    }

    // Function to partition the array
    private static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high]; // Choosing the last element as the pivot
        int i = low - 1;       // Index of the smaller element

        for (int j = low; j < high; j++)
        {
            // If the current element is smaller than or equal to the pivot
            if (arr[j] <= pivot)
            {
                i++;
                // Swap arr[i] and arr[j]
                Swap(arr, i, j);
            }
        }

        // Swap the pivot element with the element at i + 1
        Swap(arr, i + 1, high);

        return i + 1; // Return the pivot index
    }

    // Function to swap two elements in the array
    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    static void Main(string[] args)
    {
        // Example input array
        int[] array = { 10, 80, 30, 90, 40, 50, 70 };

        Console.WriteLine("Original Array: " + string.Join(", ", array));

        // Perform Quick Sort
        QuickSort(array, 0, array.Length - 1);

        Console.WriteLine("Sorted Array: " + string.Join(", ", array));
    }
}
