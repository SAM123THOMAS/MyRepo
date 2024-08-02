using System.Runtime.InteropServices;

namespace Day_8
{
    public abstract class Animal
    {
        public abstract string Sound { get; }

        public virtual void Move()
        {
            Console.WriteLine("Animal is moving in base class");
        }
       // public  abstract void Print();
    }

    public class Cat : Animal
    {
        public override string Sound => "Meow";
        public override void Move()
        {
            Console.WriteLine("Cat is moving in derived class");

        }
    }
    public class Dog : Animal
    {
        public override string Sound => "Bark";
        public override void Move()
        {
            Console.WriteLine("Dog is moving in derived class");

        }
    }

    public class Cow : Animal
        {
        public override string Sound => "Moo";
        public override void Move()
        {
            Console.WriteLine("Cow is moving in derived class");

        }
        

    }
    public class Snake : Animal
    {
        public override string Sound => "Pissss";
        public override void Move()
        {
            Console.WriteLine("Sanke is moving in derived class");

        }

    }

    internal class Program
    {
        static void Main1(string[] args)
        {


            Animal[] animals = new Animal[] { new Cat(), new Dog(), new Cow(), new Snake() };

            foreach (var anim in animals)
            {
                Console.WriteLine($"The {anim.GetType().Name} goes {anim.Sound}");
                anim.Move();
            }
        }
    }
}