//Task: Create a program that uses a HashSet<T> to store and manage a collection of unique integers.

//1. Create a HashSet<int> to store integer items.

//2. Add ten different integers to the HashSet<int>, including some duplicates.

//3. Display all items in the HashSet<int>.

//4. Remove a specific integer from the hash set.

//5. Check if a specific integer exists in the hash set.

//6. Display the total count of unique items in the hash set.
using System;
using System.Collections.Generic;


namespace WorkingWithHashset
{

    class Program
    {
        static void Main()
        {
            // Step 1: Create a HashSet<int> to store integer items
            HashSet<int> numbers = new HashSet<int>();

            // Step 2: Add ten different integers to the HashSet<int>, including some duplicates
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);
            numbers.Add(50);
            numbers.Add(60);
            numbers.Add(70);
            numbers.Add(80);
            numbers.Add(20);  // Duplicate
            numbers.Add(40);  // Duplicate

            // Step 3: Display all items in the HashSet<int>
            Console.WriteLine("All items in the HashSet:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Step 4: Remove a specific integer from the hash set
            numbers.Remove(30);
            Console.WriteLine("\nAfter removing 30:");

            // Display the updated hash set
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Step 5: Check if a specific integer exists in the hash set
            int searchNumber = 50;
            bool exists = numbers.Contains(searchNumber);
            Console.WriteLine($"\nDoes the number {searchNumber} exist in the hash set? {exists}");

            // Step 6: Display the total count of unique items in the hash set
            int count = numbers.Count;
            Console.WriteLine($"\nTotal number of unique items in the hash set: {count}");
        }
    }

}