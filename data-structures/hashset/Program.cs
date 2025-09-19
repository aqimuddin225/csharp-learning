using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> hashSet = new();

        // Add elements to the HashSet
        hashSet.Add(1);
        hashSet.Add(2);
        hashSet.Add(3);
        hashSet.Add(2); // Duplicate, will not be added

        // Display the elements in the HashSet
        Console.WriteLine("Elements in HashSet:");
        foreach (var item in hashSet)
        {
            Console.WriteLine(item);
        }

        // Check if an element exists
        bool containsTwo = hashSet.Contains(2);
        Console.WriteLine($"HashSet contains 2: {containsTwo}");

        // Remove an element
        hashSet.Remove(2);
        Console.WriteLine("Elements in HashSet after removing 2:");
        foreach (var item in hashSet)
        {
            Console.WriteLine(item);
        }

        // Check the count of elements
        int count = hashSet.Count;
        Console.WriteLine($"Count of elements in HashSet: {count}");
    }
}