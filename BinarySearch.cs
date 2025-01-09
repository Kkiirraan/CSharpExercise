using System;

class Program
{
    // Binary Search Function
    public static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            // Check if the target is present at mid
            if (array[mid] == target)
            {
                return mid; // Target found, return its index
            }
            // If the target is greater, ignore the left half
            else if (array[mid] < target)
            {
                left = mid + 1;
            }
            // If the target is smaller, ignore the right half
            else
            {
                right = mid - 1;
            }
        }

        return -1; // Target not found
    }

    static void Main(string[] args)
    {
        // Example usage
        int[] arr = { 2, 4, 7, 10, 15, 20 };
        Console.WriteLine("Enter the number to search:");
        int target = int.Parse(Console.ReadLine());
        int result = BinarySearch(arr, target);
        if (result != -1)
        {
            Console.WriteLine($"Number found at index: {result}");
        }
        else
        {
            Console.WriteLine("Number not found.");
        }
    }
}
