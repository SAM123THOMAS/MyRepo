using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11
{
    internal class LINQ
    {
        static void Main2(string[] args)
        {
            string[] languages = {"Malayalam","Tamil","Hindi","Telugu","Marati" };
            var result = from lang in languages where lang.Contains("M") select lang;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }            }
        }
}
