//Task: Create a program that uses a Dictionary<TKey, TValue> to store and manage a collection of key-value pairs.

//1. Create a Dictionary<string, int> to store student names (key) and their ages (value).

//2.Add five different students and their ages to the Dictionary<string, int>.

//3. Display all key-value pairs in the dictionary.

//4. Remove a student by name.

//5. Update the age of a specific student.

//6. Check if a student exists in the dictionary by name.

//7. Display the total count of students in the dictionary.


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Step 1: Create a Dictionary<string, int> to store student names and their ages
        Dictionary<string, int> students = new Dictionary<string, int>();

        // Step 2: Add five different students and their ages to the Dictionary<string, int>
        students.Add("Sam", 20);
        students.Add("Libin", 22);
        students.Add("Ligin", 19);
        students.Add("Sangeeth", 21);
        students.Add("Abe", 23);

        // Step 3: Display all key-value pairs in the dictionary
        Console.WriteLine("All Students:");
        DisplayDictionary(students);

        // Step 4: Remove a student by name
        string studentToRemove = "Sangeeth";
        if (students.ContainsKey(studentToRemove))
        {
            students.Remove(studentToRemove);
            Console.WriteLine($"\nRemoved {studentToRemove}");
        }
        else
        {
            Console.WriteLine($"\nStudent {studentToRemove} not found");
        }

        // Step 5: Update the age of a specific student
        string studentToUpdate = "Abe";
        if (students.ContainsKey(studentToUpdate))
        {
            students[studentToUpdate] = 25; // Update age to 25
            Console.WriteLine($"\nUpdated {studentToUpdate}'s age");
        }
        else
        {
            Console.WriteLine($"\nStudent {studentToUpdate} not found");
        }

        //Display updated key-value pairs in the dictionary
        Console.WriteLine("\nUpdated Students:");
        DisplayDictionary(students);

        // Step 6: Check if a student exists in the dictionary by name
        string studentToCheck = "Sam";
        if (students.ContainsKey(studentToCheck))
        {
            Console.WriteLine($"\nStudent {studentToCheck} exists in the dictionary");
        }
        else
        {
            Console.WriteLine($"\nStudent {studentToCheck} does not exist in the dictionary");
        }


        // Step 7: Display the total count of students in the dictionary
        Console.WriteLine($"\nTotal count of students: {students.Count}");
    }

    // Method to display all key-value pairs in the dictionary
    static void DisplayDictionary(Dictionary<string, int> dictionary)
    {
        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
