using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class OversidePersonClass
    {
        public string Name;

        
        public OversidePersonClass(string name)
        {
            Name = name;
        }

        ~OversidePersonClass()
        {
            Name = string.Empty;
        }

        
        public override string ToString()
        {
            return "Hello! My name is "+ Name;
        }
    }

    class Program
    {
        static void Main3()
        {
            
            Person[] people = new Person[3];

           
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter a name: ");
                string name = Console.ReadLine();
               // people[i] = new Person(name);
            }

            
            foreach (Person person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
