//----------------------------------
//Example: creating hash tables
//----------------------------------

using System;
using System.Collections;
using System.Linq;

class MainClass {
    static void Main() {
        // Initialise the Hash Table
        Hashtable myHashtable = new Hashtable()
        { //Can also add items this way
            {3, "Three"},
            {4, "Four"},
            {"Pi", 3.14}
        };
        
        // To Add Items using Key-Value pairs
        myHashtable.Add(1, "One");
        myHashtable.Add(2, "Two");
        
        // To retrieve value of hash table
        Console.WriteLine($"The value of one is " + (string)myHashtable[1]);
        
        //------------------------------------------------------------------
        //Example Two: creating hash tables and cast values from Dictionary
        //------------------------------------------------------------------
        
        // Casting each element in Dictionary to Hash Table
        // Instantiate the Dictionary
        Dictionary<int, string> myDictionary = new Dictionary<int, string>() {
            {10, "Ten"},
            {11, "Eleven"}
        };
        
        // Now cast to Hashtable
        Hashtable myHashtableFromDictionary = new Hashtable(myDictionary);
        
        // To remove a value from a Hashtable
        myHashtableFromDictionary.Remove(11);
        
        // To see if a key exists in a hash table (and v/v with ContainsValue(value) & Contains(key, value))
        myHashtableFromDictionary.ContainsKey(11);
        
        // To retrieve value of hash table
        Console.WriteLine($"The value of eleven is  {(string)myHashtableFromDictionary[11]}");
        
        // To see each dictionary item in the hashtable
        foreach (DictionaryEntry value in myHashtableFromDictionary){
            Console.WriteLine($"Key:  {value.Key}, value: {value.Value}");
        }
    }
}
