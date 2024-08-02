namespace Q4_ThreeCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string InputString, first3Character, OuputString;
            Console.WriteLine("Enter an input string");
            InputString = Console.ReadLine();
            if (InputString.Length == 0)
            {
                Console.WriteLine("Input String is Empty");
            }
            else if (InputString.Length > 3)
            {
                first3Character = InputString.Substring(0, 3);
                OuputString = first3Character + InputString + first3Character;
                Console.WriteLine("Output String: " + OuputString);
            }
            else
            {
                OuputString = InputString + InputString + InputString;
                Console.WriteLine("Output String: " + OuputString);
            }
        }
    }
}