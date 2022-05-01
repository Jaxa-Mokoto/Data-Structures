//----------------------------------------------------------------------------------------------------------------
// This file contains examples on how to implement sorting algorithms
//----------------------------------------------------------------------------------------------------------------
using System;
namespace Sorting {
   class MySortingAlgorithms {
        static void Main(string[] args) {
          
          // Given array
            int[] unsortedArray = { 78, 55, 45, 98, 13 };
            
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
          //-------------------------------------------------------
          
          
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





// Example 3: Merge Sort





// Example 4: Quick Sort

     
    }
}

