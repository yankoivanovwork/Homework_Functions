using System;

namespace Homework_L5_Zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            string entryLine = Console.ReadLine();

            //for (int i = 0, j = entryLine.Length - 1; i < entryLine.Length; i++, j--)
            for (int i = 0, j = entryLine.Length - 1; i < Math.Ceiling((double)entryLine.Length / 2); i++, j--)
            {
                if (entryLine[i] != entryLine[j])
                {
                    Console.WriteLine("не");
                    return;
                }
            }

            Console.WriteLine("да");
        }
    }
}
