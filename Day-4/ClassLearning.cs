using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class Employee
    {
        //fields
        public int ID;
        public string Name;
        public string Salary;
        public string Gender;


        //Methods

        public void GetData(Employee emp) 
        {
            Console.WriteLine("Enter Employee ID:");
        emp.ID=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            emp.Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Saalary:");
            emp.Salary = Console.ReadLine();
            Console.WriteLine("Enter Employee Gender:");
            emp.Gender = Console.ReadLine();

        }
        public void PrintData(Employee employee)
        {
            Console.WriteLine("Employeee Details are :");
            Console.WriteLine(employee.ID);
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Salary);
            Console.WriteLine(employee.Gender);
        }
    }
    internal class Classesdemo
    {
        public static void Main()
        {
            Employee employee = new Employee();
            /* employee.Name = "Sam";
             employee.ID = 77606;
             employee.Gender = "Male";
             employee.Salary = "2k"; */
            employee.GetData(employee);
            employee.PrintData(employee);


        }
    }
}