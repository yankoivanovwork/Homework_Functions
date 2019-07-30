using System;
using System.Linq;

namespace Homework_L5_Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entryLine = Console.ReadLine().Split().ToArray();
            string[] resultLines = new string[2];

            for (int i = 0; i < 5; i++)
            {
                resultLines[0] += entryLine[1][i];

                resultLines[1] += entryLine[0][i];
            }

            for (int i = 5; i < entryLine[0].Length; i++)
            {
                resultLines[0] += entryLine[0][i];
            }

            for (int i = 5; i < entryLine[1].Length; i++)
            {
                resultLines[1] += entryLine[1][i];
            }

            if (resultLines[0].Length> resultLines[1].Length)
            {
                Console.WriteLine(resultLines[0].Length + " " + resultLines[0]);
            }
            else
            {
                Console.WriteLine(resultLines[1].Length + " " + resultLines[1]);
            }
        }
    }
}
