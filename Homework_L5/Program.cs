using System;
using System.Linq;

namespace Homework_L5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entryLine = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < entryLine.Length; i++)
            {
                Console.Write(entryLine[i].ToUpper() + " " + entryLine[i].ToLower() + " ");
            }
            Console.Write(Environment.NewLine);
        }
    }
}
