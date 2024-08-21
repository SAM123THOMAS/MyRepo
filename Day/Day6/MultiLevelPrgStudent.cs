using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Person
    {
        public string Name;
        //private int Age;
        public int Age;

       
        public void Greet()
        {
            Console.Write($"\n Hello, my name is {Name}.");
        }

      
        public void SetAge(int age)
        {
            Age = age;
        }
        //public int GetAge()
        //{
        //    return Age;
        //}

    }
    class Student: Person
    { 
        public void Study() 
        {
            Console.Write("I'm studying.");
        }
        public void ShowAge()
        {
            Console.Write($"My age is: {Age} years old.");
        }
    }
    class Teacher: Person
    {
        public void Explain()
        {
            Console.Write("I'm explaining.");
        }
    }
    internal class MultiLevelPrgStudent
    {
        public class StudentProfessorTest
        {
            public static void Main5()
            {
            
                Person person = new Person();
                person.Name = "Sam";
                person.Greet();

               
                Student student = new Student();
                student.Name = "Max";
                student.SetAge(23);
                student.Greet();
                student.ShowAge();
                student.Study();

              
                Teacher teacher = new Teacher();
                teacher.Name = "James";
                teacher.SetAge(40);
                teacher.Greet();
                teacher.Explain();
            }
        }
    }
}
