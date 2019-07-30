using System;
using System.Linq;

namespace Homework_L5_Zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entryLine = Console.ReadLine().Split().ToArray();
            bool equalCharFound = false;
            int rowPosition = -1;
            int columnPosition = -1;

            for (int i = 0; i < entryLine[0].Length; i++)
            {
                for (int j = 0; j < entryLine[1].Length; j++)
                {
                    if (entryLine[0][i] == entryLine[1][j])
                    {
                        rowPosition = j;
                        columnPosition = i;
                        equalCharFound = true;
                        break;
                    }

                    if (equalCharFound)
                    {
                        break;
                    }
                }
            }

            if (rowPosition > -1 && columnPosition > -1)
            {
                for (int i = 0; i < entryLine[1].Length; i++)
                {
                    if (rowPosition == i)
                    {
                        Console.Write(entryLine[0]);
                    }
                    else
                    {
                        if (rowPosition != -1)
                        {
                            Console.Write(new string(' ', columnPosition));
                        }
                        Console.Write(entryLine[1][i]);
                    }

                    Console.Write(Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Words does not contain equal chars.");
            }
        }
    }
}
