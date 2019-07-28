using System;
using System.Linq;

namespace Homework_L5_Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entryLine = Console.ReadLine().Replace(" ", string.Empty).Split(',').ToArray();

            for (int i = 0; i < entryLine[0].Length; i++)
            {
                if (entryLine[0][i] != entryLine[1][i])
                {
                    Console.WriteLine((i + 1) + " " + entryLine[0][i] + "-"+ entryLine[1][i]);
                }
            }
        }
    }
}
