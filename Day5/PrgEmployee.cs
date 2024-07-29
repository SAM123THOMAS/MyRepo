using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Employee
    {
        public int EmployeeId;
        public string EmployeeName;
        public string EmployeeEmail;
        public Employee(int id, string Name, string Email)
        {
            EmployeeId = id;
            EmployeeName = Name;
            EmployeeEmail = Email;
        }
        public void PrintEmployeeData()
        {
            Console.WriteLine(EmployeeId);
            Console.WriteLine(EmployeeName);
            Console.WriteLine(EmployeeEmail);

        }
    }
    internal class PrgEmployee
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(77, "Sam","U77@ust.com");
            employee.PrintEmployeeData();
        }
    }
}
