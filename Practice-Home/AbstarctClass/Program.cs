using static AbstarctClass.Program;

namespace AbstarctClass
{
    internal class Program
    {
        public abstract class Animal
        {
            public string Name { get; set; }
            public void  GetName(string value)
            {
                
                SetName(value);                ;
            }
            public void SetName(string name)
            {

                Name = name;
            }
            
            public abstract void Eat();
            }
        public class Dog: Animal
        {
            public override void Eat()
            {
                Console.WriteLine("Eating");
            }
        }

        static void Main(string[] args)
        {
            Animal[] animal = new Animal[] { new Dog() };
            foreach(var anim in animal)
            {
                Console.WriteLine("Enter dog Name: ");
                string value = Console.ReadLine();
                anim.GetName(value);
                Console.WriteLine($"{anim.Name}");
                anim.Eat();
                
            }
        }
    }
}