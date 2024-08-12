
using System.Text.RegularExpressions;

namespace Day_11
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //string pattern = "^[0-9]{4}$";
            //Regex rex = new Regex(pattern);
            //string x = "3456";
            //if (rex.IsMatch(x))
            //{
            //    Console.WriteLine(x+" is a match of the regex");
            //}
            //else
            //{
            //    Console.WriteLine(x + " is not a match of the regex");
            //}

            string pattern1 = "a*b";
            string pattern2 = "a+b";

            Regex rex = new Regex(pattern2);
            string x = "acccccccccabc";
            Match match=rex.Match(x);
            if (match.Success)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}