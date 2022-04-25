//Given two arrays' sort the arrays and then merge them 
// {0,3,44,31};
// {3,-1,6,30};    
using System;
using System.Linq;

public class HelloWorld
{
    // instantiate the arrays

    
    public static void Main(string[] args)
    {
        int[] array1 = new int[4] {0,3,44,31};
        int[] array2 = new int[4] {3,-1,6,30};
        
        int[] mergedArray = mergeArrays(array1, array2);
        Console.WriteLine("Unsorted Merged Array: ");
        Console.WriteLine(String.Join(",", mergedArray));
        
        int[] mergedAndSortedArray = sortArray(mergedArray);
        Console.WriteLine("Sorted and Merged Array: ");
        Console.WriteLine(String.Join(",",mergedAndSortedArray));
    }
    
    // method to merge the arrays
    public static int[] mergeArrays(int[] array1, int[] array2)
    {
        foreach(var item in array2)
        {
            array1 = array1.Append(item).ToArray(); //BigO of O(n) - push  
        }
        return array1;
    }
    
    // method to sort the array after merge
    public static int[] sortArray(int[] mergedArray)
    {
        for (var j = mergedArray.Length -1; j > 0; j--)
        {
            for (var i = 0; i < j; i++)
            {
                var temp = mergedArray[i];
                if (mergedArray[i] > mergedArray[i+1])
                {
                    mergedArray[i] = mergedArray[i+1];
                    mergedArray[i+1] = temp;
                }
            }
        }
        return mergedArray;
    }   
}
