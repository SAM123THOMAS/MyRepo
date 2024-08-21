using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{

    class Sample
    {
        int Number1, Number2;
        public Sample(int a, int b)
        {
            Number1 = a; Number2 = b;
        }
        public void Print()
        {
            Console.WriteLine("Number 1 :" + Number1 + " \n Number 2: " + Number2);
        }

        public static Sample operator +(Sample a1, Sample a2)
        {
            Sample a3 = new Sample(0, 0);
            a3.Number1 = a1.Number1 + a2.Number1;
            a3.Number2 = a1.Number2 + a2.Number2;
            return a3;

        }
    }
    internal class OpeartorOverload
    {
        public static void Main3()
        {
            Sample s1 = new Sample(1, 2);
            Sample s2 = new Sample(2, 4);
            Sample s3 = s1 + s2;
            s3.Print();

        }
    }
}