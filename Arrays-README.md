// There are two types of arrays, Dynamic and Static arrays.
// The best way to think of strings is as an Array.
// Arrays have the following Big O' notation:

----------
  Dynamic
----------
Lookup: O(1)
Push:   O(1)
Insert: O(n)
Delete: O(n)

---------
 Static
---------
Lookup: O(1)
Append*: O(1) // Can be O(n) as dynamic arrays will reallocate memory when appending arrays by looping through each definied element
Insert: O(n)
Delete: O(n)
