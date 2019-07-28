using System;
using System.Linq;

namespace Homework_L5_Zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entryLine = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < entryLine.Length; i++)
            {
                entryLine[i] = char.ToUpper(entryLine[i][0]) + entryLine[i].Substring(1);
            }

            for (int i = 0; i < entryLine.Length; i++)
            {
                Console.Write(entryLine[i] + " ");
            }

            Console.Write(Environment.NewLine);
        }
    }
}
