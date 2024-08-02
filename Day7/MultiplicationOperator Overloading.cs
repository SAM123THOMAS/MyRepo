using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{


    class multiply {

        int num1, num2;

        public multiply(int a, int b)
        {
            num1 = a;
            num2=b;
        }

       public void  Print()
        {
            Console.WriteLine("Number 1 :" + num1 + " \n Number 2: " + num2);
        }

        public static multiply operator *(multiply x, multiply y) 
        {
            multiply result = new multiply(0, 0);
            result.num1 = x.num1 * y.num1;
            result.num2 = x.num2 * y.num2;
            return result;

        }
    }

    internal class MultiplicationOperator_Overloading
    {

        public static void Main()
        {
            multiply s1 = new multiply(2, 6);
            multiply s2 = new multiply(3, 6);
            multiply s3 = s1 * s2;
            s3.Print();
             
        }
    }
}
