using System;
using System.Linq;

namespace Homework_L5_Zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            //neqsno uslovie!!!!!!!
            string[] entryLine = Console.ReadLine().Split().ToArray();
            bool containsEqualChars = false;

            for (int i = 0; i < entryLine[1].Length; i++)
            {
                if (entryLine[1][i] == entryLine[0][0])
                {
                    containsEqualChars = true;
                }
            }

            if (containsEqualChars == true)
            {
                for (int i = 0; i < entryLine[1].Length; i++)
                {
                    if (entryLine[1][i] == entryLine[0][0])
                    {
                        Console.WriteLine(entryLine[0]);
                    }
                    else
                    {
                        Console.WriteLine(entryLine[1][i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Words does not contain equal chars.");
            }
        }
    }
}
