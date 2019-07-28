using System;
using System.Linq;

namespace Homework_L5_Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entryLine = Console.ReadLine().Split(',').ToArray();
            int[] asciiCodeCounter = new int[2];

            for (int i = 0; i < entryLine[0].Length; i++)
            {
                if (entryLine[0][i]!=' ')
                {
                    asciiCodeCounter[0] += (int)entryLine[0][i];
                }
            }

            for (int i = 0; i < entryLine[1].Length; i++)
            {
                if (entryLine[0][i] != ' ')
                {
                    asciiCodeCounter[1] += (int)entryLine[1][i];
                }
            }

            if (asciiCodeCounter[0] > asciiCodeCounter[1])
            {
                Console.WriteLine(entryLine[0]);
            }
            else
            {
                Console.WriteLine(entryLine[1]);
            }
        }
    }
}
