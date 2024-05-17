using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public class Factorial
    {
        public static long FactorialRun(long number) 
        {
            // For some reason, I was finding issues with values above 20 in C# (25 was the cap in Java), so I capped it at 20 in this version
            if (number > 20) 
            {
                throw new OverflowException("Numbers greater than 20 will cause integer overflow");
            }

            if (number < 0) 
            {
                throw new ArithmeticException("Factorial is undefined for negative numbers");
            }

            if (number == 0 || number == 1) 
            {
                number = 1;
                return number;
            }

            for (long i = number - 1; i > 0; i--) 
            {
                number *= i;
            }

            return number;
        }

        public static long recursiveFactorialRun(long number)
        {
            // Once again added a recursive version for fun
            if (number > 20)
            {
                throw new OverflowException("Numbers greater than 20 will cause integer overflow");
            }

            if (number < 0)
            {
                throw new ArithmeticException("Factorial is undefined for negative numbers");
            }

            if (number == 0 || number == 1)
            {
                number = 1;
                return number;
            }

            return number * recursiveFactorialRun(number - 1);

        }
        
    }
}
