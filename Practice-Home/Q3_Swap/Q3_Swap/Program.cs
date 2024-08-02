namespace Q3_Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string InputString, OuputString, firstCharacter, lastCharacter;
            Console.WriteLine("Enter an input string");
            InputString = Console.ReadLine();
            if (InputString.Length == 0)
            {
                Console.WriteLine("Input String is Empty");
            }
            else if (InputString.Length > 1)
            {
               
                firstCharacter = InputString.Substring(0,1);
                lastCharacter = InputString.Substring(InputString.Length - 1,1);

                // Create the new string with swapped characters
               OuputString= lastCharacter+ InputString.Substring(1, InputString.Length - 2) + firstCharacter;
               Console.WriteLine("Output String: " + OuputString);
            }
            else
            {
                OuputString = InputString;
                Console.WriteLine("Output String: " + OuputString);
            }
        }
    }
}