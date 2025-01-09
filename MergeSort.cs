using System;

class Program
{
    // Function to merge and sort two arrays using Merge Sort
    public static int[] MergeSort(int[] arr1, int[] arr2)
    {
        // Combine the two arrays into one
        int[] mergedArray = new int[arr1.Length + arr2.Length];
        Array.Copy(arr1, 0, mergedArray, 0, arr1.Length);
        Array.Copy(arr2, 0, mergedArray, arr1.Length, arr2.Length);

        // Perform Merge Sort
        MergeSortHelper(mergedArray, 0, mergedArray.Length - 1);

        return mergedArray;
    }

    // Recursive function to perform Merge Sort
    private static void MergeSortHelper(int[] array, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            // Sort the left half
            MergeSortHelper(array, left, mid);

            // Sort the right half
            MergeSortHelper(array, mid + 1, right);

            // Merge the two halves
            Merge(array, left, mid, right);
        }
    }

    // Function to merge two sorted halves
    private static void Merge(int[] array, int left, int mid, int right)
    {
        int leftSize = mid - left + 1;
        int rightSize = right - mid;

        // Create temporary arrays
        int[] leftArray = new int[leftSize];
        int[] rightArray = new int[rightSize];

        // Copy data to temporary arrays
        Array.Copy(array, left, leftArray, 0, leftSize);
        Array.Copy(array, mid + 1, rightArray, 0, rightSize);

        // Merge the temporary arrays back into the original array
        int i = 0, j = 0, k = left;

        while (i < leftSize && j < rightSize)
        {
            if (leftArray[i] <= rightArray[j])
            {
                array[k] = leftArray[i];
                i++;
            }
            else
            {
                array[k] = rightArray[j];
                j++;
            }
            k++;
        }

        // Copy remaining elements of leftArray, if any
        while (i < leftSize)
        {
            array[k] = leftArray[i];
            i++;
            k++;
        }

        // Copy remaining elements of rightArray, if any
        while (j < rightSize)
        {
            array[k] = rightArray[j];
            j++;
            k++;
        }
    }

    static void Main(string[] args)
    {
        // Example input arrays
        int[] array1 = { 10, 15, 20, 25 };
        int[] array2 = { 5, 12, 18, 30 };

        Console.WriteLine("Array 1: " + string.Join(", ", array1));
        Console.WriteLine("Array 2: " + string.Join(", ", array2));

        // Merge and sort the arrays
        int[] sortedArray = MergeSort(array1, array2);

        Console.WriteLine("Merged and Sorted Array: " + string.Join(", ", sortedArray));
    }
}
