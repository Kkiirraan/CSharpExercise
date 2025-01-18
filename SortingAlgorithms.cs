using System;
using System.Collections;
using System.Collections.Generic;

namespace ProgramNameSpace
{
    class Program 
    {
      static void BubbleSort(int[] array)
      {
         int n = array.Length;
         for (int i = 0; i < n - 1; i++)
         {
            for (int j = 0; j < n - i - 1; j++)
            {
                  if (array[j] > array[j + 1])
                  {
                     // Swap array[j] and array[j+1]
                     int temp = array[j];
                     array[j] = array[j + 1];
                     array[j + 1] = temp;
                  }
            }
         }
      }
      static void MergeSort(int[] array, int left, int right)
      {
         if (left < right)
         {
            int mid = left + (right - left) / 2;

            // Sort the first and second halves
            MergeSort(array, left, mid);
            MergeSort(array, mid + 1, right);

            Merge(array, left, mid, right);
         }
      }

         static void Merge(int[] array, int left, int mid, int right)
         {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for (int i = 0; i < n1; i++)
               leftArray[i] = array[left + i];
            for (int j = 0; j < n2; j++)
               rightArray[j] = array[mid + 1 + j];

            int iIndex = 0, jIndex = 0, k = left;

            while (iIndex < n1 && jIndex < n2)
            {
               if (leftArray[iIndex] <= rightArray[jIndex])
               {
                     array[k] = leftArray[iIndex];
                     iIndex++;
               }
               else
               {
                     array[k] = rightArray[jIndex];
                     jIndex++;
               }
               k++;
            }

            while (iIndex < n1)
            {
               array[k] = leftArray[iIndex];
               iIndex++;
               k++;
            }

            while (jIndex < n2)
            {
               array[k] = rightArray[jIndex];
               jIndex++;
               k++;
            }
         }
         static void   SelectionSort(int[] array)
         {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
               int minIndex = i;
               for (int j = i + 1; j < n; j++)
               {
                     if (array[j] < array[minIndex])
                     {
                        minIndex = j;
                     }
               }

               // Swap the found minimum element with the first element
               int temp = array[minIndex];
               array[minIndex] = array[i];
               array[i] = temp;
            }
         }

         static void QuickSort(int[] array, int low, int high)
         {
            if (low < high)
            {
               int partitionIndex = Partition(array, low, high);

               QuickSort(array, low, partitionIndex - 1);
               QuickSort(array, partitionIndex + 1, high);
            }
         }

            static int Partition(int[] array, int low, int high)
            {
               int pivot = array[high];
               int i = low - 1;

               for (int j = low; j < high; j++)
               {
                  if (array[j] < pivot)
                  {
                        i++;
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                  }
               }

               int swapTemp = array[i + 1];
               array[i + 1] = array[high];
               array[high] = swapTemp;

               return i + 1;
            }

      public static void Main(string[] args)
      {
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };
        
        Console.WriteLine("Original Array:");
        Console.WriteLine(string.Join(" ", array));

        // Bubble Sort
        BubbleSort(array);
        Console.WriteLine("\nArray after Bubble Sort:");
        Console.WriteLine(string.Join(" ", array));

        // Reset array for other sorts
        array = new[] { 64, 34, 25, 12, 22, 11, 90 };

        // Merge Sort
        MergeSort(array, 0, array.Length - 1);
        Console.WriteLine("\nArray after Merge Sort:");
        Console.WriteLine(string.Join(" ", array));

        // Reset array for other sorts
        array = new[] { 64, 34, 25, 12, 22, 11, 90 };

        // Selection Sort
        SelectionSort(array);
        Console.WriteLine("\nArray after Selection Sort:");
        Console.WriteLine(string.Join(" ", array));

        // Reset array for other sorts
        array = new[] { 64, 34, 25, 12, 22, 11, 90 };

        // Quick Sort
        QuickSort(array, 0, array.Length - 1);
        Console.WriteLine("\nArray after Quick Sort:");
        Console.WriteLine(string.Join(" ", array));
    
      }
    }

}    
