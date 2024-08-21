using System;

class Person
{
    public string Name { get; set; }

    // Constructor to initialize the Name property
    public Person(string name)
    {
        Name = name;
    }

    // Destructor to clear the Name property
    ~Person()
    {
        Name = string.Empty;
    }

   
}

class Program
{
    static void Main2()
    {
        // Create an array of Person objects
        Person[] people = new Person[3];

        // Prompt user for names and create Person objects
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();
            people[i] = new Person(name);
        }

        // Output the greeting for each person using GetGreeting() method
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Hello! My name is"+ people[i].Name);
        }
    }
}
