using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[2,2], matrix2 = new int[2,2], result = new int[2,2];
            Console.WriteLine("Enter first matrix elements:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrix1[i,j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter second matrix elements:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrix2[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            Console.WriteLine("First Matrix:");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matrix1[i, j] + "  ");

                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Second Matrix:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matrix2[i, j] + "  ");

                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("Result Matrix:");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(result[i, j] + "  ");

                }
                Console.WriteLine("\n");
            }

        }
    }
}
