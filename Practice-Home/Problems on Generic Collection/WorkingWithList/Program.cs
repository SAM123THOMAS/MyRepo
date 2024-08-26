//Task: Create a program that uses a List<T> to store and manage a collection of integers.

//1. Create a List<int> to store integer items.

//2. Add five different integers to the List<int>.

//3. Display all items in the List<int>.

//4. Remove the third item from the List<int>.

//5. Insert a new integer at the second position.

//6. Display the total count of items in the List<int>.

//7. Sort the list in ascending order and display the sorted list.        



using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //create list
        List<int> numbersList = new List<int>();
        //insert 5 items
        numbersList.Add(10);
        numbersList.Add(25);
        numbersList.Add(30);
        numbersList.Add(45);
        numbersList.Add(50);

        //Display
        Console.WriteLine("Initial List:");
        DisplayList(numbersList);

        if (numbersList.Count >= 3)
        {
            numbersList.RemoveAt(2);
        }

        //insert at 2nd position
        numbersList.Insert(1, 99);
        //count
        Console.WriteLine($"\nTotal count of items in List : {numbersList.Count}");

        //sort
        numbersList.Sort();
        //display sorted
        Console.WriteLine("\nSorted List:");
        DisplayList(numbersList);
    }

    // Method to display the list of integers
    static void DisplayList(List<int> list)
    {
        foreach (int number in list)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
