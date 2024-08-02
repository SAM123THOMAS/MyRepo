using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8
{
    internal class CalulatorDemo
    {
        public static void Main() 
        {
            Calculator.Calculator obj = new Calculator.Calculator();
            Console.WriteLine(obj.Sum(2, 4));
        }
    }
}
