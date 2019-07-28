using System;

namespace Homework_L5_Zad10
{
    class Program
    {
        static void Main(string[] args)
        {
            string entryString = Console.ReadLine();
            string resultString = string.Empty;

            for (int i = 0; i < entryString.Length; i++)
            {
                resultString += (char)((int)entryString[i] + 5);
            }

            Console.WriteLine(resultString);
        }
    }
}
