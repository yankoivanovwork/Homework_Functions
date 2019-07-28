using System;
using System.Linq;

namespace Homework_L5_Zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entryLine = Console.ReadLine().Split().ToArray();
            string longestWord = string.Empty;
            int longestWordLetterCount = int.MinValue;

            for (int i = 0; i < entryLine.Length; i++)
            {
                if (longestWordLetterCount < entryLine[i].Length)
                {
                    longestWord = entryLine[i];
                    longestWordLetterCount = entryLine[i].Length;
                }
            }

            Console.Write(entryLine.Length + " думи, най-дългата е с " + longestWordLetterCount + " символа");
            Console.Write(Environment.NewLine);
        }
    }
}
