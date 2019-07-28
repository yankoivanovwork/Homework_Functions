using System;
using System.Linq;

namespace Homework_L5_Zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            string entryLine = Console.ReadLine();
            string extractedNumber = string.Empty;
            int result = 0;

            for (int i = 0; i < entryLine.Length; i++)
            {
                if (char.IsLetter(entryLine[i]))
                {
                    entryLine = entryLine.Replace(entryLine[i], ' ');
                }
            }

            for (int i = 0; i < entryLine.Length; i++)
            {
                if (entryLine[i] != ' ' && i < entryLine.Length - 1)
                {
                    if (entryLine[i + 1] == ' ' || entryLine[i + 1] == '-')
                    {
                        extractedNumber += entryLine[i];
                        
                        result += int.Parse(extractedNumber);

                        extractedNumber = string.Empty;
                    }
                    else
                    {
                        extractedNumber += entryLine[i];
                    }
                }
                else
                {
                    if (i == entryLine.Length - 1 && entryLine[i] != ' ')
                    {
                        extractedNumber += entryLine[i];

                        result += int.Parse(extractedNumber);
                    }
                }
            }

            Console.WriteLine("Сума = " + result);
        }
    }
}
