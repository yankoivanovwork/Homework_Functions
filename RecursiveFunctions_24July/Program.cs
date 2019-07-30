using System;

namespace RecursiveFunctions_24July
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FibunacciSequence(7));
        }

        private static int FibunacciSequence(int sizeN, int nextNumber = 1, int previousNumber = 0)
        {
            if (sizeN < 2)
            {
                return nextNumber;
            }
            else
            {
                return FibunacciSequence(sizeN - 1, nextNumber + previousNumber, nextNumber);
            }
        }
    }
}
