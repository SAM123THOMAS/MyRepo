namespace Q2_FirstCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string InputString, firstCharacter, OuputString;
            Console.WriteLine("Enter an input string");
            InputString = Console.ReadLine();
            if (InputString.Length > 0)
            {
                firstCharacter = InputString.Substring(0, 1);
                OuputString = firstCharacter + InputString + firstCharacter;
                Console.WriteLine("Output String: " + OuputString);
            }
            else
            { Console.WriteLine("Input String is Empty"); }
        }
    }
}