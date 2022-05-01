//----------------------------------------------------------------------------------------------------------------
// This file contains examples on how to implement sorting algorithms
//----------------------------------------------------------------------------------------------------------------
using System;
using System.Collections;

namespace Sorting {
   class MySortingAlgorithms {
        static void Main(string[] args) {
          
            // Given array
            int[] unsortedArray = {23, 9, 85, 12, 99, 34, 60, 15, 100, 1};
            
            // Log to console the unsorted array
            Console.WriteLine("Unsorted:");
            foreach(int value in unsortedArray)
                Console.Write(value + " ");
            Console.WriteLine("\n");
                
            //-------------------------------------------------------
            // Log to console the sorted array - BubbleSort Results
            int[] sortedArray =  BubbleSort(unsortedArray);
            Console.WriteLine("Bubble Sort Result:");
            foreach (int value in sortedArray)
                Console.Write(value + " ");
            Console.WriteLine("\n");
          
            //-------------------------------------------------------
            // Log to console the sorted array - Insertion Results 
            int[] insertSortArray = InsertionSort(unsortedArray);
            Console.WriteLine("Insertion Sort Result:");
            foreach (int value in insertSortArray)
                Console.Write(value + " ");
            Console.WriteLine("\n");
            
            //-------------------------------------------------------
            MergeSort(unsortedArray);
        }
      
        //--------------------------
        // Example 1: Bubble Sort
        //--------------------------
        public static int[] BubbleSort(int[] array)
        {
            int[] arr = array;
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++) {
                for (int i = 0; i <= arr.Length - 2; i++) {
                   if (arr[i] > arr[i + 1]) {
                      temp= arr[i + 1];
                      arr[i + 1] = arr[i];
                      arr[i] = temp;
                   }
                }
            }
            return array;
       }

      
       //--------------------------
       // Example 2: Insertion Sort
       //--------------------------
       //Insertion Sort is a sorting algorithm that takes an element at a time and inserts it in its correct position in the array. This process is continued until the array is sorted.
       public static int[] InsertionSort(int[] array)
       {
           int flag = 0;
           int temp = 0;
           for (var i = 1; i < array.Length; i++) {
               temp = array[i];
               for (var j = i - 1; j >= 0 && flag != 1; ) {
                  if (temp < array[j]) {
                     array[j + 1] = array[j];
                     j--;
                     array[j + 1] = temp;
                  }
                  else flag = 1;
               }
           }
           return array;
       }

      //--------------------------
      // Example 3: Merge Sort
      //--------------------------
      public static void MergeSort(int[] array)
      {
        // verify if the array has more than 1 value
        if (array.Length == 1)
        {
            Console.WriteLine("Nothing to sort!");
        }
          
        // split the array into left and right partials
        int length = array.Length;
        int middle = (int)Math.Floor((decimal)length / 2);
        
        int[] leftSlice = array[0.. middle];
        int[] rightSlice = array[middle..];
        
        // To display slices - not required
        Console.Write("Left Slice: ");
        foreach (int value in leftSlice)
            Console.Write(value + " ");
        Console.Write("\n");
        
        Console.Write("Right Slice: ");
        foreach (int value in rightSlice)
            Console.Write(value + " ");
        Console.Write("\n");            

        int[] sortedArrayResult = new int[] {};
        int leftIndex = 0;
        int rightIndex = 0;
        
        while (leftIndex <= leftSlice.Length-1 && rightIndex <= rightSlice.Length-1)
        {
            if (leftSlice[leftIndex] < rightSlice[rightIndex])
            {
                sortedArrayResult[leftIndex] = leftSlice[leftIndex];
                leftIndex++;
            }
            else
            {
                sortedArrayResult[rightIndex] = rightSlice[rightIndex];
                rightIndex++;
            }
        }
        var result1 = leftSlice[leftIndex].Concat(rightSlice[rightIndex]);
        //sortedArrayResult.Concat(leftSlice[leftIndex], rightSlice[rightIndex]);
        
        Console.Write("Result: ");
        foreach (int value in result1)
            Console.Write(value + " ");
        Console.Write("\n"); 
      }



       //--------------------------
       // Example 4: Quick Sort
       //--------------------------
      public static int[] QuickSort(int[] array)
      {

         return array;
      }
     
    }
}

