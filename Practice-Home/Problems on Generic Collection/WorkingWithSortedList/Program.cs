//Task: Create a program that uses a SortedList<TKey, TValue> to store and manage a collection of employee names (key) and their salaries (value).

//1.Create a SortedList<string, double> to store employee names (key) and their salaries (value).

//2. Add five different employees and their salaries to the SortedList<string, double>.

//3. Display all key-value pairs in the sorted list.

//4. Remove an employee by name.

//5. Update the salary of a specific employee.

//6. Display the total count of employees in the sorted list.

using System;
using System.Collections.Generic;

namespace WorkingWithSortedList
{
    

    class Program
    {
        static void Main()
        {
            // Step 1: Create a SortedList<string, double> to store employee names and their salaries
            SortedList<string, double> employeeSalaries = new SortedList<string, double>();

            // Step 2: Add five different employees and their salaries to the SortedList<string, double>
            employeeSalaries.Add("David", 60000);
            employeeSalaries.Add("Eve", 75000);
            employeeSalaries.Add("Alice", 65000);
            employeeSalaries.Add("Bob", 55000);
            employeeSalaries.Add("Charlie", 70000);
            

            // Step 3: Display all key-value pairs in the sorted list
            Console.WriteLine("Employees and their salaries:");
            foreach (KeyValuePair<string, double> kvp in employeeSalaries)
            {
                Console.WriteLine($"{kvp.Key}: ${kvp.Value}");
            }

            // Step 4: Remove an employee by name
            employeeSalaries.Remove("Charlie");
            Console.WriteLine("\nAfter removing Charlie:");

            // Display the updated list of employees and their salaries
            foreach (KeyValuePair<string, double> kvp in employeeSalaries)
            {
                Console.WriteLine($"{kvp.Key}: ${kvp.Value}");
            }

            // Step 5: Update the salary of a specific employee
            employeeSalaries["Alice"] = 68000;
            Console.WriteLine("\nAfter updating Alice's salary:");

            // Display the updated list of employees and their salaries
            foreach (KeyValuePair<string, double> kvp in employeeSalaries)
            {
                Console.WriteLine($"{kvp.Key}: ${kvp.Value}");
            }

            // Step 6: Display the total count of employees in the sorted list
            int employeeCount = employeeSalaries.Count;
            Console.WriteLine($"\nTotal number of employees: {employeeCount}");
        }
    }

}