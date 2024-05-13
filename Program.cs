using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Out in main -- calls from the C# factorial class made by me
            long myNum = Factorial.FactorialRun(20);
            long myNum2 = Factorial.recursiveFactorialRun(20);

            long myNum3 = Factorial.FactorialRun(0);
            long myNum4 = Factorial.recursiveFactorialRun(0);

            Console.WriteLine("Num1: " + myNum);
            Console.WriteLine("Num2: " + myNum2);
            Console.WriteLine("Num3: " + myNum3);
            Console.WriteLine("Num4: " + myNum4);
        }
    }
}
