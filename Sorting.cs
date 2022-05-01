//----------------------------------------------------------------------------------------------------------------
// This file contains examples on how to implement sorting algorithms
//----------------------------------------------------------------------------------------------------------------
using System;
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
      public static int[] MergeSort(int[] array)
      {
        // verify if the array has more than 1 value
        if (array.Length == 1)
        {
            Console.WriteLine("Nothing to sort!");
            return array;
        }
          
        // split the array into left and right partials
        int length = array.Length;
        int middle = (int)Math.Floor((decimal)length / 2);
        
        int[] leftIndex = array[0.. middle];
        int[] rightIndex = array[middle..];
        
        // To display slices - not required
        Console.Write("Left Slice: ");
        foreach (int value in leftIndex)
            Console.Write(value + " ");
        Console.Write("\n");
        
        Console.Write("Right Slice: ");
        foreach (int value in rightIndex)
            Console.Write(value + " ");
        Console.Write("\n");            

        //Console.Write(RightIndex);
         
         return array;
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

