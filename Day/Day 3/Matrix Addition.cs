using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class Class2
    {
        static void Main3(string[] args)
        {
            int[] matrix1 = new int[4], matrix2 = new int[4], result = new int[4];
            Console.WriteLine("Enter first matrix elements:");
            for (int i = 0; i < matrix1.Length; i++)
            {
                matrix1[i] = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("Enter second matrix elements:");
            for (int i = 0; i < matrix2.Length; i++)
            {
                matrix2[i] = Convert.ToInt16(Console.ReadLine());
            }

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = matrix1[i] + matrix2[i];
            }

            Console.WriteLine("Result Matrix:");

            for (int i = 0; i < matrix2.Length; i++)
            {
                Console.WriteLine(result[i]);
                if ((i + 1) % 2 != 0) { Console.WriteLine("\t"); }
                else { Console.WriteLine("\n"); }
            }

        }
    }
}
