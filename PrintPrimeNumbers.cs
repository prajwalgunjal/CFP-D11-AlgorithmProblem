using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblem
{
    internal class PrintPrimeNumbers
    {
        public void PrintPrimeNumber(int start, int end)
        {
            for (int number = start; number <= end; number++)
            {
                if (IsPrime(number))
                {
                    Console.WriteLine(number);
                }
            }
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
