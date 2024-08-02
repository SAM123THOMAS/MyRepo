namespace Day7
{

    public abstract class Animal
    {
        public abstract string Sound { get; }
    }
    public class Cat : Animal
    {
        public override string Sound => "some sound";

    }
    internal class Program
    {
        static void Main0(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}