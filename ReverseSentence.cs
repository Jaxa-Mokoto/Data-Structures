//---------------------------------------------------------------------------------------------------
//Excerise #1: Reverse a given sentence 'My Name Is Bob' without making use of Built In Functions
//---------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
    static void Main() {
        Console.WriteLine(reverse("Hi My Name Is Bob"));
    }
    
    // Reverse a string "Hi My Name Is Bob"
    public static string reverse(string stringToReverse) {
        
        // Validate Input
        // Assumption: function will always accept T<string>
        if (String.IsNullOrEmpty(stringToReverse))
        {
            var error = "Hmm this string is invalid";
            return error;
        }
        
        // Will store the reversed string
        string stringOutput = string.Empty;
        string [] arrayReversed;
         
        // Loop through each element in the string and store in array
        for (var pos = stringToReverse.Length - 1; pos > -1; pos--)
        {
            stringOutput = stringOutput + stringToReverse[pos];
        }
        return stringOutput;
    }
}
