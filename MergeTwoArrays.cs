//-------------------------------------------------------------------------------------------------
//Excerise 2: Merge two given arrays
//-------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
    static void Main() {
        Console.WriteLine("Hello World!");

        var array = mergeSortedArrays();
        foreach( var item in array)
        {
            Console.WriteLine(item.ToString());
        }
    }
    
    // Data Structure given: [0,3,4,31], [3,4,6,30]
    // Assumptions:
    // - Given arrays are static
    // - Arrays will always contain integers
    // Fact:
    // - Array's as data type
    // - Must not use built in fuctions
    // Goal:
    // - return a sorted array containing the two merged arrays
    public static int[] sortArrays(int[] unsortedArray){
        // sort
        for (var j = unsortedArray.Length-1; j > 0; j--) //O(n^2) - Quadratic TC
        {
            for(var i = 0; i < j; i++)
            { 
                if (unsortedArray[i] > unsortedArray[i +1])
                {
                    var temp = unsortedArray[i];
                    unsortedArray[i] =  unsortedArray[i+1];
                    unsortedArray[i+1] = temp;
                }
            }
        }
        return unsortedArray;
    }
    
    public static int[] mergeSortedArrays(){
  
        int[] arr1 = new int[4] {0,3,44,31};
        int[] arr2 = new int[4] {3,-1,6,30};
        
        // merge arrays
        int[] mergedArray;
        mergedArray = arr1.Union(arr2).ToArray();
        
        return sortArrays(mergedArray);
    }
}
